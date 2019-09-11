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
    public class BLClient
    {
        public BLClient()
        {
        }
        public BindingList<ClientModel> ClientList()
        {
            BindingList<ClientModel> listaClienti = new BindingList<ClientModel>();
            DataTable dt = new DataTable();
            DATotCeFolosescLaInvoice da = new DATotCeFolosescLaInvoice();
            dt = da.getClients();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClientModel client = new ClientModel();
                client.ClientId = Convert.ToInt32(dt.Rows[i]["ClientId"].ToString());
                client.ClientName = dt.Rows[i]["ClientName"].ToString();
                client.ClientSurname = dt.Rows[i]["ClientSurname"].ToString();
                client.CodeClient = dt.Rows[i]["ClientCode"].ToString();
                client.Fullname = dt.Rows[i]["FullName"].ToString();
                listaClienti.Add(client);
            }

            return listaClienti;
        }
    }
}
