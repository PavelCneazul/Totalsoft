using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DADeleteAddress
    {
        public DADeleteAddress()
        {
        }

        public bool deleteAdresa(int id)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            using (SqlCommand delete = new SqlCommand())
            {
                delete.Connection = conn;
                delete.CommandType = System.Data.CommandType.Text;
                delete.CommandText = " delete ca " +
                                        " from TClientAddress ca " +
                                        " where ca.ClientAddressId = @Id ";
                delete.Parameters.AddWithValue("@Id", id);
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
            return status;
        }
    }
}
