using DataAccess;
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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(boxAddNume.Text))
            {
                MessageBox.Show("Numele clientului nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(boxAddSurName.Text))
            {
                MessageBox.Show("Prenumele clientului nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(boxAddClientCode.Text))
            {
                MessageBox.Show("Codul clientului nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool status = false;
            DAAddClient addclinet = new DAAddClient();
            status = addclinet.addClient(boxAddNume.Text, boxAddSurName.Text, boxAddClientCode.Text, boxAddphoneno.Text,boxAddEmail.Text);
            if (status == true)
            {
                MessageBox.Show("Client adaugat", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Codul clientului deja existent!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }

        private void lista_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnBackToList_Click(object sender, EventArgs e)
        {
            ClientsForm listaClienti = new ClientsForm();
            this.Hide();
            listaClienti.Show();
        }
    }
}
