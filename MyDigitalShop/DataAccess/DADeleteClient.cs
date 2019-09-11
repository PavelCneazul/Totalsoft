using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DADeleteClient
    {
        public DADeleteClient()
        {
        }

        public bool deleteClient(List<int> id)
        {
            bool status = false;
            bool itletmedelete = false;
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            for (int i = 0; i < id.Count; i++)
            {
                using (SqlCommand validate = new SqlCommand())
                {
                    {
                        validate.Connection = conn;
                        validate.CommandType = CommandType.Text;
                        validate.CommandText = " Select Count(*) from TInvoice where ClientId = @Id";
                        validate.Parameters.AddWithValue("@Id", id[i]);
                        int newProdID = (Int32)validate.ExecuteScalar();
                        if (newProdID != 0)
                        {
                            itletmedelete = true;
                        }
                        else itletmedelete = false;
                    }
                }
                if (itletmedelete == false)
                {
                    using (SqlCommand delete = new SqlCommand())
                    {
                        delete.Connection = conn;
                        delete.CommandType = System.Data.CommandType.Text;
                        delete.CommandText = " delete ca " +
                                                " from TClientAddress ca " +
                                                " join TClient c on c.ClientId = ca.ClientId " +
                                                " where c.ClientId = @Id " +
                                                " delete from TClient where ClientId = @Id ";
                        delete.Parameters.AddWithValue("@Id", id[i]);
                        int a = delete.ExecuteNonQuery();
                        if (a == 1)
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
            conn.Close();
            return status;
        }
    }
}
