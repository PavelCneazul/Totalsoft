using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAAddClient
    {
        public DAAddClient()
        {
        }

        public bool addClient(string nume, string prenume, string codclient, string nr, string email)
        {
            bool status = false;
            bool itletmeadd = false;
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            using(SqlCommand verifica = new SqlCommand())
            {
                verifica.Connection = conn;
                verifica.CommandType = CommandType.Text;
                verifica.CommandText = "Select COUNT(*) from TClient where ClientCode = @ClientCode";
                verifica.Parameters.AddWithValue("@ClientCode", codclient);
                int newProdID = (Int32)verifica.ExecuteScalar(); 
                if (newProdID == 1)
                {
                    itletmeadd = true;
                }
                else
                {
                    itletmeadd = false;
                }
            }
            if(itletmeadd == false)
            {
                using (SqlCommand add = new SqlCommand())
                {
                    add.Connection = conn;
                    add.CommandType = CommandType.Text;
                    add.CommandText = "declare @ClientId int " +
                                            " exec GetNextId 0, 'TClient', @ClientId out, 0,1 " +
                                            "insert into TClient " +
                                            " (ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email) " +
                                            " select @ClientId, @ClientName, @SurName, @ClientCode, @PhoneNo, @Email ";
                    add.Parameters.AddWithValue("@ClientName", nume);
                    add.Parameters.AddWithValue("@SurName", prenume);
                    add.Parameters.AddWithValue("@ClientCode", codclient);
                    add.Parameters.AddWithValue("@PhoneNo", nr);
                    add.Parameters.AddWithValue("@Email", email);

                    if (add.ExecuteNonQuery() == 1)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                }
            }
            conn.Close();
            return status;
        }
    }
}
