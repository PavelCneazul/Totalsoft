using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAAddAddress
    {
        public DAAddAddress()
        {
        }

        public bool addaddress(int id, string oras, string regiune, string strada, string numar)
        {
            bool status = false;
            
            SqlConnection conn = new SqlConnection(Properties.Resources.ConnectionString);
            conn.Open();
                using (SqlCommand add = new SqlCommand())
                {
                    add.Connection = conn;
                    add.CommandType = CommandType.Text;
                    add.CommandText = "declare @ClientAddressId int " +
                                      " exec GetNextId 0, 'TClientAddress', @ClientAddressId out, 0,1 " +
                                      "insert into TClientAddress " +
                                      " (ClientAddressId, ClientId,CityId,CountyId,StreetName,StreetNo) " +
                                      " select @ClientAddressId, @ClientId, (select CountyId from TCounty where CountyName = @Countyname)," +
                                      "(select CityId from TCity where CityName = @CityName), @StreetName, @StreetNo ";
                    add.Parameters.AddWithValue("@ClientId", id);
                    add.Parameters.AddWithValue("@Countyname", regiune);
                    add.Parameters.AddWithValue("@CityName", oras);
                    add.Parameters.AddWithValue("@StreetName", strada);
                    add.Parameters.AddWithValue("@StreetNo", numar);

                    if (add.ExecuteNonQuery() == 1)
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
