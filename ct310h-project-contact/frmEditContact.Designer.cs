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
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(86, 19);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(243, 38);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Add/Edit Contact";
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.Location = new Point(39, 81);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(30, 25);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "ID";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(39, 126);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(59, 25);
            lblContactName.TabIndex = 2;
            lblContactName.Text = "Name";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(39, 171);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(132, 25);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblContactDescription
            // 
            lblContactDescription.AutoSize = true;
            lblContactDescription.Location = new Point(39, 216);
            lblContactDescription.Name = "lblContactDescription";
            lblContactDescription.Size = new Size(102, 25);
            lblContactDescription.TabIndex = 5;
            lblContactDescription.Text = "Description";
            // 
            // lblContactGroup
            // 
            lblContactGroup.AutoSize = true;
            lblContactGroup.Location = new Point(39, 278);
            lblContactGroup.Name = "lblContactGroup";
            lblContactGroup.Size = new Size(62, 25);
            lblContactGroup.TabIndex = 6;
            lblContactGroup.Text = "Group";
            // 
            // txtContactID
            // 
            txtContactID.Enabled = false;
            txtContactID.Location = new Point(177, 78);
            txtContactID.Name = "txtContactID";
            txtContactID.Size = new Size(95, 31);
            txtContactID.TabIndex = 7;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(177, 123);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(216, 31);
            txtContactName.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(177, 168);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(216, 31);
            txtPhoneNumber.TabIndex = 9;
            // 
            // txtContactDescription
            // 
            txtContactDescription.Location = new Point(177, 213);
            txtContactDescription.Multiline = true;
            txtContactDescription.Name = "txtContactDescription";
            txtContactDescription.Size = new Size(216, 46);
            txtContactDescription.TabIndex = 10;
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Location = new Point(293, 81);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(100, 29);
            chkFavorite.TabIndex = 11;
            chkFavorite.Text = "Favorite";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // cboGroup
            // 
            cboGroup.FormattingEnabled = true;
            cboGroup.Location = new Point(177, 275);
            cboGroup.Name = "cboGroup";
            cboGroup.Size = new Size(216, 33);
            cboGroup.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(86, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Add/Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(235, 334);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmEditContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 387);
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
    }
}