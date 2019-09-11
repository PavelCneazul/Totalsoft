using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DACountyGet
    {
        public DACountyGet()
        {
        }
        public DataTable getCounty()
        {
            DataTable tableData = new DataTable();
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            using (SqlCommand sc = new SqlCommand())
            {
                sc.Connection = conn;
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from TCounty";
                sc.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sc;

                adapter.Fill(tableData);     
            }
            return tableData;
        }
    }
}
