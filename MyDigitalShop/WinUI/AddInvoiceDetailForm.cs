using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class AddInvoiceDetailForm : Form
    {
        public List<InvoiceDetailModel> invoiceDetailModels;
        public int butonApasat = 0;
        public InvoiceForm invoiceform = new InvoiceForm();
        public AddInvoiceDetailForm(InvoiceForm invoiceForma)
        {
            this.invoiceform = invoiceForma;
            InitializeComponent();
            
        }

        private void ComboBoxItem_DropDown(object sender, EventArgs e)
        {
            BLInvoice blItem = new BLInvoice();
            List<ItemModel> lista = new List<ItemModel>();
            lista = blItem.getItems();
            var source = new BindingSource(lista, null);
            comboBoxItem.ValueMember = "ClientId";
            comboBoxItem.DisplayMember = "Fullname";
            comboBoxItem.DataSource = source;

        }

        private void BtnAddInvoiceDetail_Click(object sender, EventArgs e)
        {
            if (butonApasat != 1)
            {
                
                invoiceform.Show();

                List<InvoiceDetailModel> invoicedetail = new List<InvoiceDetailModel>();
                InvoiceDetailModel invoicedetailModel = new InvoiceDetailModel();
                invoicedetail = invoiceDetailModels;

                invoicedetailModel.InvoiceDetailId = 0;
                invoicedetailModel.InvoiceId = invoiceform.InvoiceId;
                invoicedetailModel.Item = new ItemModel
                {
                    ItemName = comboBoxItem.SelectedItem.ToString(),
                    ItemId = Convert.ToInt32(comboBoxItem.SelectedIndex.ToString())
                };
                invoicedetailModel.Qtty = Convert.ToDecimal(txtBoxQtty.Text);
                invoicedetailModel.Price = Convert.ToDecimal(txtBoxPrice.Text);
                invoicedetailModel.Amount = Convert.ToDecimal(txtBoxAmount.Text);
                invoicedetailModel.Observations = txtObservations.Text.ToString();
                invoicedetailModel.status = 1;
                invoicedetail.Add(invoicedetailModel);
                invoiceform.refreshGrid(invoicedetail);

                butonApasat = 0;
                this.Close();
            }
            else
            {
                
                invoiceform.Show();

                List<InvoiceDetailModel> invoicedetail = new List<InvoiceDetailModel>();
                InvoiceDetailModel invoicedetailModel = new InvoiceDetailModel();
                invoicedetail = invoiceDetailModels;
                for (int i = 0; i < invoicedetail.Count; i++)
                {
                    if (invoicedetail[i].status == 2)
                    {
                        invoicedetailModel.InvoiceDetailId = 0;
                        invoicedetailModel.InvoiceId = invoiceform.InvoiceId;
                        invoicedetailModel.Item = new ItemModel
                        {
                            ItemName = comboBoxItem.SelectedItem.ToString(),
                            ItemId = Convert.ToInt32(comboBoxItem.SelectedIndex.ToString())
                        };
                        invoicedetailModel.Qtty = Convert.ToDecimal(txtBoxQtty.Text);
                        invoicedetailModel.Price = Convert.ToDecimal(txtBoxPrice.Text);
                        invoicedetailModel.Amount = Convert.ToDecimal(txtBoxAmount.Text);
                        invoicedetailModel.Observations = txtObservations.Text.ToString();
                        invoicedetailModel.status = 2;

                        invoicedetail[i] = invoicedetailModel;
                        invoiceform.refreshGrid(invoicedetail);
                        butonApasat = 0;
                        this.Close();
                    }
                }
            }
        }
    }
}
