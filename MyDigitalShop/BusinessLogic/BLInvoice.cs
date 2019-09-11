using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLInvoice
    {
        public BLInvoice()
        {
        }
        public List<InvoiceModel> getallinvoices(string invoicenumber, DateTime invoicedateStartFrom, DateTime invoicedateEndto, string clientid,
            bool checkstart, bool checkend)
        {
            List<InvoiceModel> invoiceList = new List<InvoiceModel>();
            DataTable dt = new DataTable();
            DATotCeFolosescLaInvoice invoice = new DATotCeFolosescLaInvoice();
            dt = invoice.getInvoices(invoicenumber, invoicedateStartFrom, invoicedateEndto, clientid, checkstart, checkend);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                InvoiceModel invoicemode = new InvoiceModel();
                invoicemode.InvoiceId = Convert.ToInt32(dt.Rows[i]["InvoiceId"].ToString());
                invoicemode.ClientAddressId = Convert.ToInt32(dt.Rows[i]["ClientAddressId"].ToString());
                invoicemode.ClientId = Convert.ToInt32(dt.Rows[i]["ClientId"].ToString());
                invoicemode.InvoiceNumber = dt.Rows[i]["InvoiceNumber"].ToString();
                invoicemode.InvoiceDate = Convert.ToDateTime(dt.Rows[i]["InvoiceDate"].ToString());
                invoicemode.ClientName = dt.Rows[i]["ClientName"].ToString();
                invoicemode.ClientSurname = dt.Rows[i]["ClientSurname"].ToString();
                invoicemode.Address = dt.Rows[i]["Adresa"].ToString();
                invoicemode.Obesrvations = dt.Rows[i]["Observations"].ToString();

                invoiceList.Add(invoicemode);
            }
            return invoiceList;

        }

        public List<ItemModel> getItems()
        {
            List<ItemModel> itemList = new List<ItemModel>();
            DataTable dt = new DataTable();
            DATotCeFolosescLaInvoice item = new DATotCeFolosescLaInvoice();
            dt = item.getItems();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ItemModel itemModel = new ItemModel();
                itemModel.ItemId = Convert.ToInt32(dt.Rows[i]["ItemId"].ToString());
                itemModel.ItemName = dt.Rows[i]["Item"].ToString();
                itemList.Add(itemModel);
            }
            return itemList;
        }

      
    }
}
