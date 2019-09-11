namespace WinUI
{
    partial class InvoiceForm
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
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.lblObervations = new System.Windows.Forms.Label();
            this.txtBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.dateInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxClientAddress = new System.Windows.Forms.ComboBox();
            this.txtBoxObservations = new System.Windows.Forms.TextBox();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.dGVInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(32, 29);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(82, 13);
            this.lblInvoiceNumber.TabIndex = 0;
            this.lblInvoiceNumber.Text = "Invoice Number";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(46, 65);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(68, 13);
            this.lblInvoiceDate.TabIndex = 1;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(77, 100);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client";
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Location = new System.Drawing.Point(40, 135);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(74, 13);
            this.lblClientAddress.TabIndex = 3;
            this.lblClientAddress.Text = "Client Address";
            // 
            // lblObervations
            // 
            this.lblObervations.AutoSize = true;
            this.lblObervations.Location = new System.Drawing.Point(605, 33);
            this.lblObervations.Name = "lblObervations";
            this.lblObervations.Size = new System.Drawing.Size(69, 13);
            this.lblObervations.TabIndex = 4;
            this.lblObervations.Text = "Observations";
            // 
            // txtBoxInvoiceNumber
            // 
            this.txtBoxInvoiceNumber.Location = new System.Drawing.Point(120, 26);
            this.txtBoxInvoiceNumber.Name = "txtBoxInvoiceNumber";
            this.txtBoxInvoiceNumber.Size = new System.Drawing.Size(74, 20);
            this.txtBoxInvoiceNumber.TabIndex = 5;
            // 
            // dateInvoiceDate
            // 
            this.dateInvoiceDate.Location = new System.Drawing.Point(120, 65);
            this.dateInvoiceDate.Name = "dateInvoiceDate";
            this.dateInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dateInvoiceDate.TabIndex = 7;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(116, 100);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(204, 21);
            this.comboBoxClient.TabIndex = 8;
            this.comboBoxClient.DropDown += new System.EventHandler(this.ComboBoxClient_DropDown);
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClient_SelectedIndexChanged);
            // 
            // comboBoxClientAddress
            // 
            this.comboBoxClientAddress.FormattingEnabled = true;
            this.comboBoxClientAddress.Location = new System.Drawing.Point(116, 135);
            this.comboBoxClientAddress.Name = "comboBoxClientAddress";
            this.comboBoxClientAddress.Size = new System.Drawing.Size(204, 21);
            this.comboBoxClientAddress.TabIndex = 9;
            // 
            // txtBoxObservations
            // 
            this.txtBoxObservations.Location = new System.Drawing.Point(353, 68);
            this.txtBoxObservations.Multiline = true;
            this.txtBoxObservations.Name = "txtBoxObservations";
            this.txtBoxObservations.Size = new System.Drawing.Size(435, 93);
            this.txtBoxObservations.TabIndex = 10;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(362, 12);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnAddInvoice.TabIndex = 11;
            this.btnAddInvoice.Text = "Salveaza";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.BtnAddInvoice_Click);
            // 
            // dGVInvoiceDetails
            // 
            this.dGVInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInvoiceDetails.Location = new System.Drawing.Point(35, 191);
            this.dGVInvoiceDetails.Name = "dGVInvoiceDetails";
            this.dGVInvoiceDetails.Size = new System.Drawing.Size(752, 194);
            this.dGVInvoiceDetails.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Modifica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sterge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Adrese";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dGVInvoiceDetails);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.txtBoxObservations);
            this.Controls.Add(this.comboBoxClientAddress);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.dateInvoiceDate);
            this.Controls.Add(this.txtBoxInvoiceNumber);
            this.Controls.Add(this.lblObervations);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVInvoiceDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblInvoiceNumber;
        public System.Windows.Forms.Label lblInvoiceDate;
        public System.Windows.Forms.Label lblClient;
        public System.Windows.Forms.Label lblClientAddress;
        public System.Windows.Forms.Label lblObervations;
        public System.Windows.Forms.TextBox txtBoxInvoiceNumber;
        public System.Windows.Forms.DateTimePicker dateInvoiceDate;
        public System.Windows.Forms.ComboBox comboBoxClient;
        public System.Windows.Forms.ComboBox comboBoxClientAddress;
        public System.Windows.Forms.TextBox txtBoxObservations;
        public System.Windows.Forms.Button btnAddInvoice;
        public System.Windows.Forms.DataGridView dGVInvoiceDetails;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
    }
}