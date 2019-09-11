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
    public class BlClientAddress
    {
        public BlClientAddress()
        {
        }

        public BindingList<ClientAddressModel> adressList(int id)
        {
            BindingList<ClientAddressModel> listAdrese = new BindingList<ClientAddressModel>();
            DataTable dt = new DataTable();
            DATotCeFolosescLaInvoice da = new DATotCeFolosescLaInvoice();
            dt = da.getClientsAddress(id);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClientAddressModel adresa = new ClientAddressModel();
                adresa.ClientAddressId = Convert.ToInt32(dt.Rows[i]["ClientAddressId"].ToString());
                adresa.Adresa = dt.Rows[i]["Adresa"].ToString();
               

                listAdrese.Add(adresa);
            }

            return listAdrese;
        }
    }
}
