namespace WinUI
{
    partial class LoginForm
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblGoToRegister = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(75, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(93, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Logare in aplicatie";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(69, 21);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(111, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(16, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Utilizator";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblUserPassword);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 88);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(69, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(111, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(16, 55);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(37, 13);
            this.lblUserPassword.TabIndex = 3;
            this.lblUserPassword.Text = "Parola";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Location = new System.Drawing.Point(2, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 47);
            this.panel2.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(69, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Logare";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblGoToRegister
            // 
            this.lblGoToRegister.AutoSize = true;
            this.lblGoToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoToRegister.ForeColor = System.Drawing.Color.Black;
            this.lblGoToRegister.Location = new System.Drawing.Point(41, 165);
            this.lblGoToRegister.Name = "lblGoToRegister";
            this.lblGoToRegister.Size = new System.Drawing.Size(162, 12);
            this.lblGoToRegister.TabIndex = 6;
            this.lblGoToRegister.Text = "Don\'t have an accout? Sing up!";
            this.lblGoToRegister.Click += new System.EventHandler(this.LblGoToRegister_Click);
            this.lblGoToRegister.MouseLeave += new System.EventHandler(this.LblGoToRegister_MouseLeave);
            this.lblGoToRegister.MouseHover += new System.EventHandler(this.LblGoToRegister_MouseHover);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 186);
            this.Controls.Add(this.lblGoToRegister);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Logare aplicatie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblGoToRegister;
    }
}

