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
            txtMailTo.Location = new Point(97, 38);
            txtMailTo.Margin = new Padding(2);
            txtMailTo.Name = "txtMailTo";
            txtMailTo.ReadOnly = true;
            txtMailTo.Size = new Size(176, 23);
            txtMailTo.TabIndex = 0;
            // 
            // txtMailSubject
            // 
            txtMailSubject.Location = new Point(97, 69);
            txtMailSubject.Margin = new Padding(2);
            txtMailSubject.Name = "txtMailSubject";
            txtMailSubject.Size = new Size(176, 23);
            txtMailSubject.TabIndex = 1;
            txtMailSubject.KeyPress += txtMailSubject_KeyPress;
            // 
            // txtMailBody
            // 
            txtMailBody.Location = new Point(97, 105);
            txtMailBody.Margin = new Padding(2);
            txtMailBody.Multiline = true;
            txtMailBody.Name = "txtMailBody";
            txtMailBody.Size = new Size(176, 163);
            txtMailBody.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 5;
            label1.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 38);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 6;
            label2.Text = "Cc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 118);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 7;
            label3.Text = "Bcc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 69);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 105);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "Body fields";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(280, 297);
            btnSend.Margin = new Padding(2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(78, 20);
            btnSend.TabIndex = 12;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(181, 297);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 20);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(239, 5);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 12;
            label6.Text = "MAIL";
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 15;
            lstFiles.Location = new Point(363, 199);
            lstFiles.Margin = new Padding(2);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(176, 64);
            lstFiles.TabIndex = 9;
            lstFiles.KeyPress += lstFiles_KeyPress;
            // 
            // lblFiles
            // 
            lblFiles.AutoSize = true;
            lblFiles.Location = new Point(309, 199);
            lblFiles.Margin = new Padding(2, 0, 2, 0);
            lblFiles.Name = "lblFiles";
            lblFiles.Size = new Size(30, 15);
            lblFiles.TabIndex = 14;
            lblFiles.Text = "Files";
            // 
            // btnInsertFile
            // 
            btnInsertFile.Location = new Point(289, 221);
            btnInsertFile.Margin = new Padding(2);
            btnInsertFile.Name = "btnInsertFile";
            btnInsertFile.Size = new Size(50, 20);
            btnInsertFile.TabIndex = 10;
            btnInsertFile.Text = "Insert";
            btnInsertFile.UseVisualStyleBackColor = true;
            btnInsertFile.Click += btnInsertFile_Click;
            // 
            // btnDeleteFiles
            // 
            btnDeleteFiles.Location = new Point(289, 247);
            btnDeleteFiles.Margin = new Padding(2);
            btnDeleteFiles.Name = "btnDeleteFiles";
            btnDeleteFiles.Size = new Size(50, 20);
            btnDeleteFiles.TabIndex = 11;
            btnDeleteFiles.Text = "Delete";
            btnDeleteFiles.UseVisualStyleBackColor = true;
            btnDeleteFiles.Click += btnDeleteFiles_Click;
            // 
            // btnDeleteCc
            // 
            btnDeleteCc.Location = new Point(289, 85);
            btnDeleteCc.Margin = new Padding(2);
            btnDeleteCc.Name = "btnDeleteCc";
            btnDeleteCc.Size = new Size(50, 20);
            btnDeleteCc.TabIndex = 5;
            btnDeleteCc.Text = "Delete";
            btnDeleteCc.UseVisualStyleBackColor = true;
            btnDeleteCc.Click += btnDeleteCc_Click;
            // 
            // btnInsertCc
            // 
            btnInsertCc.Location = new Point(289, 60);
            btnInsertCc.Margin = new Padding(2);
            btnInsertCc.Name = "btnInsertCc";
            btnInsertCc.Size = new Size(50, 20);
            btnInsertCc.TabIndex = 4;
            btnInsertCc.Text = "Insert";
            btnInsertCc.UseVisualStyleBackColor = true;
            btnInsertCc.Click += btnInsertCc_Click;
            // 
            // lstCc
            // 
            lstCc.FormattingEnabled = true;
            lstCc.ItemHeight = 15;
            lstCc.Location = new Point(363, 38);
            lstCc.Margin = new Padding(2);
            lstCc.Name = "lstCc";
            lstCc.Size = new Size(176, 64);
            lstCc.TabIndex = 3;
            lstCc.KeyPress += lstCc_KeyPress;
            // 
            // btnDeleteBcc
            // 
            btnDeleteBcc.Location = new Point(289, 165);
            btnDeleteBcc.Margin = new Padding(2);
            btnDeleteBcc.Name = "btnDeleteBcc";
            btnDeleteBcc.Size = new Size(50, 20);
            btnDeleteBcc.TabIndex = 8;
            btnDeleteBcc.Text = "Delete";
            btnDeleteBcc.UseVisualStyleBackColor = true;
            btnDeleteBcc.Click += btnDeleteBcc_Click;
            // 
            // btnInsertBcc
            // 
            btnInsertBcc.Location = new Point(289, 140);
            btnInsertBcc.Margin = new Padding(2);
            btnInsertBcc.Name = "btnInsertBcc";
            btnInsertBcc.Size = new Size(50, 20);
            btnInsertBcc.TabIndex = 7;
            btnInsertBcc.Text = "Insert";
            btnInsertBcc.UseVisualStyleBackColor = true;
            btnInsertBcc.Click += btnInsertBcc_Click;
            // 
            // lstBcc
            // 
            lstBcc.FormattingEnabled = true;
            lstBcc.ItemHeight = 15;
            lstBcc.Location = new Point(363, 118);
            lstBcc.Margin = new Padding(2);
            lstBcc.Name = "lstBcc";
            lstBcc.Size = new Size(176, 64);
            lstBcc.TabIndex = 6;
            lstBcc.KeyPress += lstBcc_KeyPress;
            // 
            // frmMailContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 328);
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
            Margin = new Padding(2);
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