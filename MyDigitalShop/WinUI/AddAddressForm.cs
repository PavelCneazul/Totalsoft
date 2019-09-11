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
    public partial class AddAddressForm : Form
    {
        public int IdClient;
        public AddAddressForm()
        {
            InitializeComponent();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCounty.SelectedValue.ToString() != null)
            {
                BLCity blCity  = new BLCity();
                DataTable dt = new DataTable();
                int s = Convert.ToInt32(comboBoxCounty.SelectedValue);
                BindingList<CityModel> lista = new BindingList<CityModel>();
                lista = blCity.CityList(s);
                var source = new BindingSource(lista, null);


                comboBoxGetCity.Enabled = true;
                comboBoxGetCity.ValueMember = "CityId";
                comboBoxGetCity.DisplayMember = "CityName";
                comboBoxGetCity.DataSource = source;
            }
           
        }

        private void GetItems_BtnClik(object sender, EventArgs e)
        {
        }

        private void AddAddressForm_Load(object sender, EventArgs e)
        {
            BLCounty bLCounty = new BLCounty();
            DataTable dt = new DataTable();
            BindingList<CountyModel> lista = new BindingList<CountyModel>();        
            lista = bLCounty.CountyList();
            var source = new BindingSource(lista, null);

            DACountyGet getCounties = new DACountyGet();
            DataTable getCountiesTable = getCounties.getCounty();
            
            comboBoxCounty.ValueMember = "CountyId";
            comboBoxCounty.DisplayMember = "CountyName";
            comboBoxCounty.DataSource = source;
            comboBoxGetCity.Enabled = false;
        }

        private void BtnAddAddress_Click(object sender, EventArgs e)
        {
            bool status = false;
            DAAddAddress dAAdd = new DAAddAddress();
            status = dAAdd.addaddress(IdClient, comboBoxGetCity.SelectedItem.ToString(),comboBoxCounty.SelectedItem.ToString(), txtBoxStreet.Text, txtBoxStreetNo.Text);
            if (status == true)
            {
                MessageBox.Show("Adresa a fost adaugata!", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClientForm clientForm = new ClientForm();
                this.Hide();
                clientForm.Show();

                DAGetClient dAGetClient = new DAGetClient();
                DataTable dataTable = new DataTable();
                dataTable = dAGetClient.getClient(IdClient);
                clientForm.txtBoxClientName.Text = dataTable.Rows[0]["ClientName"].ToString();
                clientForm.lblIdInvisible.Text = IdClient.ToString();
                clientForm.lblIdInvisible.Visible = false;
                clientForm.txtBoxSurName.Text = dataTable.Rows[0]["ClientSurName"].ToString();
                clientForm.txtBoxPhoneNo.Text = dataTable.Rows[0]["PhoneNo"].ToString();
                clientForm.txtBoxClientCode.Text = dataTable.Rows[0]["ClientCode"].ToString();
                clientForm.txtBoxEmail.Text = dataTable.Rows[0]["Email"].ToString();

                DAGetAddres addres = new DAGetAddres();
                clientForm.dataGridViewClientAddress.DataSource = addres.GetAddress(IdClient);
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
