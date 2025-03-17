namespace ct310h_project_contact
{
    partial class frmEditContact
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
            lblHeader = new Label();
            lblContactID = new Label();
            lblContactName = new Label();
            lblPhoneNumber = new Label();
            lblContactDescription = new Label();
            lblContactGroup = new Label();
            txtContactID = new TextBox();
            txtContactName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtContactDescription = new TextBox();
            chkFavorite = new CheckBox();
            cboGroup = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtContactEmail = new TextBox();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(120, 9);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(165, 25);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Add/Edit Contact";
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.Location = new Point(97, 49);
            lblContactID.Margin = new Padding(2, 0, 2, 0);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(18, 15);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "ID";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(76, 87);
            lblContactName.Margin = new Padding(2, 0, 2, 0);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(39, 15);
            lblContactName.TabIndex = 2;
            lblContactName.Text = "Name";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(27, 117);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(88, 15);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblContactDescription
            // 
            lblContactDescription.AutoSize = true;
            lblContactDescription.Location = new Point(48, 187);
            lblContactDescription.Margin = new Padding(2, 0, 2, 0);
            lblContactDescription.Name = "lblContactDescription";
            lblContactDescription.Size = new Size(67, 15);
            lblContactDescription.TabIndex = 5;
            lblContactDescription.Text = "Description";
            // 
            // lblContactGroup
            // 
            lblContactGroup.AutoSize = true;
            lblContactGroup.Location = new Point(75, 240);
            lblContactGroup.Margin = new Padding(2, 0, 2, 0);
            lblContactGroup.Name = "lblContactGroup";
            lblContactGroup.Size = new Size(40, 15);
            lblContactGroup.TabIndex = 6;
            lblContactGroup.Text = "Group";
            // 
            // txtContactID
            // 
            txtContactID.Enabled = false;
            txtContactID.Location = new Point(136, 46);
            txtContactID.Margin = new Padding(2, 2, 2, 10);
            txtContactID.Name = "txtContactID";
            txtContactID.ReadOnly = true;
            txtContactID.Size = new Size(68, 23);
            txtContactID.TabIndex = 1;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(136, 81);
            txtContactName.Margin = new Padding(2, 2, 2, 10);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(152, 23);
            txtContactName.TabIndex = 3;
            txtContactName.KeyPress += txtContactName_KeyPress;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(136, 116);
            txtPhoneNumber.Margin = new Padding(2, 2, 2, 10);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(152, 23);
            txtPhoneNumber.TabIndex = 4;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // txtContactDescription
            // 
            txtContactDescription.Location = new Point(136, 186);
            txtContactDescription.Margin = new Padding(2, 2, 2, 10);
            txtContactDescription.Multiline = true;
            txtContactDescription.Name = "txtContactDescription";
            txtContactDescription.Size = new Size(219, 41);
            txtContactDescription.TabIndex = 6;
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Location = new Point(217, 48);
            chkFavorite.Margin = new Padding(2);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(68, 19);
            chkFavorite.TabIndex = 2;
            chkFavorite.Text = "Favorite";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // cboGroup
            // 
            cboGroup.FormattingEnabled = true;
            cboGroup.Location = new Point(136, 239);
            cboGroup.Margin = new Padding(2, 2, 2, 10);
            cboGroup.Name = "cboGroup";
            cboGroup.Size = new Size(152, 23);
            cboGroup.TabIndex = 7;
            cboGroup.KeyPress += cboGroup_KeyPress;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(207, 286);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 20);
            btnSave.TabIndex = 8;
            btnSave.Text = "Add/Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(109, 286);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 20);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 152);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 15;
            label1.Text = "Email";
            // 
            // txtContactEmail
            // 
            txtContactEmail.Location = new Point(136, 151);
            txtContactEmail.Margin = new Padding(2, 2, 2, 10);
            txtContactEmail.Name = "txtContactEmail";
            txtContactEmail.Size = new Size(219, 23);
            txtContactEmail.TabIndex = 5;
            txtContactEmail.KeyPress += txtContactEmail_KeyPress;
            // 
            // frmEditContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 326);
            Controls.Add(txtContactEmail);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboGroup);
            Controls.Add(chkFavorite);
            Controls.Add(txtContactDescription);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtContactName);
            Controls.Add(txtContactID);
            Controls.Add(lblContactGroup);
            Controls.Add(lblContactDescription);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblContactName);
            Controls.Add(lblContactID);
            Controls.Add(lblHeader);
            Margin = new Padding(2);
            Name = "frmEditContact";
            Text = "Add/Edit Contact Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblContactID;
        private Label lblContactName;
        private Label lblPhoneNumber;
        private Label lblContactDescription;
        private Label lblContactGroup;
        private TextBox txtContactID;
        private TextBox txtContactName;
        private TextBox txtPhoneNumber;
        private TextBox txtContactDescription;
        private CheckBox chkFavorite;
        private ComboBox cboGroup;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private TextBox txtContactEmail;
    }
}