namespace WinUI
{
    partial class AddClientForm
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
            this.lblAddClienName = new System.Windows.Forms.Label();
            this.lblAddClienSurname = new System.Windows.Forms.Label();
            this.lblAddClientCode = new System.Windows.Forms.Label();
            this.lblAddPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.boxAddNume = new System.Windows.Forms.TextBox();
            this.boxAddSurName = new System.Windows.Forms.TextBox();
            this.boxAddClientCode = new System.Windows.Forms.TextBox();
            this.boxAddphoneno = new System.Windows.Forms.TextBox();
            this.boxAddEmail = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnBackToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddClienName
            // 
            this.lblAddClienName.AutoSize = true;
            this.lblAddClienName.Location = new System.Drawing.Point(50, 48);
            this.lblAddClienName.Name = "lblAddClienName";
            this.lblAddClienName.Size = new System.Drawing.Size(35, 13);
            this.lblAddClienName.TabIndex = 0;
            this.lblAddClienName.Text = "Nume";
            // 
            // lblAddClienSurname
            // 
            this.lblAddClienSurname.AutoSize = true;
            this.lblAddClienSurname.Location = new System.Drawing.Point(36, 75);
            this.lblAddClienSurname.Name = "lblAddClienSurname";
            this.lblAddClienSurname.Size = new System.Drawing.Size(49, 13);
            this.lblAddClienSurname.TabIndex = 1;
            this.lblAddClienSurname.Text = "Prenume";
            // 
            // lblAddClientCode
            // 
            this.lblAddClientCode.AutoSize = true;
            this.lblAddClientCode.Location = new System.Drawing.Point(30, 111);
            this.lblAddClientCode.Name = "lblAddClientCode";
            this.lblAddClientCode.Size = new System.Drawing.Size(55, 13);
            this.lblAddClientCode.TabIndex = 2;
            this.lblAddClientCode.Text = "Cod Client";
            // 
            // lblAddPhoneNumber
            // 
            this.lblAddPhoneNumber.AutoSize = true;
            this.lblAddPhoneNumber.Location = new System.Drawing.Point(12, 140);
            this.lblAddPhoneNumber.Name = "lblAddPhoneNumber";
            this.lblAddPhoneNumber.Size = new System.Drawing.Size(73, 13);
            this.lblAddPhoneNumber.TabIndex = 3;
            this.lblAddPhoneNumber.Text = "Numar telefon";
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(53, 172);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(32, 13);
            this.lblAddEmail.TabIndex = 4;
            this.lblAddEmail.Text = "Email";
            // 
            // boxAddNume
            // 
            this.boxAddNume.Location = new System.Drawing.Point(91, 41);
            this.boxAddNume.Name = "boxAddNume";
            this.boxAddNume.Size = new System.Drawing.Size(151, 20);
            this.boxAddNume.TabIndex = 5;
            // 
            // boxAddSurName
            // 
            this.boxAddSurName.Location = new System.Drawing.Point(91, 72);
            this.boxAddSurName.Name = "boxAddSurName";
            this.boxAddSurName.Size = new System.Drawing.Size(151, 20);
            this.boxAddSurName.TabIndex = 6;
            // 
            // boxAddClientCode
            // 
            this.boxAddClientCode.Location = new System.Drawing.Point(91, 104);
            this.boxAddClientCode.Name = "boxAddClientCode";
            this.boxAddClientCode.Size = new System.Drawing.Size(151, 20);
            this.boxAddClientCode.TabIndex = 7;
            // 
            // boxAddphoneno
            // 
            this.boxAddphoneno.Location = new System.Drawing.Point(91, 140);
            this.boxAddphoneno.Name = "boxAddphoneno";
            this.boxAddphoneno.Size = new System.Drawing.Size(151, 20);
            this.boxAddphoneno.TabIndex = 8;
            // 
            // boxAddEmail
            // 
            this.boxAddEmail.Location = new System.Drawing.Point(91, 169);
            this.boxAddEmail.Name = "boxAddEmail";
            this.boxAddEmail.Size = new System.Drawing.Size(151, 20);
            this.boxAddEmail.TabIndex = 9;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(114, 215);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(76, 23);
            this.btnAddClient.TabIndex = 10;
            this.btnAddClient.Text = "Salveaza";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // btnBackToList
            // 
            this.btnBackToList.Location = new System.Drawing.Point(9, 12);
            this.btnBackToList.Name = "btnBackToList";
            this.btnBackToList.Size = new System.Drawing.Size(76, 23);
            this.btnBackToList.TabIndex = 11;
            this.btnBackToList.Text = "Renunta";
            this.btnBackToList.UseVisualStyleBackColor = true;
            this.btnBackToList.Click += new System.EventHandler(this.BtnBackToList_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 261);
            this.Controls.Add(this.btnBackToList);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.boxAddEmail);
            this.Controls.Add(this.boxAddphoneno);
            this.Controls.Add(this.boxAddClientCode);
            this.Controls.Add(this.boxAddSurName);
            this.Controls.Add(this.boxAddNume);
            this.Controls.Add(this.lblAddEmail);
            this.Controls.Add(this.lblAddPhoneNumber);
            this.Controls.Add(this.lblAddClientCode);
            this.Controls.Add(this.lblAddClienSurname);
            this.Controls.Add(this.lblAddClienName);
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddClienName;
        private System.Windows.Forms.Label lblAddClienSurname;
        private System.Windows.Forms.Label lblAddClientCode;
        private System.Windows.Forms.Label lblAddPhoneNumber;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.TextBox boxAddNume;
        private System.Windows.Forms.TextBox boxAddSurName;
        private System.Windows.Forms.TextBox boxAddClientCode;
        private System.Windows.Forms.TextBox boxAddphoneno;
        private System.Windows.Forms.TextBox boxAddEmail;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnBackToList;
    }
}