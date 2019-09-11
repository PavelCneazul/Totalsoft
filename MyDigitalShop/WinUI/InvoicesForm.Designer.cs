namespace WinUI
{
    partial class InvoicesForm
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
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btn_printInvoices = new System.Windows.Forms.Button();
            this.dTPStartFrom = new System.Windows.Forms.DateTimePicker();
            this.dTPEndAt = new System.Windows.Forms.DateTimePicker();
            this.txtBoxFilterInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblStartedFrom = new System.Windows.Forms.Label();
            this.lblEndTo = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.checkBoxStartedAt = new System.Windows.Forms.CheckBox();
            this.checkBoxEndTo = new System.Windows.Forms.CheckBox();
            this.dGVInvoices = new System.Windows.Forms.DataGridView();
            this.cmbBoxClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInvoices)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(453, 28);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnAddInvoice.TabIndex = 2;
            this.btnAddInvoice.Text = "Adauga Factura";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.BtnAddInvoice_Click);
            // 
            // btn_printInvoices
            // 
            this.btn_printInvoices.Location = new System.Drawing.Point(330, 28);
            this.btn_printInvoices.Name = "btn_printInvoices";
            this.btn_printInvoices.Size = new System.Drawing.Size(108, 23);
            this.btn_printInvoices.TabIndex = 3;
            this.btn_printInvoices.Text = "Afiseaza facturi";
            this.btn_printInvoices.UseVisualStyleBackColor = true;
            this.btn_printInvoices.Click += new System.EventHandler(this.Btn_printInvoices_Click);
            // 
            // dTPStartFrom
            // 
            this.dTPStartFrom.Location = new System.Drawing.Point(97, 62);
            this.dTPStartFrom.Name = "dTPStartFrom";
            this.dTPStartFrom.Size = new System.Drawing.Size(200, 20);
            this.dTPStartFrom.TabIndex = 4;
            // 
            // dTPEndAt
            // 
            this.dTPEndAt.Location = new System.Drawing.Point(97, 109);
            this.dTPEndAt.Name = "dTPEndAt";
            this.dTPEndAt.Size = new System.Drawing.Size(200, 20);
            this.dTPEndAt.TabIndex = 5;
            // 
            // txtBoxFilterInvoiceNumber
            // 
            this.txtBoxFilterInvoiceNumber.Location = new System.Drawing.Point(97, 24);
            this.txtBoxFilterInvoiceNumber.Name = "txtBoxFilterInvoiceNumber";
            this.txtBoxFilterInvoiceNumber.Size = new System.Drawing.Size(91, 20);
            this.txtBoxFilterInvoiceNumber.TabIndex = 6;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(9, 31);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(82, 13);
            this.lblInvoiceNumber.TabIndex = 8;
            this.lblInvoiceNumber.Text = "Invoice Number";
            // 
            // lblStartedFrom
            // 
            this.lblStartedFrom.AutoSize = true;
            this.lblStartedFrom.Location = new System.Drawing.Point(39, 68);
            this.lblStartedFrom.Name = "lblStartedFrom";
            this.lblStartedFrom.Size = new System.Drawing.Size(52, 13);
            this.lblStartedFrom.TabIndex = 9;
            this.lblStartedFrom.Text = "Start from";
            // 
            // lblEndTo
            // 
            this.lblEndTo.AutoSize = true;
            this.lblEndTo.Location = new System.Drawing.Point(53, 115);
            this.lblEndTo.Name = "lblEndTo";
            this.lblEndTo.Size = new System.Drawing.Size(38, 13);
            this.lblEndTo.TabIndex = 10;
            this.lblEndTo.Text = "End to";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(9, 139);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(26, 13);
            this.lblClientId.TabIndex = 11;
            this.lblClientId.Text = "Cod";
            // 
            // checkBoxStartedAt
            // 
            this.checkBoxStartedAt.AutoSize = true;
            this.checkBoxStartedAt.Location = new System.Drawing.Point(18, 67);
            this.checkBoxStartedAt.Name = "checkBoxStartedAt";
            this.checkBoxStartedAt.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStartedAt.TabIndex = 12;
            this.checkBoxStartedAt.UseVisualStyleBackColor = true;
            this.checkBoxStartedAt.CheckStateChanged += new System.EventHandler(this.CheckBoxStartedAt_CheckStateChanged);
            // 
            // checkBoxEndTo
            // 
            this.checkBoxEndTo.AutoSize = true;
            this.checkBoxEndTo.Location = new System.Drawing.Point(18, 115);
            this.checkBoxEndTo.Name = "checkBoxEndTo";
            this.checkBoxEndTo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEndTo.TabIndex = 13;
            this.checkBoxEndTo.UseVisualStyleBackColor = true;
            this.checkBoxEndTo.CheckStateChanged += new System.EventHandler(this.CheckBoxEndTo_CheckStateChanged);
            // 
            // dGVInvoices
            // 
            this.dGVInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInvoices.Location = new System.Drawing.Point(319, 57);
            this.dGVInvoices.Name = "dGVInvoices";
            this.dGVInvoices.Size = new System.Drawing.Size(786, 381);
            this.dGVInvoices.TabIndex = 14;
            this.dGVInvoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInvoices_CellDoubleClick);
            // 
            // cmbBoxClient
            // 
            this.cmbBoxClient.FormattingEnabled = true;
            this.cmbBoxClient.Location = new System.Drawing.Point(2, 155);
            this.cmbBoxClient.Name = "cmbBoxClient";
            this.cmbBoxClient.Size = new System.Drawing.Size(295, 21);
            this.cmbBoxClient.TabIndex = 15;
            this.cmbBoxClient.DropDown += new System.EventHandler(this.CmbBoxClient_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nume";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbBoxClient);
            this.panel1.Controls.Add(this.checkBoxEndTo);
            this.panel1.Controls.Add(this.checkBoxStartedAt);
            this.panel1.Controls.Add(this.lblClientId);
            this.panel1.Controls.Add(this.lblEndTo);
            this.panel1.Controls.Add(this.lblStartedFrom);
            this.panel1.Controls.Add(this.lblInvoiceNumber);
            this.panel1.Controls.Add(this.txtBoxFilterInvoiceNumber);
            this.panel1.Controls.Add(this.dTPEndAt);
            this.panel1.Controls.Add(this.dTPStartFrom);
            this.panel1.Location = new System.Drawing.Point(10, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 340);
            this.panel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGVInvoices);
            this.Controls.Add(this.btn_printInvoices);
            this.Controls.Add(this.btnAddInvoice);
            this.Name = "InvoicesForm";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVInvoices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btn_printInvoices;
        private System.Windows.Forms.DateTimePicker dTPStartFrom;
        private System.Windows.Forms.DateTimePicker dTPEndAt;
        private System.Windows.Forms.TextBox txtBoxFilterInvoiceNumber;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblStartedFrom;
        private System.Windows.Forms.Label lblEndTo;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.CheckBox checkBoxStartedAt;
        private System.Windows.Forms.CheckBox checkBoxEndTo;
        private System.Windows.Forms.DataGridView dGVInvoices;
        private System.Windows.Forms.ComboBox cmbBoxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}