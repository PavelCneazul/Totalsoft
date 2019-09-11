using BusinessLogic;
using DataAccess;
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
    public partial class InvoiceForm : Form
    {
        public int UserId;
        public int InvoiceId;
        public List<InvoiceDetailModel> lista;
        
        public InvoiceForm()
        {
            InitializeComponent();
            DATotCeFolosescLaInvoice id = new DATotCeFolosescLaInvoice();
            this.InvoiceId = id.getInvoiceId() + 1;
            
        }

        

        private void ComboBoxClient_DropDown(object sender, EventArgs e)
        {
            BLClient bLClient = new BLClient();
            BindingList<ClientModel> lista = new BindingList<ClientModel>();
            lista = bLClient.ClientList();
            var source = new BindingSource(lista, null);

            comboBoxClient.ValueMember = "ClientId";
            comboBoxClient.DisplayMember = "Fullname";
            comboBoxClient.DataSource = source;
            comboBoxClientAddress.Enabled = false;
        }

        private void ComboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedValue.ToString() != null)
            {
                BlClientAddress blClientAddress= new BlClientAddress();
                DataTable dt = new DataTable();
                int s = Convert.ToInt32(comboBoxClient.SelectedValue);
                BindingList<ClientAddressModel> lista = new BindingList<ClientAddressModel>();
                lista = blClientAddress.adressList(s);
                var source = new BindingSource(lista, null);


                comboBoxClientAddress.Enabled = true;
                comboBoxClientAddress.ValueMember = "ClientAddressId";
                comboBoxClientAddress.DisplayMember = "Adresa";
                comboBoxClientAddress.DataSource = source;

            }
        }

        private void BtnAddInvoice_Click(object sender, EventArgs e)
        {
            InvoiceId += 1;
            if(String.IsNullOrWhiteSpace(txtBoxInvoiceNumber.Text))
            {
                MessageBox.Show("Numarul facturii nu este completat!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            if (string.IsNullOrEmpty(comboBoxClient.Text))
            {
                MessageBox.Show("Nu este ales nciun partenere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxClientAddress.Text))
            {
                MessageBox.Show("Nu este ales nciun partenere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dateInvoiceDate.Text.Length ==0)
            {
                MessageBox.Show("Nu ai ales data!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DATotCeFolosescLaInvoice invoice = new DATotCeFolosescLaInvoice();
            string numarfactura = txtBoxInvoiceNumber.Text;
            DateTime dataFactura = dateInvoiceDate.Value.Date;
            int idpar = ((ClientModel)comboBoxClient.SelectedItem).ClientId;
            int idadresa = ((ClientAddressModel)comboBoxClientAddress.SelectedItem).ClientAddressId;
            string obser = txtBoxObservations.Text;


            List<InvoiceDetailModel> invoiceDetailModels = new List<InvoiceDetailModel>();
            for (int i = 0; i < dGVInvoiceDetails.RowCount; i++)
            {
                InvoiceDetailModel invoicedetail = new InvoiceDetailModel();
                invoicedetail = (InvoiceDetailModel)dGVInvoiceDetails.Rows[i].DataBoundItem;
                invoiceDetailModels.Add(invoicedetail);
            }

            bool status = invoice.insertInvoice(numarfactura, dataFactura, idpar, idadresa, UserId, obser, invoiceDetailModels);
            if(status == true)
            {
                MessageBox.Show("Factura adaugata!", "Wew", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InvoicesForm invoicesForm = new InvoicesForm();
                invoicesForm.Show();
                this.Hide();
                invoicesForm.FormClosed += invoice_from_formClosed;

            }
            else
            {
                MessageBox.Show("Factura neadaugata!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void invoice_from_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            AddInvoiceDetailForm addInvoice = new AddInvoiceDetailForm(this);
            addInvoice.Show();
            this.Hide();
            List<InvoiceDetailModel> invoiceDetailModels = new List<InvoiceDetailModel>();

            for (int i = 0; i < dGVInvoiceDetails.RowCount; i++)
            {
                InvoiceDetailModel invoicedetail = new InvoiceDetailModel();
                invoicedetail = (InvoiceDetailModel)dGVInvoiceDetails.Rows[i].DataBoundItem;
                invoiceDetailModels.Add(invoicedetail);
            }
            addInvoice.invoiceDetailModels = invoiceDetailModels;

            
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            
        }

        public void refreshGrid(List<InvoiceDetailModel> lista)
        {
            dGVInvoiceDetails.DataSource = lista;
            dGVInvoiceDetails.Columns["InvoiceDetailId"].Visible = false;
            dGVInvoiceDetails.Columns["InvoiceId"].Visible = false;
            dGVInvoiceDetails.Columns["status"].Visible = false;
            dGVInvoiceDetails.Columns["Item"].HeaderText = "Produs";
            dGVInvoiceDetails.Columns["Qtty"].HeaderText = "Qttyt";
            dGVInvoiceDetails.Columns["Price"].HeaderText = "Price";
            dGVInvoiceDetails.Columns["Amount"].HeaderText = "Amount";
            dGVInvoiceDetails.Columns["Observations"].HeaderText = "Observations";
            for(int i =0; i<dGVInvoiceDetails.Rows.Count;i++)
            {
                if(Convert.ToInt32(dGVInvoiceDetails.Rows[i].Cells[7].Value) == 3)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dGVInvoiceDetails.DataSource];
                    currencyManager1.SuspendBinding();
                    dGVInvoiceDetails.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            AddInvoiceDetailForm addInvoice = new AddInvoiceDetailForm(this);
            addInvoice.butonApasat = 1;
            addInvoice.Show();
            this.Hide();
            if(Convert.ToInt32(dGVInvoiceDetails.SelectedRows[0].Cells[7].Value) == 1)
            {
                dGVInvoiceDetails.SelectedRows[0].Cells[7].Value = 1;
            }
            else
            {
                dGVInvoiceDetails.SelectedRows[0].Cells[7].Value = 2;
            }
            
            List<InvoiceDetailModel> invoiceDetailModels = new List<InvoiceDetailModel>();
            for (int i = 0; i < dGVInvoiceDetails.RowCount; i++)
            {
                InvoiceDetailModel invoicedetail = new InvoiceDetailModel();
                invoicedetail = (InvoiceDetailModel)dGVInvoiceDetails.Rows[i].DataBoundItem;
                invoiceDetailModels.Add(invoicedetail);
            }
            addInvoice.invoiceDetailModels = invoiceDetailModels;

            addInvoice.txtBoxPrice.Text = dGVInvoiceDetails.SelectedRows[0].Cells[5].Value.ToString();
            addInvoice.txtBoxAmount.Text = dGVInvoiceDetails.SelectedRows[0].Cells[4].Value.ToString();
            addInvoice.txtBoxQtty.Text = dGVInvoiceDetails.SelectedRows[0].Cells[3].Value.ToString();
            addInvoice.txtObservations.Text = dGVInvoiceDetails.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dGVInvoiceDetails.SelectedRows[0].Cells[7].Value) == 1)
            {
                dGVInvoiceDetails.SelectedRows[0].Cells[7].Value = 4;
            }
            if (Convert.ToInt32(dGVInvoiceDetails.SelectedRows[0].Cells[7].Value) == 2)
            {
                dGVInvoiceDetails.SelectedRows[0].Cells[7].Value = 3;
            }
            else
            {
                dGVInvoiceDetails.SelectedRows[0].Cells[7].Value = 3;
            }
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dGVInvoiceDetails.DataSource];
            currencyManager1.SuspendBinding();
            dGVInvoiceDetails.SelectedRows[0].Visible = false;
            currencyManager1.ResumeBinding();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dGVInvoiceDetails.DataSource = lista;
        }
    }
}
