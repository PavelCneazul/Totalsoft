using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class DATotCeFolosescLaInvoice
    {
        public DATotCeFolosescLaInvoice()
        {
        }

        public DataTable getClients()
        {
            bool status = false;
            DataTable tableData = new DataTable();
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            using (SqlCommand sc = new SqlCommand())
            {
                sc.Connection = conn;
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select ClientId,ClientName,ClientSurname, ClientCode, concat(ClientCode, '     |     ', ClientName, ' ', ClientSurname) AS 'FullName' from TClient ";
                int a = sc.ExecuteNonQuery();
                if (a == 1)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sc;

                adapter.Fill(tableData);
            }
            return tableData;
        }

        public DataTable getClientsAddress(int id)
        {
            bool status = false;
            DataTable tableData = new DataTable();
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            using (SqlCommand sc = new SqlCommand())
            {
                sc.Connection = conn;
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select ca.ClientAddressId, concat(co.CountyName, ' ', ci.CityName, ' ', ca.StreetName, ' ', ca.StreetNo) AS 'Adresa' from TClientAddress ca " +
                    " join TClient c on c.ClientId = ca.ClientId " +
                    " join TCity ci on ci.CityId = ca.CountyId " +
                    " join TCounty co on co.CountyId = ca.CityId " +
                    " where c.ClientId = @Id";
                sc.Parameters.AddWithValue("@Id", id);
                int a = sc.ExecuteNonQuery();
                if (a == 1)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sc;

                adapter.Fill(tableData);
            }
            return tableData;
        }

        public bool insertInvoice(string number, DateTime data, int clientid, int clientaddid, int userid, string obs,
            List<InvoiceDetailModel> lista)
        {
            bool status = false;
            DataTable tableData = new DataTable();
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            using (SqlCommand sc = new SqlCommand())
            {

                //aici trebuie validarea ca numarul facturii sa fie unic


                sc.Connection = conn;
                sc.CommandType = CommandType.Text;
                sc.CommandText = " declare @InvoiceId int " +
                    " exec GetNextId 0, 'TInvoice', @InvoiceId out, 0, 1 " +
                    " insert into TInvoice(InvoiceId, InvoiceNumber, InvoiceDate, ClientId, ClientAddressId, UserId, Observations) " +
                    " select @InvoiceId, @InvoiceNumber, @InvoiceDate, @ClientId, @CliendAddressId, @UserId, @Observations ";
                sc.Parameters.AddWithValue("@InvoiceNumber", number);
                sc.Parameters.AddWithValue("@InvoiceDate", data);
                sc.Parameters.AddWithValue("@ClientId", clientid);
                sc.Parameters.AddWithValue("@CliendAddressId", clientaddid);
                sc.Parameters.AddWithValue("@UserId", userid);
                sc.Parameters.AddWithValue("@Observations", obs);
                if (sc.ExecuteNonQuery() == 1)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

            }
            if (status == true)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].status == 1)
                    {
                        using (SqlCommand sc = new SqlCommand())
                        {
                            SqlCommand vv = new SqlCommand();
                            vv.Connection = conn;
                            vv.CommandType = CommandType.Text;
                            vv.CommandText = " declare @InvoiceId int " +
                            " exec GetNextId 0, 'TInvoice', @InvoiceId out, 0, 1 " +
                            " select @InvoiceId-1";
                            vv.Parameters.AddWithValue("@InvoiceNumber", number);
                            int a = (Int32)vv.ExecuteScalar();

                            sc.Connection = conn;
                            sc.CommandType = CommandType.Text;
                            sc.CommandText = " declare @InvoiceDetailId int " +
                                " exec GetNextId 0, 'TInvoiceDetail', @InvoiceDetailId out, 0, 1 " +
                                " insert into TInvoiceDetail(InvoiceDetailId, InvoiceId, ItemId, Qtty, Price, Amount, Observations) " +
                                " select @InvoiceDetailId, @InvoiceId, (select ItemId from TItem Where concat(ItemCode, '    |    ',ItemName) = @nume), " +
                                " @Qtty, @Price, @Amount, @Observations ";
                            sc.Parameters.AddWithValue("@InvoiceId", a);
                            sc.Parameters.AddWithValue("@nume", lista[i].Item.ItemName);
                            sc.Parameters.AddWithValue("@Qtty", lista[i].Qtty);
                            sc.Parameters.AddWithValue("@Price", lista[i].Price);
                            sc.Parameters.AddWithValue("@Amount", lista[i].Amount);
                            sc.Parameters.AddWithValue("@Observations", lista[i].Observations);
                            if (sc.ExecuteNonQuery() == 1)
                            {
                                status = true;
                            }
                            else
                            {
                                status = false;
                            }
                        }
                    }
                }
            }

            return status;
        }

        public DataTable getInvoices(string invoicenumber, DateTime invoicedateStartFrom, DateTime invoicedateEndto, string  clientid, bool checkstart, bool checkend)
        {
            DataTable dataTable = new DataTable();
            try
            {
                invoicedateEndto.ToString();
                invoicedateStartFrom.ToString();
                SqlConnection connection =
                       new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText =
                    "SELECT i.InvoiceId, i.ClientAddressId, i.ClientId, i.InvoiceNumber, i.InvoiceDate, c.ClientName, c.ClientSurname, concat(co.CountyName, ' ', ci.CityName, ' ', ca.StreetName, ' ', ca.StreetNo) AS 'Adresa', i.Observations from TInvoice i " +
                    " join TClientAddress ca on ca.ClientAddressId = i.ClientAddressId "+
                    " join TCity ci on ci.CityId = ca.CountyId "+
                    " join TCounty co on co.CountyId = ca.CityId "+
                    " join TClient c on c.ClientId = i.ClientId " ;

                if (!String.IsNullOrWhiteSpace(invoicenumber))
                {
                    sqlCmd.CommandText += " where InvoiceNumber LIKE @Nume ";
                    sqlCmd.Parameters.AddWithValue("@Nume", "%" + invoicenumber + "%");
                }
                if (checkstart == true && checkend == false)
                {
                    if (String.IsNullOrWhiteSpace(invoicenumber))
                    {
                        sqlCmd.CommandText += " where InvoiceDate >= @startdata ";
                    }
                    else if (!String.IsNullOrWhiteSpace(invoicenumber))
                    {
                        sqlCmd.CommandText += " and  InvoiceDate >= @startdata ";
                    }
                    sqlCmd.Parameters.AddWithValue("@startdata", invoicedateStartFrom );
                }
                if (checkstart == false && checkend == true)
                {
                    if (String.IsNullOrWhiteSpace(invoicenumber))
                    {
                        sqlCmd.CommandText += " where InvoiceDate <= @endata ";
                    }
                    else if (!String.IsNullOrWhiteSpace(invoicenumber))
                    {
                        sqlCmd.CommandText += " and  InvoiceDate <= @endata ";
                    }
                    sqlCmd.Parameters.AddWithValue("@endata",  invoicedateEndto);
                }
                if (checkstart == true && checkend == true)
                {
                    if (String.IsNullOrWhiteSpace(invoicenumber))
                    {
                        sqlCmd.CommandText += " where InvoiceDate <= @endata ";
                    }
                    else if (!String.IsNullOrWhiteSpace(invoicenumber))
                    {
                        sqlCmd.CommandText += " and  InvoiceDate between @startdata and @endata ";
                    }
                    sqlCmd.Parameters.AddWithValue("@endata", invoicedateEndto);
                    sqlCmd.Parameters.AddWithValue("@startdata", invoicedateStartFrom);
                }
                if (!String.IsNullOrWhiteSpace(clientid))
                {
                    
                    if (String.IsNullOrWhiteSpace(invoicenumber) && checkstart == false && checkend == false)
                    {
                        sqlCmd.CommandText += " where concat(ClientCode, '     |     ', ClientName, ' ', ClientSurname) like @ClientId ";
                    }
                    else if (!String.IsNullOrWhiteSpace(invoicenumber) || checkstart == true || checkend == true)
                    {
                        sqlCmd.CommandText += " and  concat(ClientCode, '     |     ', ClientName, ' ', ClientSurname) like @ClientId ";
                    }
                    sqlCmd.Parameters.AddWithValue("@ClientId", "%" + clientid + "%");
                }
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                dataTable.Load(reader);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getItems()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection =
                      new SqlConnection(Properties.Resources.ConnectionString);
            connection.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select ItemId, concat(ItemCode, '    |    ',ItemName) as 'Item' from TItem";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
        }

        public int getInvoiceId()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection =
                      new SqlConnection(Properties.Resources.ConnectionString);
            connection.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select TOP 1 InvoiceId FROm TInvoice order by InvoiceId DESC";
            
            int newProdID = (Int32)sqlCmd.ExecuteScalar();
            
            return newProdID;
        }

        public DataTable getInvoiceDetails(int id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection =
                      new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = " select tiv.InvoiceDetailId,tiv.InvoiceId,concat(i.ItemCode, '    |    ',i.ItemName) as 'Item',tiv.Qtty,tiv.Price,tiv.Amount,tiv.Observations " +
                     " from TInvoiceDetail tiv " + " join TItem i " + " on tiv.ItemId = i.ItemId " + " where tiv.InvoiceId = @InvoiceId ";

                sqlCmd.Parameters.AddWithValue("@InvoiceId", id);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                dataTable.Load(reader);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }


    }
}
