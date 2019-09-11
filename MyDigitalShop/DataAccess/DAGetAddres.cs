using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAGetAddres
    {
        public DAGetAddres()
        {
        }

        public DataTable GetAddress(int id)
        {
            DataTable tableData = new DataTable();

            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
            using (SqlCommand getAddress = new SqlCommand())
            {
                getAddress.Connection = conn;
                getAddress.CommandType = CommandType.Text;
                getAddress.CommandText = "SELECT ca.ClientAddressId,c.CityName, co.CountyName, ca.StreetName, ca.StreetNo FROM TClientAddress ca  " +
                    " JOIN TCity c ON c.CityId = ca.CountyId " +
                   " JOIN TCounty co ON co.CountyId = ca.CityId " +
                    " WHERE ClientId = @Id ";
                getAddress.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = getAddress.ExecuteReader();
                tableData.Load(reader);

                return tableData;
            }

           
        }
    }
}
