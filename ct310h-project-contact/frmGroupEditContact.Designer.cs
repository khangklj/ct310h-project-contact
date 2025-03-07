namespace ct310h_project_contact
{
    partial class frmGroupEditContact
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
            lblContactGropManagement.Location = new Point(95, 29);
            lblContactGropManagement.Name = "lblContactGropManagement";
            lblContactGropManagement.Size = new Size(267, 38);
            lblContactGropManagement.TabIndex = 0;
            lblContactGropManagement.Text = "Edit Contact Group";
            // 
            // lblContactGroup_ID
            // 
            lblContactGroup_ID.AutoSize = true;
            lblContactGroup_ID.Location = new Point(51, 97);
            lblContactGroup_ID.Name = "lblContactGroup_ID";
            lblContactGroup_ID.Size = new Size(27, 20);
            lblContactGroup_ID.TabIndex = 1;
            lblContactGroup_ID.Text = "ID:";
            // 
            // lblContactGroup_Name
            // 
            lblContactGroup_Name.AutoSize = true;
            lblContactGroup_Name.Location = new Point(51, 132);
            lblContactGroup_Name.Name = "lblContactGroup_Name";
            lblContactGroup_Name.Size = new Size(52, 20);
            lblContactGroup_Name.TabIndex = 2;
            lblContactGroup_Name.Text = "Name:";
            // 
            // lblContactGroup_Description
            // 
            lblContactGroup_Description.AutoSize = true;
            lblContactGroup_Description.Location = new Point(51, 176);
            lblContactGroup_Description.Name = "lblContactGroup_Description";
            lblContactGroup_Description.Size = new Size(88, 20);
            lblContactGroup_Description.TabIndex = 3;
            lblContactGroup_Description.Text = "Description:";
            // 
            // rtxContactGroup_Description
            // 
            rtxContactGroup_Description.Location = new Point(174, 173);
            rtxContactGroup_Description.Name = "rtxContactGroup_Description";
            rtxContactGroup_Description.Size = new Size(230, 82);
            rtxContactGroup_Description.TabIndex = 4;
            rtxContactGroup_Description.Text = "";
            // 
            // txtContactGroup_Name
            // 
            txtContactGroup_Name.Location = new Point(174, 129);
            txtContactGroup_Name.Name = "txtContactGroup_Name";
            txtContactGroup_Name.Size = new Size(125, 27);
            txtContactGroup_Name.TabIndex = 5;
            // 
            // txtContactGroup_ID
            // 
            txtContactGroup_ID.Location = new Point(174, 94);
            txtContactGroup_ID.Name = "txtContactGroup_ID";
            txtContactGroup_ID.ReadOnly = true;
            txtContactGroup_ID.Size = new Size(125, 27);
            txtContactGroup_ID.TabIndex = 6;
            // 
            // btnAddSave
            // 
            btnAddSave.Location = new Point(90, 287);
            btnAddSave.Name = "btnAddSave";
            btnAddSave.Size = new Size(94, 29);
            btnAddSave.TabIndex = 7;
            btnAddSave.Text = "Add/Save";
            btnAddSave.UseVisualStyleBackColor = true;
            btnAddSave.Click += btnAddSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 287);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmEditGroupContactcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 343);
            Controls.Add(btnCancel);
            Controls.Add(btnAddSave);
            Controls.Add(txtContactGroup_ID);
            Controls.Add(txtContactGroup_Name);
            Controls.Add(rtxContactGroup_Description);
            Controls.Add(lblContactGroup_Description);
            Controls.Add(lblContactGroup_Name);
            Controls.Add(lblContactGroup_ID);
            Controls.Add(lblContactGropManagement);
            Name = "frmEditGroupContactcs";
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