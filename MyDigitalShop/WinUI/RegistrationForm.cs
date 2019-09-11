using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void LblGoToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginMenu = new LoginForm();
            this.Hide();
            loginMenu.Show();
            loginMenu.FormClosed += login_FormClosed;
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        private void LblGoToLogin_MouseHover(object sender, EventArgs e)
        {
            lblGoToLogin.ForeColor = Color.Blue;
        }

        private void LblGoToLogin_MouseLeave(object sender, EventArgs e)
        {
            lblGoToLogin.ForeColor = Color.White;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(boxUserName.Text))
            {
                MessageBox.Show("Utilizatorul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Parola nu este completata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBoxPassword.Text != txtBoxPasswordConfirmation.Text)
            {
                MessageBox.Show("Parolele nu sunt identice", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool status = false;
            BLRegister bl = new BLRegister();
            UserModel user = new UserModel();
            status = bl.AddUser(boxUserName.Text, txtBoxPassword.Text);
            if(status == true )
            {
                MessageBox.Show("User-ul a fost creeat!", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Numele utilizatorului este deja folosit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegister_MouseHover(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.Red;
        }

        private void BtnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.LightSalmon; 
        }
    }
}
