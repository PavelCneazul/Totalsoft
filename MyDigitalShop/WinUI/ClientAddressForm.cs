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
    public partial class ClientAddressForm : Form
    {
        public int IdAdresa;
        public int IdClient1;
        public ClientAddressForm()
        {
            InitializeComponent();
        }

        private void ClientAddressForm_Load(object sender, EventArgs e)
        {
        }

        private void ComboBoxUpdateCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdateCounty.SelectedValue.ToString() != null)
            {
                BLCity blCity = new BLCity();
                DataTable dt = new DataTable();
                int s = Convert.ToInt32(comboBoxUpdateCounty.SelectedValue);
                BindingList<CityModel> lista = new BindingList<CityModel>();
                lista = blCity.CityList(s);
                var source = new BindingSource(lista, null);


                comboBoxUpdateCity.Enabled = true;
                comboBoxUpdateCity.ValueMember = "CityId";
                comboBoxUpdateCity.DisplayMember = "CityName";
                comboBoxUpdateCity.DataSource = source;

            }
        }

        private void ComboBoxUpdateCounty_DropDown(object sender, EventArgs e)
        {
           
            BLCounty bLCounty = new BLCounty();
            BindingList<CountyModel> lista = new BindingList<CountyModel>();
            lista = bLCounty.CountyList();
            var source = new BindingSource(lista, null);

            comboBoxUpdateCounty.ValueMember = "CountyId";
            comboBoxUpdateCounty.DisplayMember = "CountyName";
            comboBoxUpdateCounty.DataSource = source;
            comboBoxUpdateCity.Enabled = false;
        }

        private void BtnModificaAdresa_Click(object sender, EventArgs e)
        {
            bool status = false;
            DAUpdateClientAddress dAAdd = new DAUpdateClientAddress();
            status = dAAdd.update(IdAdresa, IdClient1, comboBoxUpdateCity.SelectedItem.ToString(), comboBoxUpdateCounty.SelectedItem.ToString(), textBoxStreetNo.Text,txtBoxUpdateStreetName.Text);
            if (status == true)
            {
                MessageBox.Show("Adresa a fost modificata!", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClientForm clientForm = new ClientForm();
                this.Hide();
                clientForm.Show();

                DAGetClient dAGetClient = new DAGetClient();
                DataTable dataTable = new DataTable();
                dataTable = dAGetClient.getClient(IdClient1);
                clientForm.txtBoxClientName.Text = dataTable.Rows[0]["ClientName"].ToString();
                clientForm.lblIdInvisible.Text = IdClient1.ToString();
                clientForm.lblIdInvisible.Visible = false;
                clientForm.txtBoxSurName.Text = dataTable.Rows[0]["ClientSurName"].ToString();
                clientForm.txtBoxPhoneNo.Text = dataTable.Rows[0]["PhoneNo"].ToString();
                clientForm.txtBoxClientCode.Text = dataTable.Rows[0]["ClientCode"].ToString();
                clientForm.txtBoxEmail.Text = dataTable.Rows[0]["Email"].ToString();

                DAGetAddres addres = new DAGetAddres();
                clientForm.dataGridViewClientAddress.DataSource = addres.GetAddress(IdClient1);
                clientForm.dataGridViewClientAddress.Columns["ClientAddressId"].Visible = false;
                clientForm.dataGridViewClientAddress.Columns["CityName"].HeaderText = "Nume Oras";
                clientForm.dataGridViewClientAddress.Columns["CountyName"].HeaderText = "Nume Regiune";
                clientForm.dataGridViewClientAddress.Columns["StreetName"].HeaderText = "Nume Strada";
                clientForm.dataGridViewClientAddress.Columns["StreetNo"].HeaderText = "Numar Strada";

                clientForm.FormClosed += ClientDetail_Form_Closed;
            }
            else
            {
                MessageBox.Show("Adresa nu e adaugata!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientDetail_Form_Closed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
