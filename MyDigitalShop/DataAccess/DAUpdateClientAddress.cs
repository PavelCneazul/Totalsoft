using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAUpdateClientAddress
    {

        public DAUpdateClientAddress()
        {
        }
        public bool update(int id, int idclient,string countyname, string cityname, string streeno, string streetname)
        {
            bool status = false;
         
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
           using (SqlCommand update = new SqlCommand())
                {
                    update.Connection = conn;
                    update.CommandType = CommandType.Text;
                update.CommandText = "Update TClientAddress set CityId = (select CountyId from TCounty where CountyName = @Countyname), " +
                                        " CountyId = (select CityId from TCity where CityName = @CityName) , " +
                                        " StreetName = @Streetna, " +
                                        " StreetNo = @streetno " +
                                        " where ClientAddressId = @Id AND ClientId = @ClientId";
                    update.Parameters.AddWithValue("@CityName", countyname);
                    update.Parameters.AddWithValue("@Countyname", cityname);
                    update.Parameters.AddWithValue("@Streetna", streetname);
                    update.Parameters.AddWithValue("@streetno", streeno);
                    update.Parameters.AddWithValue("@ClientId", idclient);
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
            
            conn.Close();
            return status;
        }
    }
}
