namespace ct310h_project_contact
{
    partial class frmMailContact
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
            txtMailTo = new TextBox();
            txtMailSubject = new TextBox();
            txtMailBody = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSend = new Button();
            btnCancel = new Button();
            label6 = new Label();
            lstFiles = new ListBox();
            lblFiles = new Label();
            btnInsertFile = new Button();
            btnDeleteFiles = new Button();
            btnDeleteCc = new Button();
            btnInsertCc = new Button();
            lstCc = new ListBox();
            btnDeleteBcc = new Button();
            btnInsertBcc = new Button();
            lstBcc = new ListBox();
            SuspendLayout();
            // 
            // txtMailTo
            // 
            txtMailTo.Location = new Point(138, 63);
            txtMailTo.Name = "txtMailTo";
            txtMailTo.ReadOnly = true;
            txtMailTo.Size = new Size(249, 31);
            txtMailTo.TabIndex = 0;
            // 
            // txtMailSubject
            // 
            txtMailSubject.Location = new Point(138, 115);
            txtMailSubject.Name = "txtMailSubject";
            txtMailSubject.Size = new Size(249, 31);
            txtMailSubject.TabIndex = 2;
            // 
            // txtMailBody
            // 
            txtMailBody.Location = new Point(138, 175);
            txtMailBody.Multiline = true;
            txtMailBody.Name = "txtMailBody";
            txtMailBody.Size = new Size(249, 269);
            txtMailBody.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 66);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 5;
            label1.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 69);
            label2.Name = "label2";
            label2.Size = new Size(31, 25);
            label2.TabIndex = 6;
            label2.Text = "Cc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 202);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 7;
            label3.Text = "Bcc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 118);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 8;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 178);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 9;
            label5.Text = "Body fields";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(266, 465);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(429, 465);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(342, 9);
            label6.Name = "label6";
            label6.Size = new Size(87, 38);
            label6.TabIndex = 12;
            label6.Text = "MAIL";
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 25;
            lstFiles.Location = new Point(519, 332);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(249, 104);
            lstFiles.TabIndex = 6;
            // 
            // lblFiles
            // 
            lblFiles.AutoSize = true;
            lblFiles.Location = new Point(413, 332);
            lblFiles.Name = "lblFiles";
            lblFiles.Size = new Size(46, 25);
            lblFiles.TabIndex = 14;
            lblFiles.Text = "Files";
            // 
            // btnInsertFile
            // 
            btnInsertFile.Location = new Point(413, 369);
            btnInsertFile.Name = "btnInsertFile";
            btnInsertFile.Size = new Size(71, 34);
            btnInsertFile.TabIndex = 7;
            btnInsertFile.Text = "Insert";
            btnInsertFile.UseVisualStyleBackColor = true;
            btnInsertFile.Click += btnInsertFile_Click;
            // 
            // btnDeleteFiles
            // 
            btnDeleteFiles.Location = new Point(413, 411);
            btnDeleteFiles.Name = "btnDeleteFiles";
            btnDeleteFiles.Size = new Size(71, 34);
            btnDeleteFiles.TabIndex = 8;
            btnDeleteFiles.Text = "Delete";
            btnDeleteFiles.UseVisualStyleBackColor = true;
            btnDeleteFiles.Click += btnDeleteFiles_Click;
            // 
            // btnDeleteCc
            // 
            btnDeleteCc.Location = new Point(413, 142);
            btnDeleteCc.Name = "btnDeleteCc";
            btnDeleteCc.Size = new Size(71, 34);
            btnDeleteCc.TabIndex = 17;
            btnDeleteCc.Text = "Delete";
            btnDeleteCc.UseVisualStyleBackColor = true;
            btnDeleteCc.Click += btnDeleteCc_Click;
            // 
            // btnInsertCc
            // 
            btnInsertCc.Location = new Point(413, 100);
            btnInsertCc.Name = "btnInsertCc";
            btnInsertCc.Size = new Size(71, 34);
            btnInsertCc.TabIndex = 16;
            btnInsertCc.Text = "Insert";
            btnInsertCc.UseVisualStyleBackColor = true;
            btnInsertCc.Click += btnInsertCc_Click;
            // 
            // lstCc
            // 
            lstCc.FormattingEnabled = true;
            lstCc.ItemHeight = 25;
            lstCc.Location = new Point(519, 63);
            lstCc.Name = "lstCc";
            lstCc.Size = new Size(249, 104);
            lstCc.TabIndex = 15;
            // 
            // btnDeleteBcc
            // 
            btnDeleteBcc.Location = new Point(413, 275);
            btnDeleteBcc.Name = "btnDeleteBcc";
            btnDeleteBcc.Size = new Size(71, 34);
            btnDeleteBcc.TabIndex = 20;
            btnDeleteBcc.Text = "Delete";
            btnDeleteBcc.UseVisualStyleBackColor = true;
            btnDeleteBcc.Click += btnDeleteBcc_Click;
            // 
            // btnInsertBcc
            // 
            btnInsertBcc.Location = new Point(413, 233);
            btnInsertBcc.Name = "btnInsertBcc";
            btnInsertBcc.Size = new Size(71, 34);
            btnInsertBcc.TabIndex = 19;
            btnInsertBcc.Text = "Insert";
            btnInsertBcc.UseVisualStyleBackColor = true;
            btnInsertBcc.Click += btnInsertBcc_Click;
            // 
            // lstBcc
            // 
            lstBcc.FormattingEnabled = true;
            lstBcc.ItemHeight = 25;
            lstBcc.Location = new Point(519, 196);
            lstBcc.Name = "lstBcc";
            lstBcc.Size = new Size(249, 104);
            lstBcc.TabIndex = 18;
            // 
            // frmMailContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 511);
            Controls.Add(btnDeleteBcc);
            Controls.Add(btnInsertBcc);
            Controls.Add(lstBcc);
            Controls.Add(btnDeleteCc);
            Controls.Add(btnInsertCc);
            Controls.Add(lstCc);
            Controls.Add(btnDeleteFiles);
            Controls.Add(btnInsertFile);
            Controls.Add(lblFiles);
            Controls.Add(lstFiles);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMailBody);
            Controls.Add(txtMailSubject);
            Controls.Add(txtMailTo);
            Name = "frmMailContact";
            Text = "frmMailContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMailTo;
        private TextBox txtMailSubject;
        private TextBox txtMailBody;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSend;
        private Button btnCancel;
        private Label label6;
        private ListBox lstFiles;
        private Label lblFiles;
        private Button btnInsertFile;
        private Button btnDeleteFiles;
        private Button btnDeleteCc;
        private Button btnInsertCc;
        private ListBox lstCc;
        private Button btnDeleteBcc;
        private Button btnInsertBcc;
        private ListBox lstBcc;
    }
}