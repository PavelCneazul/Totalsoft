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
    public partial class ClientForm : Form
    {
        UserModel user;
        
        public int IdClient { set; get; }
        public bool TextWasChanged = false;
        public ClientForm()//UserModel user)
        {
            
            //this.user = user;
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ClientsForm clientslist = new ClientsForm();
            clientslist.Show();
            this.Hide();
        }

        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            int ok = 0;
            if (TextWasChanged)
            {
                ok = 1;
            }
            bool status = false;
            int id = Convert.ToInt32(lblIdInvisible.Text);
            DAUpdateClient dAUpdateClient = new DAUpdateClient();
            status = dAUpdateClient.update(ok,txtBoxClientName.Text, txtBoxSurName.Text, txtBoxClientCode.Text, txtBoxPhoneNo.Text, txtBoxEmail.Text, id );
            if (status == true)
            {
                MessageBox.Show("Clientul a fost modificat", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClientsForm clients = new ClientsForm();
                clients.Show();
                this.Hide();
                clients.FormClosed += FormClosed_ListClients;
            }
            else
            {
                MessageBox.Show("Codul clientului este deja existent!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void FormClosed_ListClients(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void TxtBoxPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxPhoneNo.Text, "  ^ [0-9]"))
            {
                txtBoxPhoneNo.Text = "";
            }
        }

        private void DataGridViewClientAddress_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientAddressForm clientAddressForm = new ClientAddressForm();
            int index = e.RowIndex;

            DataGridViewRow selectedRow = dataGridViewClientAddress.Rows[index];
            clientAddressForm.IdAdresa = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            clientAddressForm.IdClient1 = Convert.ToInt32(lblIdInvisible.Text);
            clientAddressForm.comboBoxUpdateCounty.SelectedItem = selectedRow.Cells[1].Value.ToString();
            clientAddressForm.comboBoxUpdateCity.SelectedItem = selectedRow.Cells[2].Value.ToString();
            clientAddressForm.txtBoxUpdateStreetName.Text = selectedRow.Cells[3].Value.ToString();
            clientAddressForm.textBoxStreetNo.Text = selectedRow.Cells[4].Value.ToString();
            this.Hide();
            clientAddressForm.Show();
            clientAddressForm.FormClosed += clientAddressForm_FormClose;
        }

        private void clientAddressForm_FormClose(object sender, FormClosedEventArgs e)
        {
           this.Close();
        }

        private void BtnAddAddress_Click(object sender, EventArgs e)
        {
            AddAddressForm addAddressForm = new AddAddressForm();
            addAddressForm.IdClient = Convert.ToInt32(lblIdInvisible.Text);
            this.Hide();
            addAddressForm.Show();
            addAddressForm.FormClosed += addAddressForm_formClosed;
        }

        private void addAddressForm_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnDeleteAddress_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewClientAddress.SelectedRows)
            {
                DADeleteAddress delete = new DADeleteAddress();
                int id = Convert.ToInt32(dataGridViewClientAddress.SelectedRows[0].Cells[0].Value);

                bool status = false;
                status = delete.deleteAdresa(id);
                if (status == false)
                {
                    MessageBox.Show("Adresa nu poate fi stearsa caci are prea mult praf!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Adresa curatata de pe fata bazei de date!", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridViewClientAddress.Rows.RemoveAt(dataGridViewClientAddress.SelectedRows[0].Index);

                dataGridViewClientAddress.Refresh();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            txtBoxClientCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextWasChanged = true;
        }
    }
}
