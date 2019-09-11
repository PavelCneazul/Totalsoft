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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }



        private void BtnShowClients_Click(object sender, EventArgs e)
        {
            DAClientList clients = new DAClientList();
            dataGridClients.DataSource = clients.getClientsList(txtBoxNameFilter.Text, txtBoxFilterSurname.Text, txtBoxFilterCode.Text);
            dataGridClients.Columns["ClientId"].Visible = false;
            dataGridClients.Columns["ClientName"].HeaderText = "Nume Client";
            dataGridClients.Columns["ClientSurname"].HeaderText = "Prenume Client";
            dataGridClients.Columns["PhoneNo"].HeaderText = "Numar de telefon";
            dataGridClients.Columns["Email"].HeaderText = "Email";

             foreach (DataGridViewRow item in dataGridClients.Rows)
            {
                item.Cells[0].Value = false;
            }

            //DataGridViewCheckBoxColumn boxColumn = new DataGridViewCheckBoxColumn();
            //boxColumn.ValueType = typeof(bool);
            //boxColumn.Name = "Ok";
            //boxColumn.HeaderText = "Selecteaza";
            //dataGridClients.Columns.Add(boxColumn);

        }



        private void DataGridClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //UserModel user = (UserModel)dataGridClients.SelectedRows[0].DataBoundItem;
            ClientForm clientDetail = new ClientForm();

            clientDetail.Show();
            this.Hide();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridClients.Rows[index];
            clientDetail.lblIdInvisible.Text =selectedRow.Cells[1].Value.ToString();
            clientDetail.lblIdInvisible.Visible = false;
            clientDetail.txtBoxClientName.Text = selectedRow.Cells[2].Value.ToString();
            clientDetail.txtBoxSurName.Text = selectedRow.Cells[3].Value.ToString();
            clientDetail.txtBoxClientCode.Text = selectedRow.Cells[4].Value.ToString();
            clientDetail.txtBoxPhoneNo.Text = selectedRow.Cells[5].Value.ToString();
            clientDetail.txtBoxEmail.Text = selectedRow.Cells[6].Value.ToString();

            DAGetAddres addres = new DAGetAddres();
            clientDetail.dataGridViewClientAddress.DataSource = addres.GetAddress(Convert.ToInt32(selectedRow.Cells[1].Value));
            clientDetail.dataGridViewClientAddress.Columns["ClientAddressId"].Visible = false;
            clientDetail.dataGridViewClientAddress.Columns["CityName"].HeaderText = "Nume Oras";
            clientDetail.dataGridViewClientAddress.Columns["CountyName"].HeaderText = "Nume Regiune";
            clientDetail.dataGridViewClientAddress.Columns["StreetName"].HeaderText = "Nume Strada";
            clientDetail.dataGridViewClientAddress.Columns["StreetNo"].HeaderText = "Numar Strada";

            clientDetail.FormClosed += ClientDetail_Form_Closed;

        }

        private void ClientDetail_Form_Closed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DADeleteClient delete = new DADeleteClient();
            List<int> integers = new List<int>();
            bool status = false;
           
                foreach (DataGridViewRow item in dataGridClients.Rows)
            {
                
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    integers.Add(Convert.ToInt32(item.Cells[1].Value));
                }
                //dataGridClients.Rows.RemoveAt(dataGridClients.SelectedRows[0].Index);
            }
            status = delete.deleteClient(integers);
            
            if (status == false)
            {
                MessageBox.Show("Unul din clineti detine factura", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                MessageBox.Show("Stergere blana!", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DAClientList clients = new DAClientList();
                dataGridClients.DataSource = clients.getClientsList(txtBoxNameFilter.Text, txtBoxFilterSurname.Text, txtBoxFilterCode.Text);
                dataGridClients.Columns["ClientId"].Visible = false;
                dataGridClients.Columns["ClientName"].HeaderText = "Nume Client";
                dataGridClients.Columns["ClientSurname"].HeaderText = "Prenume Client";
                dataGridClients.Columns["PhoneNo"].HeaderText = "Numar de telefon";
                dataGridClients.Columns["Email"].HeaderText = "Email";

                foreach (DataGridViewRow item in dataGridClients.Rows)
                {
                    item.Cells[0].Value = false;
                }
                dataGridClients.Refresh();
            }
            
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.Show();
            this.Hide();
            addClientForm.FormClosed += addClientForm_formclosed;
        }

        private void addClientForm_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnBackToMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm meniu = new MainMenuForm();
            this.Hide();
            meniu.Show();

        }

        private void DataGridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridClients_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Select"].Value = false;
        }
    }
}
