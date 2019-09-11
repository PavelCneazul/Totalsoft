using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAUpdateClient
    {
        public DAUpdateClient()
        {
        }

        public bool update(int ok,string clientName, string surName, string clientCode, string phoneNo, string email, int id)
        {
            bool status = false;
            bool itletmemodify = false;
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            if (ok == 1)
            {
                using (SqlCommand update = new SqlCommand())
                {
                    update.Connection = conn;
                    update.CommandType = CommandType.Text;
                    update.CommandText = "Update TClient set ClientName = @ClientName, ClientCode = @ClientCode, " +
                                            " ClientSurname = @SurName , " +
                                            " PhoneNo = @PhoneNo, " +
                                            " Email = @Email " +
                                            " where ClientId = @Id";
                    update.Parameters.AddWithValue("@ClientName", clientName);
                    update.Parameters.AddWithValue("@SurName", surName);
                    update.Parameters.AddWithValue("@ClientCode", clientCode);
                    update.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    update.Parameters.AddWithValue("@Email", email);
                    update.Parameters.AddWithValue("@Id", id);
                    if (update.ExecuteNonQuery() == 1)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                }
            }
            else
            {
                using (SqlCommand update = new SqlCommand())
                {
                    update.Connection = conn;
                    update.CommandType = CommandType.Text;
                    update.CommandText = "Update TClient set ClientName = @ClientName, " +
                                            " ClientSurname = @SurName , " +
                                            " PhoneNo = @PhoneNo, " +
                                            " Email = @Email " +
                                            " where ClientId = @Id";
                    update.Parameters.AddWithValue("@ClientName", clientName);
                    update.Parameters.AddWithValue("@SurName", surName);
                    update.Parameters.AddWithValue("@ClientCode", clientCode);
                    update.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    update.Parameters.AddWithValue("@Email", email);
                    update.Parameters.AddWithValue("@Id", id);
                    if (update.ExecuteNonQuery() == 1)
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
