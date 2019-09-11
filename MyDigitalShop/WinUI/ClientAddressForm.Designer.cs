namespace WinUI
{
    partial class ClientAddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxUpdateCounty = new System.Windows.Forms.ComboBox();
            this.comboBoxUpdateCity = new System.Windows.Forms.ComboBox();
            this.txtBoxUpdateStreetName = new System.Windows.Forms.TextBox();
            this.textBoxStreetNo = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreeNumber = new System.Windows.Forms.Label();
            this.lbl4StreetNo = new System.Windows.Forms.Label();
            this.btnModificaAdresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUpdateCounty
            // 
            this.comboBoxUpdateCounty.FormattingEnabled = true;
            this.comboBoxUpdateCounty.Location = new System.Drawing.Point(153, 33);
            this.comboBoxUpdateCounty.Name = "comboBoxUpdateCounty";
            this.comboBoxUpdateCounty.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUpdateCounty.TabIndex = 0;
            this.comboBoxUpdateCounty.DropDown += new System.EventHandler(this.ComboBoxUpdateCounty_DropDown);
            this.comboBoxUpdateCounty.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUpdateCounty_SelectedIndexChanged);
            // 
            // comboBoxUpdateCity
            // 
            this.comboBoxUpdateCity.FormattingEnabled = true;
            this.comboBoxUpdateCity.Location = new System.Drawing.Point(153, 75);
            this.comboBoxUpdateCity.Name = "comboBoxUpdateCity";
            this.comboBoxUpdateCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUpdateCity.TabIndex = 1;
            // 
            // txtBoxUpdateStreetName
            // 
            this.txtBoxUpdateStreetName.Location = new System.Drawing.Point(153, 111);
            this.txtBoxUpdateStreetName.Name = "txtBoxUpdateStreetName";
            this.txtBoxUpdateStreetName.Size = new System.Drawing.Size(121, 20);
            this.txtBoxUpdateStreetName.TabIndex = 2;
            // 
            // textBoxStreetNo
            // 
            this.textBoxStreetNo.Location = new System.Drawing.Point(153, 146);
            this.textBoxStreetNo.Name = "textBoxStreetNo";
            this.textBoxStreetNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxStreetNo.TabIndex = 3;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(81, 41);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(47, 13);
            this.lblCounty.TabIndex = 4;
            this.lblCounty.Text = "Regiune";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(99, 83);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "Oras";
            // 
            // lblStreeNumber
            // 
            this.lblStreeNumber.AutoSize = true;
            this.lblStreeNumber.Location = new System.Drawing.Point(90, 118);
            this.lblStreeNumber.Name = "lblStreeNumber";
            this.lblStreeNumber.Size = new System.Drawing.Size(38, 13);
            this.lblStreeNumber.TabIndex = 6;
            this.lblStreeNumber.Text = "Strada";
            // 
            // lbl4StreetNo
            // 
            this.lbl4StreetNo.AutoSize = true;
            this.lbl4StreetNo.Location = new System.Drawing.Point(53, 153);
            this.lbl4StreetNo.Name = "lbl4StreetNo";
            this.lbl4StreetNo.Size = new System.Drawing.Size(75, 13);
            this.lbl4StreetNo.TabIndex = 7;
            this.lbl4StreetNo.Text = "Numarul strazii";
            // 
            // btnModificaAdresa
            // 
            this.btnModificaAdresa.Location = new System.Drawing.Point(167, 193);
            this.btnModificaAdresa.Name = "btnModificaAdresa";
            this.btnModificaAdresa.Size = new System.Drawing.Size(75, 23);
            this.btnModificaAdresa.TabIndex = 8;
            this.btnModificaAdresa.Text = "Modifica";
            this.btnModificaAdresa.UseVisualStyleBackColor = true;
            this.btnModificaAdresa.Click += new System.EventHandler(this.BtnModificaAdresa_Click);
            // 
            // ClientAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 250);
            this.Controls.Add(this.btnModificaAdresa);
            this.Controls.Add(this.lbl4StreetNo);
            this.Controls.Add(this.lblStreeNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.textBoxStreetNo);
            this.Controls.Add(this.txtBoxUpdateStreetName);
            this.Controls.Add(this.comboBoxUpdateCity);
            this.Controls.Add(this.comboBoxUpdateCounty);
            this.Name = "ClientAddressForm";
            this.Text = "ClientAddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxUpdateCounty;
        public System.Windows.Forms.ComboBox comboBoxUpdateCity;
        public System.Windows.Forms.TextBox txtBoxUpdateStreetName;
        public System.Windows.Forms.TextBox textBoxStreetNo;
        public System.Windows.Forms.Label lblCounty;
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.Label lblStreeNumber;
        public System.Windows.Forms.Label lbl4StreetNo;
        public System.Windows.Forms.Button btnModificaAdresa;
    }
}