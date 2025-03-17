namespace ct310h_project_contact
{
    partial class frmEmailInput
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
        private TextBox txtEmailInput;
        private Button btnOK;
        private Button btnCancel;
        private Label lblPrompt;


        private void InitializeComponent()
        {
            txtEmailInput = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            lblPrompt = new Label();
            SuspendLayout();
            // 
            // txtEmailInput
            // 
            txtEmailInput.Location = new Point(20, 45);
            txtEmailInput.Name = "txtEmailInput";
            txtEmailInput.Size = new Size(350, 23);
            txtEmailInput.TabIndex = 1;
            txtEmailInput.KeyPress += txtEmailInput_KeyPress;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(295, 92);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 34);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(202, 92);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(20, 18);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(69, 15);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter Email:";
            // 
            // frmEmailInput
            // 
            ClientSize = new Size(400, 150);
            Controls.Add(lblPrompt);
            Controls.Add(txtEmailInput);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmailInput";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Enter Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}