namespace WinUI
{
    partial class ClientsForm
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
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnShowClients = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxNameFilter = new System.Windows.Forms.TextBox();
            this.txtBoxFilterSurname = new System.Windows.Forms.TextBox();
            this.txtBoxFilterCode = new System.Windows.Forms.TextBox();
            this.lblFilterName = new System.Windows.Forms.Label();
            this.lblFilterSurName = new System.Windows.Forms.Label();
            this.lblFilterCode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridClients.Location = new System.Drawing.Point(195, 31);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.Size = new System.Drawing.Size(771, 328);
            this.dataGridClients.TabIndex = 0;
            this.dataGridClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridClients_CellContentClick);
            this.dataGridClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridClients_CellDoubleClick);
            this.dataGridClients.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridClients_DefaultValuesNeeded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // btnShowClients
            // 
            this.btnShowClients.Location = new System.Drawing.Point(877, 2);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(89, 23);
            this.btnShowClients.TabIndex = 1;
            this.btnShowClients.Text = "Fulgerica";
            this.btnShowClients.UseVisualStyleBackColor = true;
            this.btnShowClients.Click += new System.EventHandler(this.BtnShowClients_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(782, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sterge Client";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtBoxNameFilter
            // 
            this.txtBoxNameFilter.Location = new System.Drawing.Point(70, 103);
            this.txtBoxNameFilter.Name = "txtBoxNameFilter";
            this.txtBoxNameFilter.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNameFilter.TabIndex = 3;
            // 
            // txtBoxFilterSurname
            // 
            this.txtBoxFilterSurname.Location = new System.Drawing.Point(70, 139);
            this.txtBoxFilterSurname.Name = "txtBoxFilterSurname";
            this.txtBoxFilterSurname.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFilterSurname.TabIndex = 4;
            // 
            // txtBoxFilterCode
            // 
            this.txtBoxFilterCode.Location = new System.Drawing.Point(70, 180);
            this.txtBoxFilterCode.Name = "txtBoxFilterCode";
            this.txtBoxFilterCode.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFilterCode.TabIndex = 5;
            // 
            // lblFilterName
            // 
            this.lblFilterName.AutoSize = true;
            this.lblFilterName.Location = new System.Drawing.Point(29, 106);
            this.lblFilterName.Name = "lblFilterName";
            this.lblFilterName.Size = new System.Drawing.Size(35, 13);
            this.lblFilterName.TabIndex = 6;
            this.lblFilterName.Text = "Nume";
            // 
            // lblFilterSurName
            // 
            this.lblFilterSurName.AutoSize = true;
            this.lblFilterSurName.Location = new System.Drawing.Point(15, 142);
            this.lblFilterSurName.Name = "lblFilterSurName";
            this.lblFilterSurName.Size = new System.Drawing.Size(49, 13);
            this.lblFilterSurName.TabIndex = 7;
            this.lblFilterSurName.Text = "Prenume";
            // 
            // lblFilterCode
            // 
            this.lblFilterCode.AutoSize = true;
            this.lblFilterCode.Location = new System.Drawing.Point(9, 183);
            this.lblFilterCode.Name = "lblFilterCode";
            this.lblFilterCode.Size = new System.Drawing.Size(55, 13);
            this.lblFilterCode.TabIndex = 8;
            this.lblFilterCode.Text = "Cod Client";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFiltre);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 208);
            this.panel1.TabIndex = 9;
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltre.Location = new System.Drawing.Point(53, 17);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(54, 25);
            this.lblFiltre.TabIndex = 0;
            this.lblFiltre.Text = "Filtre";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(687, 2);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(89, 23);
            this.btnAddClient.TabIndex = 10;
            this.btnAddClient.Text = "Adauga Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 10);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(89, 23);
            this.btnBackToMenu.TabIndex = 11;
            this.btnBackToMenu.Text = "Spre Meniu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.BtnBackToMenu_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblFilterCode);
            this.Controls.Add(this.lblFilterSurName);
            this.Controls.Add(this.lblFilterName);
            this.Controls.Add(this.txtBoxFilterCode);
            this.Controls.Add(this.txtBoxFilterSurname);
            this.Controls.Add(this.txtBoxNameFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowClients);
            this.Controls.Add(this.dataGridClients);
            this.Controls.Add(this.panel1);
            this.Name = "ClientsForm";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.Button btnShowClients;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoxNameFilter;
        private System.Windows.Forms.TextBox txtBoxFilterSurname;
        private System.Windows.Forms.TextBox txtBoxFilterCode;
        private System.Windows.Forms.Label lblFilterName;
        private System.Windows.Forms.Label lblFilterSurName;
        private System.Windows.Forms.Label lblFilterCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}