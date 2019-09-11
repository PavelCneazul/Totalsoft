namespace WinUI
{
    partial class AddAddressForm
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
            this.comboBoxCounty = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.comboBoxGetCity = new System.Windows.Forms.ComboBox();
            this.lblCountyName = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.txtBoxStreetNo = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblStreetNo = new System.Windows.Forms.Label();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCounty
            // 
            this.comboBoxCounty.FormattingEnabled = true;
            this.comboBoxCounty.Location = new System.Drawing.Point(95, 33);
            this.comboBoxCounty.Name = "comboBoxCounty";
            this.comboBoxCounty.Size = new System.Drawing.Size(128, 21);
            this.comboBoxCounty.TabIndex = 0;
            this.comboBoxCounty.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBoxCounty.Click += new System.EventHandler(this.GetItems_BtnClik);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // comboBoxGetCity
            // 
            this.comboBoxGetCity.FormattingEnabled = true;
            this.comboBoxGetCity.Location = new System.Drawing.Point(95, 72);
            this.comboBoxGetCity.Name = "comboBoxGetCity";
            this.comboBoxGetCity.Size = new System.Drawing.Size(128, 21);
            this.comboBoxGetCity.TabIndex = 1;
            // 
            // lblCountyName
            // 
            this.lblCountyName.AutoSize = true;
            this.lblCountyName.Location = new System.Drawing.Point(42, 33);
            this.lblCountyName.Name = "lblCountyName";
            this.lblCountyName.Size = new System.Drawing.Size(47, 13);
            this.lblCountyName.TabIndex = 2;
            this.lblCountyName.Text = "Regiune";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(60, 72);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(29, 13);
            this.lblCityName.TabIndex = 3;
            this.lblCityName.Text = "Oras";
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(95, 113);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(128, 20);
            this.txtBoxStreet.TabIndex = 4;
            // 
            // txtBoxStreetNo
            // 
            this.txtBoxStreetNo.Location = new System.Drawing.Point(95, 156);
            this.txtBoxStreetNo.Name = "txtBoxStreetNo";
            this.txtBoxStreetNo.Size = new System.Drawing.Size(128, 20);
            this.txtBoxStreetNo.TabIndex = 5;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(51, 116);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 6;
            this.lblStreet.Text = "Strada";
            // 
            // lblStreetNo
            // 
            this.lblStreetNo.AutoSize = true;
            this.lblStreetNo.Location = new System.Drawing.Point(12, 159);
            this.lblStreetNo.Name = "lblStreetNo";
            this.lblStreetNo.Size = new System.Drawing.Size(77, 13);
            this.lblStreetNo.TabIndex = 7;
            this.lblStreetNo.Text = "Numarul Strazii";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(282, 33);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(74, 32);
            this.btnAddAddress.TabIndex = 8;
            this.btnAddAddress.Text = "Adauga";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.BtnAddAddress_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(402, 108);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(102, 20);
            this.txtBoxId.TabIndex = 9;
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 202);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.lblStreetNo);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtBoxStreetNo);
            this.Controls.Add(this.txtBoxStreet);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.lblCountyName);
            this.Controls.Add(this.comboBoxGetCity);
            this.Controls.Add(this.comboBoxCounty);
            this.Name = "AddAddressForm";
            this.Text = "AddAddressForm";
            this.Load += new System.EventHandler(this.AddAddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCounty;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox comboBoxGetCity;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblCountyName;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Label lblStreetNo;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtBoxStreetNo;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.TextBox txtBoxId;
    }
}