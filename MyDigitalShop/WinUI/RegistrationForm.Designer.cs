namespace WinUI
{
    partial class RegistrationForm
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
            this.lblGoToLogin = new System.Windows.Forms.Label();
            this.boxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblPasswordConfirmation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGoToLogin
            // 
            this.lblGoToLogin.AutoSize = true;
            this.lblGoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoToLogin.ForeColor = System.Drawing.Color.White;
            this.lblGoToLogin.Location = new System.Drawing.Point(119, 242);
            this.lblGoToLogin.Name = "lblGoToLogin";
            this.lblGoToLogin.Size = new System.Drawing.Size(173, 12);
            this.lblGoToLogin.TabIndex = 7;
            this.lblGoToLogin.Text = "Already have an account? Log in!";
            this.lblGoToLogin.Click += new System.EventHandler(this.LblGoToLogin_Click);
            this.lblGoToLogin.MouseLeave += new System.EventHandler(this.LblGoToLogin_MouseLeave);
            this.lblGoToLogin.MouseHover += new System.EventHandler(this.LblGoToLogin_MouseHover);
            // 
            // boxUserName
            // 
            this.boxUserName.ForeColor = System.Drawing.Color.Gray;
            this.boxUserName.Location = new System.Drawing.Point(122, 90);
            this.boxUserName.Name = "boxUserName";
            this.boxUserName.Size = new System.Drawing.Size(171, 20);
            this.boxUserName.TabIndex = 8;
            this.boxUserName.TextChanged += new System.EventHandler(this.BoxUserName_TextChanged);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxPassword.Location = new System.Drawing.Point(122, 123);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(171, 20);
            this.txtBoxPassword.TabIndex = 9;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxPasswordConfirmation
            // 
            this.txtBoxPasswordConfirmation.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxPasswordConfirmation.Location = new System.Drawing.Point(121, 152);
            this.txtBoxPasswordConfirmation.Name = "txtBoxPasswordConfirmation";
            this.txtBoxPasswordConfirmation.Size = new System.Drawing.Size(171, 20);
            this.txtBoxPasswordConfirmation.TabIndex = 10;
            this.txtBoxPasswordConfirmation.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(62, 178);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(289, 61);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Inregistreaza-te!";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.btnRegister.MouseLeave += new System.EventHandler(this.BtnRegister_MouseLeave);
            this.btnRegister.MouseHover += new System.EventHandler(this.BtnRegister_MouseHover);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(36, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 18);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "UserName";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.ForeColor = System.Drawing.Color.White;
            this.lblParola.Location = new System.Drawing.Point(64, 125);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(51, 18);
            this.lblParola.TabIndex = 13;
            this.lblParola.Text = "Parola";
            // 
            // lblPasswordConfirmation
            // 
            this.lblPasswordConfirmation.AutoSize = true;
            this.lblPasswordConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConfirmation.ForeColor = System.Drawing.Color.White;
            this.lblPasswordConfirmation.Location = new System.Drawing.Point(0, 154);
            this.lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            this.lblPasswordConfirmation.Size = new System.Drawing.Size(116, 18);
            this.lblPasswordConfirmation.TabIndex = 14;
            this.lblPasswordConfirmation.Text = "Confirma Parola";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 71);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER REGISTER";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(413, 263);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPasswordConfirmation);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxPasswordConfirmation);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.boxUserName);
            this.Controls.Add(this.lblGoToLogin);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoToLogin;
        private System.Windows.Forms.TextBox boxUserName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxPasswordConfirmation;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblPasswordConfirmation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}