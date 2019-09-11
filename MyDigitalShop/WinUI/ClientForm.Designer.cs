namespace WinUI
{
    public partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewClientAddress = new System.Windows.Forms.DataGridView();
            this.txtBoxClientName = new System.Windows.Forms.TextBox();
            this.txtBoxSurName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.lblIdInvisible = new System.Windows.Forms.Label();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.lblCodeClient = new System.Windows.Forms.Label();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.txtBoxClientCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientAddress)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(294, 60);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(64, 25);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Nume";
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurName.Location = new System.Drawing.Point(501, 57);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(91, 25);
            this.lblSurName.TabIndex = 1;
            this.lblSurName.Text = "Prenume";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(294, 82);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(160, 25);
            this.lblPhoneNo.TabIndex = 3;
            this.lblPhoneNo.Text = "Numar de telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(61, 82);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-2, -3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 31);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Spre lista";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dataGridViewClientAddress
            // 
            this.dataGridViewClientAddress.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewClientAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientAddress.Location = new System.Drawing.Point(21, 138);
            this.dataGridViewClientAddress.Name = "dataGridViewClientAddress";
            this.dataGridViewClientAddress.Size = new System.Drawing.Size(767, 217);
            this.dataGridViewClientAddress.TabIndex = 6;
            this.dataGridViewClientAddress.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClientAddress_CellContentDoubleClick);
            // 
            // txtBoxClientName
            // 
            this.txtBoxClientName.Location = new System.Drawing.Point(366, 60);
            this.txtBoxClientName.Name = "txtBoxClientName";
            this.txtBoxClientName.Size = new System.Drawing.Size(129, 20);
            this.txtBoxClientName.TabIndex = 7;
            // 
            // txtBoxSurName
            // 
            this.txtBoxSurName.Location = new System.Drawing.Point(598, 63);
            this.txtBoxSurName.Name = "txtBoxSurName";
            this.txtBoxSurName.Size = new System.Drawing.Size(147, 20);
            this.txtBoxSurName.TabIndex = 8;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(127, 87);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(161, 20);
            this.txtBoxEmail.TabIndex = 10;
            // 
            // txtBoxPhoneNo
            // 
            this.txtBoxPhoneNo.Location = new System.Drawing.Point(460, 87);
            this.txtBoxPhoneNo.Name = "txtBoxPhoneNo";
            this.txtBoxPhoneNo.Size = new System.Drawing.Size(132, 20);
            this.txtBoxPhoneNo.TabIndex = 11;
            this.txtBoxPhoneNo.TextChanged += new System.EventHandler(this.TxtBoxPhoneNo_TextChanged);
            this.txtBoxPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxPhoneNo_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUpdateClient);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(22, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 26);
            this.panel1.TabIndex = 12;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateClient.FlatAppearance.BorderSize = 5;
            this.btnUpdateClient.Location = new System.Drawing.Point(138, -3);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(134, 31);
            this.btnUpdateClient.TabIndex = 6;
            this.btnUpdateClient.Text = "Modifica Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.BtnUpdateClient_Click);
            // 
            // lblIdInvisible
            // 
            this.lblIdInvisible.AutoSize = true;
            this.lblIdInvisible.ForeColor = System.Drawing.Color.Transparent;
            this.lblIdInvisible.Location = new System.Drawing.Point(8, 21);
            this.lblIdInvisible.Name = "lblIdInvisible";
            this.lblIdInvisible.Size = new System.Drawing.Size(0, 13);
            this.lblIdInvisible.TabIndex = 13;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(19, 116);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(75, 23);
            this.btnAddAddress.TabIndex = 14;
            this.btnAddAddress.Text = "Adauga Adresa";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.BtnAddAddress_Click);
            // 
            // lblCodeClient
            // 
            this.lblCodeClient.AutoSize = true;
            this.lblCodeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeClient.Location = new System.Drawing.Point(72, 54);
            this.lblCodeClient.Name = "lblCodeClient";
            this.lblCodeClient.Size = new System.Drawing.Size(49, 25);
            this.lblCodeClient.TabIndex = 15;
            this.lblCodeClient.Text = "Cod";
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.Location = new System.Drawing.Point(100, 116);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAddress.TabIndex = 16;
            this.btnDeleteAddress.Text = "Sterge-ma";
            this.btnDeleteAddress.UseVisualStyleBackColor = true;
            this.btnDeleteAddress.Click += new System.EventHandler(this.BtnDeleteAddress_Click);
            // 
            // txtBoxClientCode
            // 
            this.txtBoxClientCode.Location = new System.Drawing.Point(127, 57);
            this.txtBoxClientCode.Name = "txtBoxClientCode";
            this.txtBoxClientCode.Size = new System.Drawing.Size(161, 20);
            this.txtBoxClientCode.TabIndex = 17;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxClientCode);
            this.Controls.Add(this.btnDeleteAddress);
            this.Controls.Add(this.lblCodeClient);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.lblIdInvisible);
            this.Controls.Add(this.txtBoxPhoneNo);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxSurName);
            this.Controls.Add(this.txtBoxClientName);
            this.Controls.Add(this.dataGridViewClientAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblSurName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.panel1);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientAddress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblClientName;
        public System.Windows.Forms.Label lblSurName;
        public System.Windows.Forms.Label lblPhoneNo;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.DataGridView dataGridViewClientAddress;
        public System.Windows.Forms.TextBox txtBoxClientName;
        public System.Windows.Forms.TextBox txtBoxSurName;
        public System.Windows.Forms.TextBox txtBoxEmail;
        public System.Windows.Forms.TextBox txtBoxPhoneNo;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnUpdateClient;
        public System.Windows.Forms.Label lblIdInvisible;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Label lblCodeClient;
        private System.Windows.Forms.Button btnDeleteAddress;
        public System.Windows.Forms.TextBox txtBoxClientCode;
    }
}