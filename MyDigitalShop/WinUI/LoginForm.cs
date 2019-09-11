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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtUserName.Text))
                {
                MessageBox.Show("Utilizatorul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            if(String.IsNullOrWhiteSpace(txtPassword.Text))
                {
                MessageBox.Show("Parola nu este completata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   

            BLLogin bl = new BLLogin();
            UserModel user = bl.CheckUser(txtUserName.Text, txtPassword.Text, out bool status);
            if (status)
            {
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.UserId = user.UserId;
                mainMenu.Show();
                this.Hide();
                mainMenu.FormClosed += MainMenu_FormClosed;
            }
            else
                MessageBox.Show("Utilizator sau parola incorecta", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LblGoToRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationMenu = new RegistrationForm();
            registrationMenu.Show();
            this.Hide();
            registrationMenu.FormClosed += Registration_FormClosed;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        private void LblGoToRegister_MouseHover(object sender, EventArgs e)
        {
            lblGoToRegister.ForeColor = Color.Blue;
            
        }

        private void LblGoToRegister_MouseLeave(object sender, EventArgs e)
        {
            lblGoToRegister.ForeColor = Color.Black;
          
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
