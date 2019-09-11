using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAGetClient
    {
        public DAGetClient()
        {
        }

        public DataTable getClient(int id)
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText =
                "SELECT * from TClient where ClientId = @id";
            sqlCmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            dataTable.Load(reader);
            conn.Close();
            return dataTable;
        }
    }
}
