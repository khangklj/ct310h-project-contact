namespace ct310h_project_contact
{
    partial class frmTestDatabase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTestConnection = new Button();
            btnTestAuth = new Button();
            SuspendLayout();
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(378, 256);
            btnTestConnection.Margin = new Padding(3, 4, 3, 4);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(155, 31);
            btnTestConnection.TabIndex = 0;
            btnTestConnection.Text = "Test connection";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTest_Click;
            // 
            // btnTestAuth
            // 
            btnTestAuth.Location = new Point(409, 330);
            btnTestAuth.Name = "btnTestAuth";
            btnTestAuth.Size = new Size(94, 29);
            btnTestAuth.TabIndex = 1;
            btnTestAuth.Text = "Test auth";
            btnTestAuth.UseVisualStyleBackColor = true;
            btnTestAuth.Click += btnTestAuth_Click;
            // 
            // frmTestDatabase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnTestAuth);
            Controls.Add(btnTestConnection);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTestDatabase";
            Text = "Form1";
            FormClosed += frmTestDatabase_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTestConnection;
        private Button btnTestAuth;
    }
}
