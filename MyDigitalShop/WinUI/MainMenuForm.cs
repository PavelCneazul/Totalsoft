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
    public partial class MainMenuForm : Form
    {
        public int UserId;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {

            ClientsForm clientsMenu = new ClientsForm();
            clientsMenu.Show();
            this.Hide();
            clientsMenu.FormClosed += FormClosed;
        }

        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            InvoicesForm invoicesMenu = new InvoicesForm();
            invoicesMenu.UserIdForInvoice = UserId;
            invoicesMenu.Show();
            this.Hide();
            invoicesMenu.FormClosed += FormClosed;
        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            ItemsForm itemsMenu = new ItemsForm();
            itemsMenu.Show();
            this.Hide();
            itemsMenu.FormClosed += FormClosed;
        }
    }
}
