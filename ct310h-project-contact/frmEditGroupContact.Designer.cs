namespace ct310h_project_contact
{
    partial class frmEditGroupContact
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
            lblContactGropManagement = new Label();
            lblContactGroup_ID = new Label();
            lblContactGroup_Name = new Label();
            lblContactGroup_Description = new Label();
            rtxContactGroup_Description = new RichTextBox();
            txtContactGroup_Name = new TextBox();
            txtContactGroup_ID = new TextBox();
            btnAddSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblContactGropManagement
            // 
            lblContactGropManagement.AutoSize = true;
            lblContactGropManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactGropManagement.Location = new Point(106, 19);
            lblContactGropManagement.Name = "lblContactGropManagement";
            lblContactGropManagement.Size = new Size(212, 30);
            lblContactGropManagement.TabIndex = 0;
            lblContactGropManagement.Text = "Edit Contact Group";
            // 
            // lblContactGroup_ID
            // 
            lblContactGroup_ID.AutoSize = true;
            lblContactGroup_ID.Location = new Point(107, 70);
            lblContactGroup_ID.Name = "lblContactGroup_ID";
            lblContactGroup_ID.Size = new Size(18, 15);
            lblContactGroup_ID.TabIndex = 1;
            lblContactGroup_ID.Text = "ID";
            // 
            // lblContactGroup_Name
            // 
            lblContactGroup_Name.AutoSize = true;
            lblContactGroup_Name.Location = new Point(86, 105);
            lblContactGroup_Name.Name = "lblContactGroup_Name";
            lblContactGroup_Name.Size = new Size(39, 15);
            lblContactGroup_Name.TabIndex = 2;
            lblContactGroup_Name.Text = "Name";
            // 
            // lblContactGroup_Description
            // 
            lblContactGroup_Description.AutoSize = true;
            lblContactGroup_Description.Location = new Point(58, 140);
            lblContactGroup_Description.Name = "lblContactGroup_Description";
            lblContactGroup_Description.Size = new Size(67, 15);
            lblContactGroup_Description.TabIndex = 3;
            lblContactGroup_Description.Text = "Description";
            // 
            // rtxContactGroup_Description
            // 
            rtxContactGroup_Description.BorderStyle = BorderStyle.FixedSingle;
            rtxContactGroup_Description.Location = new Point(152, 140);
            rtxContactGroup_Description.Margin = new Padding(3, 2, 3, 10);
            rtxContactGroup_Description.Name = "rtxContactGroup_Description";
            rtxContactGroup_Description.Size = new Size(202, 62);
            rtxContactGroup_Description.TabIndex = 2;
            rtxContactGroup_Description.Text = "";
            // 
            // txtContactGroup_Name
            // 
            txtContactGroup_Name.Location = new Point(152, 105);
            txtContactGroup_Name.Margin = new Padding(3, 2, 3, 10);
            txtContactGroup_Name.Name = "txtContactGroup_Name";
            txtContactGroup_Name.Size = new Size(110, 23);
            txtContactGroup_Name.TabIndex = 1;
            txtContactGroup_Name.KeyPress += txtContactGroup_Name_KeyPress;
            // 
            // txtContactGroup_ID
            // 
            txtContactGroup_ID.Location = new Point(152, 70);
            txtContactGroup_ID.Margin = new Padding(3, 2, 3, 10);
            txtContactGroup_ID.Name = "txtContactGroup_ID";
            txtContactGroup_ID.ReadOnly = true;
            txtContactGroup_ID.Size = new Size(110, 23);
            txtContactGroup_ID.TabIndex = 0;
            // 
            // btnAddSave
            // 
            btnAddSave.Location = new Point(213, 224);
            btnAddSave.Margin = new Padding(3, 2, 3, 2);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(82, 22);
            btnAddSave.TabIndex = 3;
            btnAddSave.Text = "Add/Save";
            btnAddSave.UseVisualStyleBackColor = true;
            btnAddSave.Click += btnAddSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(107, 224);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmEditGroupContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 260);
            Controls.Add(btnCancel);
            Controls.Add(btnAddSave);
            Controls.Add(txtContactGroup_ID);
            Controls.Add(txtContactGroup_Name);
            Controls.Add(rtxContactGroup_Description);
            Controls.Add(lblContactGroup_Description);
            Controls.Add(lblContactGroup_Name);
            Controls.Add(lblContactGroup_ID);
            Controls.Add(lblContactGropManagement);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmEditGroupContact";
            Text = "frmEditGroupContactcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContactGropManagement;
        private Label lblContactGroup_ID;
        private Label lblContactGroup_Name;
        private Label lblContactGroup_Description;
        private RichTextBox rtxContactGroup_Description;
        private TextBox txtContactGroup_Name;
        private TextBox txtContactGroup_ID;
        private Button btnAddSave;
        private Button btnCancel;
    }
}