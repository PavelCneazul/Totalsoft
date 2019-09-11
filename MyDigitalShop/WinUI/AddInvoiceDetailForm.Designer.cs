namespace WinUI
{
    partial class AddInvoiceDetailForm
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
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.txtBoxQtty = new System.Windows.Forms.TextBox();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lblQtty = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblObservations = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnAddInvoiceDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(63, 56);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(361, 21);
            this.comboBoxItem.TabIndex = 0;
            this.comboBoxItem.DropDown += new System.EventHandler(this.ComboBoxItem_DropDown);
            // 
            // txtBoxQtty
            // 
            this.txtBoxQtty.Location = new System.Drawing.Point(63, 91);
            this.txtBoxQtty.Name = "txtBoxQtty";
            this.txtBoxQtty.Size = new System.Drawing.Size(80, 20);
            this.txtBoxQtty.TabIndex = 1;
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(330, 94);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(80, 20);
            this.txtBoxAmount.TabIndex = 2;
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(96, 135);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(328, 55);
            this.txtObservations.TabIndex = 3;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(181, 94);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(80, 20);
            this.txtBoxPrice.TabIndex = 4;
            // 
            // lblQtty
            // 
            this.lblQtty.AutoSize = true;
            this.lblQtty.Location = new System.Drawing.Point(13, 94);
            this.lblQtty.Name = "lblQtty";
            this.lblQtty.Size = new System.Drawing.Size(49, 13);
            this.lblQtty.TabIndex = 5;
            this.lblQtty.Text = "Cantitate";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(281, 101);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(149, 94);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(26, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Pret";
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(12, 135);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(69, 13);
            this.lblObservations.TabIndex = 8;
            this.lblObservations.Text = "Observations";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(22, 59);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(40, 13);
            this.lblItemName.TabIndex = 9;
            this.lblItemName.Text = "Produs";
            // 
            // btnAddInvoiceDetail
            // 
            this.btnAddInvoiceDetail.Location = new System.Drawing.Point(16, 222);
            this.btnAddInvoiceDetail.Name = "btnAddInvoiceDetail";
            this.btnAddInvoiceDetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddInvoiceDetail.TabIndex = 10;
            this.btnAddInvoiceDetail.Text = "Adauga";
            this.btnAddInvoiceDetail.UseVisualStyleBackColor = true;
            this.btnAddInvoiceDetail.Click += new System.EventHandler(this.BtnAddInvoiceDetail_Click);
            // 
            // AddInvoiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 277);
            this.Controls.Add(this.btnAddInvoiceDetail);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblObservations);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblQtty);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.txtBoxAmount);
            this.Controls.Add(this.txtBoxQtty);
            this.Controls.Add(this.comboBoxItem);
            this.Name = "AddInvoiceDetailForm";
            this.Text = "AddInvoiceDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxItem;
        public System.Windows.Forms.TextBox txtBoxQtty;
        public System.Windows.Forms.TextBox txtBoxAmount;
        public System.Windows.Forms.TextBox txtObservations;
        public System.Windows.Forms.TextBox txtBoxPrice;
        public System.Windows.Forms.Label lblQtty;
        public System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblObservations;
        public System.Windows.Forms.Label lblItemName;
        public System.Windows.Forms.Button btnAddInvoiceDetail;
    }
}