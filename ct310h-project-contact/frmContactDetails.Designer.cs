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
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
            label1.TabIndex = 0;
            label1.Text = "Contact Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 133);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 184);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 286);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 376);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 5;
            label6.Text = "Group";
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Enabled = false;
            chkFavorite.Location = new Point(303, 81);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(100, 29);
            chkFavorite.TabIndex = 6;
            chkFavorite.Text = "Favorite";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // txtContactID
            // 
            txtContactID.Location = new Point(184, 79);
            txtContactID.Name = "txtContactID";
            txtContactID.ReadOnly = true;
            txtContactID.Size = new Size(93, 31);
            txtContactID.TabIndex = 7;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(184, 130);
            txtContactName.Name = "txtContactName";
            txtContactName.ReadOnly = true;
            txtContactName.Size = new Size(150, 31);
            txtContactName.TabIndex = 8;
            // 
            // txtContactPhoneNumber
            // 
            txtContactPhoneNumber.Location = new Point(184, 181);
            txtContactPhoneNumber.Name = "txtContactPhoneNumber";
            txtContactPhoneNumber.ReadOnly = true;
            txtContactPhoneNumber.Size = new Size(150, 31);
            txtContactPhoneNumber.TabIndex = 9;
            // 
            // txtContactDescription
            // 
            txtContactDescription.Location = new Point(184, 283);
            txtContactDescription.Multiline = true;
            txtContactDescription.Name = "txtContactDescription";
            txtContactDescription.ReadOnly = true;
            txtContactDescription.Size = new Size(219, 74);
            txtContactDescription.TabIndex = 11;
            // 
            // txtContactGroup
            // 
            txtContactGroup.Location = new Point(184, 373);
            txtContactGroup.Name = "txtContactGroup";
            txtContactGroup.ReadOnly = true;
            txtContactGroup.Size = new Size(150, 31);
            txtContactGroup.TabIndex = 12;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(233, 426);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMailTo
            // 
            btnMailTo.Location = new Point(84, 426);
            btnMailTo.Name = "btnMailTo";
            btnMailTo.Size = new Size(112, 34);
            btnMailTo.TabIndex = 13;
            btnMailTo.Text = "Mail To";
            btnMailTo.UseVisualStyleBackColor = true;
            btnMailTo.Click += btnMailTo_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(219, 31);
            txtEmail.TabIndex = 10;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 235);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // frmContactDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 494);
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