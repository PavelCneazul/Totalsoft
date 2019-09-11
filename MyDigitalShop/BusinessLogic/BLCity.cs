using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLCity
    {
        public BLCity()
        {
        }

        public BindingList<CityModel> CityList(int id)
        {
            BindingList<CityModel> listOrase = new BindingList<CityModel>();
            DataTable dt = new DataTable();
            DACityGet da = new DACityGet();
            dt = da.getCity(id);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CityModel city = new CityModel();
                city.CityId = Convert.ToInt32(dt.Rows[i]["CityId"].ToString());
                city.CityName = dt.Rows[i]["CityName"].ToString();
                city.County = new CountyModel
                {
                    CountyId = Convert.ToInt32(dt.Rows[i]["CountyId"].ToString()),
                    CountyName = dt.Rows[i]["CountyName"].ToString()
                };

                listOrase.Add(city);
            }

            return listOrase;
        }
    }
}
