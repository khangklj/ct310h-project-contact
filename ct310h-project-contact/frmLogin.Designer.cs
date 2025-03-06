using System.Windows.Forms;

namespace ct310h_project_contact
{
    partial class frmLogin
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
            btnLogin = new Button();
            label1 = new Label();
            btnExit = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            llbCreateAccount = new LinkLabel();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(389, 254);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 22);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 58);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(236, 253);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 129);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 175);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(342, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(146, 23);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(342, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(146, 23);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // llbCreateAccount
            // 
            llbCreateAccount.AutoSize = true;
            llbCreateAccount.Location = new Point(320, 291);
            llbCreateAccount.Name = "llbCreateAccount";
            llbCreateAccount.Size = new Size(89, 15);
            llbCreateAccount.TabIndex = 9;
            llbCreateAccount.TabStop = true;
            llbCreateAccount.Text = "Create Account";
            llbCreateAccount.LinkClicked += llbCreateAccount_Click;
            
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(llbCreateAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "frmLogin";
            FormClosed += frmLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Label label1;
        private Button btnExit;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private LinkLabel llbCreateAccount;
    }
}