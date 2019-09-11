namespace WinUI
{
    partial class MainMenuForm
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
            this.btnClients = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(122, 12);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(234, 79);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clientii";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(122, 123);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(234, 79);
            this.btnInvoices.TabIndex = 1;
            this.btnInvoices.Text = "Facturi";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.BtnInvoices_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(122, 240);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(234, 79);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Articole";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.BtnItems_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 331);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnClients);
            this.Name = "MainMenuForm";
            this.Text = "MeniuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnItems;
    }
}