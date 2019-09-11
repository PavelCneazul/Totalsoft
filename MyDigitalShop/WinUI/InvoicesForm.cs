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
    
    public partial class InvoicesForm : Form
    {

        public int UserIdForInvoice;
        public InvoicesForm()
        {
            InitializeComponent();
        }

   

        private void BtnAddInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm invoice  =new InvoiceForm();
            invoice.UserId = UserIdForInvoice;
            invoice.Show();
            this.Hide();
            invoice.FormClosed += formclosed_invoice;


        }

        private void formclosed_invoice(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

       

        private void CheckBoxEndTo_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBoxEndTo.Checked)
                dTPEndAt.Enabled = true;
            else
                dTPEndAt.Enabled = false;

        }

        private void CheckBoxStartedAt_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxStartedAt.Checked)
                dTPStartFrom.Enabled = true;
            else
                dTPStartFrom.Enabled = false;
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            dTPEndAt.Enabled = false;
            dTPStartFrom.Enabled = false;
        }

        private void Btn_printInvoices_Click(object sender, EventArgs e)
        {
            string clientname12 = "";
            BLInvoice blinvoice = new BLInvoice();
            DataTable dt = new DataTable();
            List<InvoiceModel> lista = new List<InvoiceModel>();
            if (cmbBoxClient.SelectedValue == null)
            {
                clientname12 = "";
            }
            else
            {
                clientname12 = cmbBoxClient.SelectedItem.ToString();
            }

            lista = blinvoice.getallinvoices(txtBoxFilterInvoiceNumber.Text, dTPStartFrom.Value.Date, dTPEndAt.Value.Date,
                clientname12, checkBoxStartedAt.Checked, checkBoxEndTo.Checked);
            var source = new BindingSource(lista, null);
            dGVInvoices.DataSource = source;

            dGVInvoices.Columns["InvoiceId"].Visible = false;
            dGVInvoices.Columns["ClientAddressId"].Visible = false;
            dGVInvoices.Columns["ClientId"].Visible = false;
            dGVInvoices.Columns["InvoiceNumber"].HeaderText = "Numar factura";
            dGVInvoices.Columns["InvoiceDate"].HeaderText = "Data factura";
            dGVInvoices.Columns["ClientName"].HeaderText = "Nume Client";
            dGVInvoices.Columns["ClientSurname"].HeaderText = "Prenume Client";
            dGVInvoices.Columns["Address"].HeaderText = "Adresa";
            dGVInvoices.Columns["Obesrvations"].HeaderText = "Observatii";

        }

        private void CmbBoxClient_DropDown(object sender, EventArgs e)
        {
            BLClient bLClient = new BLClient();
            BindingList<ClientModel> lista = new BindingList<ClientModel>();
            lista = bLClient.ClientList();
            var source = new BindingSource(lista, null);

            cmbBoxClient.ValueMember = "ClientId";
            cmbBoxClient.DisplayMember = "Fullname";
            cmbBoxClient.DataSource = source;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainMenuForm main = new MainMenuForm();
            this.Hide();
            main.Show();
        }

        private void DGVInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.Show();
            this.Hide();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dGVInvoices.Rows[index];
            invoiceForm.UserId = Convert.ToInt32(selectedRow.Cells[1].Value);
            invoiceForm.txtBoxInvoiceNumber.Text = selectedRow.Cells[1].Value.ToString();
            invoiceForm.txtBoxObservations.Text = selectedRow.Cells[6].Value.ToString();
            invoiceForm.comboBoxClient.SelectedItem = selectedRow.Cells[3].Value.ToString();
            invoiceForm.comboBoxClientAddress.Text = selectedRow.Cells[4].Value.ToString();
            invoiceForm.dateInvoiceDate.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);

            DATotCeFolosescLaInvoice detalii = new DATotCeFolosescLaInvoice();
            DataTable dt = new DataTable();
            dt = detalii.getInvoiceDetails(Convert.ToInt32(selectedRow.Cells[0].Value));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                InvoiceDetailModel invoicemode = new InvoiceDetailModel();
                invoicemode.InvoiceId = Convert.ToInt32(dt.Rows[i]["InvoiceId"].ToString());
                invoicemode.InvoiceDetailId = Convert.ToInt32(dt.Rows[i]["InvoiceDetailId"].ToString());
                invoicemode.Item = new ItemModel
                {
                    ItemName = dt.Rows[i]["Item"].ToString()
                };
                invoicemode.Qtty = Convert.ToDecimal(dt.Rows[i]["Qtty"].ToString());
                invoicemode.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                invoicemode.Amount = Convert.ToDecimal(dt.Rows[i]["Amount"].ToString());
                invoicemode.Observations = dt.Rows[i]["Observations"].ToString();

                //invoiceForm.lista.Add(invoicemode);
            }
            
            invoiceForm.dGVInvoiceDetails.DataSource = detalii.getInvoiceDetails(Convert.ToInt32(selectedRow.Cells[0].Value));
            invoiceForm.dGVInvoiceDetails.Columns["InvoiceDetailId"].Visible = false;
            invoiceForm.dGVInvoiceDetails.Columns["InvoiceId"].Visible = false;
            invoiceForm.dGVInvoiceDetails.Columns["Item"].HeaderText = "Item";
            invoiceForm.dGVInvoiceDetails.Columns["Qtty"].HeaderText = "Cantitate";
            invoiceForm.dGVInvoiceDetails.Columns["Price"].HeaderText = "Pret";
            invoiceForm.dGVInvoiceDetails.Columns["Amount"].HeaderText = "Amount";
            invoiceForm.dGVInvoiceDetails.Columns["Observations"].HeaderText = "Observatii";

            invoiceForm.FormClosed += ClientDetail_Form_Closed;
        }

        private void ClientDetail_Form_Closed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

      
    }
}
