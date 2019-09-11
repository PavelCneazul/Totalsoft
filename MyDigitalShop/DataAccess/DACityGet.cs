using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class DACityGet
    {
        public DACityGet()
        {
        }

        public DataTable getCity(int id)
        {
            bool status = false;
            DataTable tableData = new DataTable();
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            using (SqlCommand sc = new SqlCommand())
            {
                sc.Connection = conn;
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from TCity co " +
                    " join TCounty c on c.CountyId = co.CountyId " +
                    " where c.CountyId = @Countyid";
                sc.Parameters.AddWithValue("@Countyid", id);
                int a = sc.ExecuteNonQuery();
                if(a == 1 )
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
    }
}
