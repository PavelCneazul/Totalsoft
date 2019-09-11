using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess
{
    public class DARegister
    {
        public DARegister()
        {
        }

        public bool AddUser(string userName, string password)
        {
            bool status = false;
            bool letmeadd = false;
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            using (SqlCommand validate =  new SqlCommand())
            {             
                validate.Connection = conn;
                validate.CommandType = CommandType.Text;
                validate.CommandText = "SELECT COUNT(*) from TERPUser where UserName = @nume";
                validate.Parameters.AddWithValue("@nume", userName);
                int newProdID = (Int32)validate.ExecuteScalar(); ;
                if (newProdID == 1)
                {
                    letmeadd = true;
                }
                else
                {
                    letmeadd = false;
                }
            }
            if (letmeadd == false)
            {
                using (SqlCommand insert = new SqlCommand())
                {
                    insert.Connection = conn;
                    insert.CommandType = CommandType.Text;
                    insert.CommandText = "declare @UserId int " +
                                            " exec GetNextId 0, 'TERPUser', @UserId out, 0,1 " +
                                            "insert into TERPUser " +
                                            "(UserId, UserName, UserPassword, LastLogin) " +
                                            " select @UserId, @Username, @Password, GETDATE() ";
                    insert.Parameters.AddWithValue("@Username", userName);
                    insert.Parameters.AddWithValue("@Password", password);
                    int a = insert.ExecuteNonQuery();
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
            conn.Close();
        return status;
        }
    }
}
