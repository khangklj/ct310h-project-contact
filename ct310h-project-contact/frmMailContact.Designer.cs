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
            txtMailCc = new TextBox();
            txtMailBcc = new TextBox();
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
            SuspendLayout();
            // 
            // txtMailTo
            // 
            txtMailTo.Location = new Point(142, 80);
            txtMailTo.Name = "txtMailTo";
            txtMailTo.ReadOnly = true;
            txtMailTo.Size = new Size(249, 31);
            txtMailTo.TabIndex = 0;
            // 
            // txtMailCc
            // 
            txtMailCc.Location = new Point(142, 126);
            txtMailCc.Name = "txtMailCc";
            txtMailCc.Size = new Size(249, 31);
            txtMailCc.TabIndex = 1;
            // 
            // txtMailBcc
            // 
            txtMailBcc.Location = new Point(142, 172);
            txtMailBcc.Name = "txtMailBcc";
            txtMailBcc.Size = new Size(249, 31);
            txtMailBcc.TabIndex = 2;
            // 
            // txtMailSubject
            // 
            txtMailSubject.Location = new Point(142, 218);
            txtMailSubject.Name = "txtMailSubject";
            txtMailSubject.Size = new Size(249, 31);
            txtMailSubject.TabIndex = 3;
            // 
            // txtMailBody
            // 
            txtMailBody.Location = new Point(142, 264);
            txtMailBody.Multiline = true;
            txtMailBody.Name = "txtMailBody";
            txtMailBody.Size = new Size(249, 116);
            txtMailBody.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 83);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 5;
            label1.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 129);
            label2.Name = "label2";
            label2.Size = new Size(31, 25);
            label2.TabIndex = 6;
            label2.Text = "Cc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 175);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 7;
            label3.Text = "Bcc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 221);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 8;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 267);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 9;
            label5.Text = "Body fields";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(65, 404);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(152, 20);
            label6.Name = "label6";
            label6.Size = new Size(87, 38);
            label6.TabIndex = 12;
            label6.Text = "MAIL";
            // 
            // frmMailContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
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
            Controls.Add(txtMailBcc);
            Controls.Add(txtMailCc);
            Controls.Add(txtMailTo);
            Name = "frmMailContact";
            Text = "frmMailContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMailTo;
        private TextBox txtMailCc;
        private TextBox txtMailBcc;
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
    }
}