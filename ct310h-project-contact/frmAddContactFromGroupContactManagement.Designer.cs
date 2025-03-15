namespace ct310h_project_contact
{
    partial class frmAddContactFromGroupContactManagement
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
            lblSelectContact = new Label();
            btnAddContact = new Button();
            btnCancel = new Button();
            lstContact = new ListBox();
            SuspendLayout();
            // 
            // lblSelectContact
            // 
            lblSelectContact.AutoSize = true;
            lblSelectContact.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectContact.Location = new Point(31, 39);
            lblSelectContact.Name = "lblSelectContact";
            lblSelectContact.Size = new Size(359, 25);
            lblSelectContact.TabIndex = 0;
            lblSelectContact.Text = "Please select contact(s) to add into group";
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(76, 213);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(101, 33);
            btnAddContact.TabIndex = 1;
            btnAddContact.Text = "Add";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(239, 213);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 33);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lstContact
            // 
            lstContact.FormattingEnabled = true;
            lstContact.ItemHeight = 15;
            lstContact.Location = new Point(31, 84);
            lstContact.Name = "lstContact";
            lstContact.Size = new Size(359, 94);
            lstContact.TabIndex = 4;
            lstContact.SelectedIndexChanged += lstContact_SelectedIndexChanged;
            // 
            // frmAddContactFromGroupContactManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 311);
            Controls.Add(lstContact);
            Controls.Add(btnCancel);
            Controls.Add(btnAddContact);
            Controls.Add(lblSelectContact);
            Name = "frmAddContactFromGroupContactManagement";
            Text = "Add Contact From Group Contact Management";
            Load += frmAddContactFromGroupContactManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectContact;
        private Button btnAddContact;
        private Button btnCancel;
        private ListBox lstContact;
    }
}