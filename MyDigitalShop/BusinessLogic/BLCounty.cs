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
    public class BLCounty
    {
        public BLCounty()
        {
        }
        public BindingList<CountyModel> CountyList()
        {

            BindingList<CountyModel> listaCounties = new BindingList<CountyModel>();
            DataTable dt = new DataTable();
            DACountyGet da = new DACountyGet();
            dt = da.getCounty();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CountyModel county = new CountyModel();

                county.CountyId = Convert.ToInt32(dt.Rows[i]["CountyId"].ToString());
                county.CountyName = dt.Rows[i]["CountyName"].ToString();
                
                listaCounties.Add(county);
            }
            return listaCounties;
        }
    }
}
