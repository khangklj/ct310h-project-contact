namespace ct310h_project_contact
{
    partial class frmContactDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chkFavorite = new CheckBox();
            txtContactID = new TextBox();
            txtContactName = new TextBox();
            txtContactPhoneNumber = new TextBox();
            txtContactDescription = new TextBox();
            txtContactGroup = new TextBox();
            btnClose = new Button();
            btnMailTo = new Button();
            txtEmail = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Contact Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 49);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 110);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 172);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 226);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "Group";
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Enabled = false;
            chkFavorite.Location = new Point(212, 49);
            chkFavorite.Margin = new Padding(2, 2, 2, 2);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(68, 19);
            chkFavorite.TabIndex = 6;
            chkFavorite.Text = "Favorite";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // txtContactID
            // 
            txtContactID.Location = new Point(129, 47);
            txtContactID.Margin = new Padding(2, 2, 2, 2);
            txtContactID.Name = "txtContactID";
            txtContactID.ReadOnly = true;
            txtContactID.Size = new Size(66, 23);
            txtContactID.TabIndex = 7;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(129, 78);
            txtContactName.Margin = new Padding(2, 2, 2, 2);
            txtContactName.Name = "txtContactName";
            txtContactName.ReadOnly = true;
            txtContactName.Size = new Size(106, 23);
            txtContactName.TabIndex = 8;
            // 
            // txtContactPhoneNumber
            // 
            txtContactPhoneNumber.Location = new Point(129, 109);
            txtContactPhoneNumber.Margin = new Padding(2, 2, 2, 2);
            txtContactPhoneNumber.Name = "txtContactPhoneNumber";
            txtContactPhoneNumber.ReadOnly = true;
            txtContactPhoneNumber.Size = new Size(106, 23);
            txtContactPhoneNumber.TabIndex = 9;
            // 
            // txtContactDescription
            // 
            txtContactDescription.Location = new Point(129, 170);
            txtContactDescription.Margin = new Padding(2, 2, 2, 2);
            txtContactDescription.Multiline = true;
            txtContactDescription.Name = "txtContactDescription";
            txtContactDescription.ReadOnly = true;
            txtContactDescription.Size = new Size(154, 46);
            txtContactDescription.TabIndex = 11;
            // 
            // txtContactGroup
            // 
            txtContactGroup.Location = new Point(129, 224);
            txtContactGroup.Margin = new Padding(2, 2, 2, 2);
            txtContactGroup.Name = "txtContactGroup";
            txtContactGroup.ReadOnly = true;
            txtContactGroup.Size = new Size(106, 23);
            txtContactGroup.TabIndex = 12;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(55, 265);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(78, 20);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMailTo
            // 
            btnMailTo.Location = new Point(157, 265);
            btnMailTo.Margin = new Padding(2, 2, 2, 2);
            btnMailTo.Name = "btnMailTo";
            btnMailTo.Size = new Size(78, 20);
            btnMailTo.TabIndex = 13;
            btnMailTo.Text = "Mail To";
            btnMailTo.UseVisualStyleBackColor = true;
            btnMailTo.Click += btnMailTo_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 139);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 10;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 141);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // frmContactDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 296);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(btnMailTo);
            Controls.Add(btnClose);
            Controls.Add(txtContactGroup);
            Controls.Add(txtContactDescription);
            Controls.Add(txtContactPhoneNumber);
            Controls.Add(txtContactName);
            Controls.Add(txtContactID);
            Controls.Add(chkFavorite);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmContactDetails";
            Text = "Contact details";
            Load += frmContactDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chkFavorite;
        private TextBox txtContactID;
        private TextBox txtContactName;
        private TextBox txtContactPhoneNumber;
        private TextBox txtContactDescription;
        private TextBox txtContactGroup;
        private Button btnClose;
        private Button btnMailTo;
        private TextBox txtEmail;
        private Label label7;
    }
}