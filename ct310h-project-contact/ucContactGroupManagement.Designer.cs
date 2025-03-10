namespace ct310h_project_contact
{
    partial class ucContactGroupManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ColumnHeader colContactGroup_ID;
            lvwContactGroupManagement = new ListView();
            colContactGroup_Name = new ColumnHeader();
            colContactGroup_Description = new ColumnHeader();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnOpen = new Button();
            lvwContactFollowingGroup = new ListView();
            colContact_ID = new ColumnHeader();
            colContact_Name = new ColumnHeader();
            colContact_Email = new ColumnHeader();
            colContact_PhoneNumber = new ColumnHeader();
            colContact_Favorite = new ColumnHeader();
            colContact_Description = new ColumnHeader();
            lblGroup = new Label();
            lblContact = new Label();
            colContactGroup_ID = new ColumnHeader();
            SuspendLayout();
            // 
            // colContactGroup_ID
            // 
            colContactGroup_ID.Text = "ID";
            colContactGroup_ID.Width = 0;
            // 
            // lvwContactGroupManagement
            // 
            lvwContactGroupManagement.Columns.AddRange(new ColumnHeader[] { colContactGroup_ID, colContactGroup_Name, colContactGroup_Description });
            lvwContactGroupManagement.FullRowSelect = true;
            lvwContactGroupManagement.GridLines = true;
            lvwContactGroupManagement.Location = new Point(34, 77);
            lvwContactGroupManagement.Margin = new Padding(3, 2, 3, 2);
            lvwContactGroupManagement.MultiSelect = false;
            lvwContactGroupManagement.Name = "lvwContactGroupManagement";
            lvwContactGroupManagement.Size = new Size(480, 227);
            lvwContactGroupManagement.TabIndex = 0;
            lvwContactGroupManagement.UseCompatibleStateImageBehavior = false;
            lvwContactGroupManagement.View = View.Details;
            lvwContactGroupManagement.SelectedIndexChanged += lvwContactGroupManagement_SelectedIndexChanged;
            lvwContactGroupManagement.Enter += lvwContactGroupManagement_Enter;
            // 
            // colContactGroup_Name
            // 
            colContactGroup_Name.Text = "Name";
            colContactGroup_Name.Width = 150;
            // 
            // colContactGroup_Description
            // 
            colContactGroup_Description.Text = "Description";
            colContactGroup_Description.Width = 400;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Location = new Point(125, 314);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 25);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(228, 315);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(337, 315);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(832, 315);
            btnOpen.Margin = new Padding(3, 2, 3, 2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(82, 22);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // lvwContactFollowingGroup
            // 
            lvwContactFollowingGroup.CheckBoxes = true;
            lvwContactFollowingGroup.Columns.AddRange(new ColumnHeader[] { colContact_ID, colContact_Name, colContact_Email, colContact_PhoneNumber, colContact_Favorite, colContact_Description });
            lvwContactFollowingGroup.FullRowSelect = true;
            lvwContactFollowingGroup.GridLines = true;
            lvwContactFollowingGroup.Location = new Point(534, 77);
            lvwContactFollowingGroup.Margin = new Padding(3, 2, 3, 2);
            lvwContactFollowingGroup.MultiSelect = false;
            lvwContactFollowingGroup.Name = "lvwContactFollowingGroup";
            lvwContactFollowingGroup.Size = new Size(640, 227);
            lvwContactFollowingGroup.TabIndex = 5;
            lvwContactFollowingGroup.UseCompatibleStateImageBehavior = false;
            lvwContactFollowingGroup.View = View.Details;
            lvwContactFollowingGroup.SelectedIndexChanged += lvwContactFollowingGroup_SelectedIndexChanged;
            lvwContactFollowingGroup.Enter += lvwContactFollowingGroup_Enter;
            // 
            // colContact_ID
            // 
            colContact_ID.Text = "ID";
            colContact_ID.Width = 0;
            // 
            // colContact_Name
            // 
            colContact_Name.Text = "Name";
            colContact_Name.Width = 150;
            // 
            // colContact_Email
            // 
            colContact_Email.Text = "Email";
            colContact_Email.Width = 250;
            // 
            // colContact_PhoneNumber
            // 
            colContact_PhoneNumber.Text = "Phone Number";
            colContact_PhoneNumber.Width = 150;
            // 
            // colContact_Favorite
            // 
            colContact_Favorite.Text = "Favorite";
            colContact_Favorite.Width = 80;
            // 
            // colContact_Description
            // 
            colContact_Description.Text = "Description";
            colContact_Description.Width = 150;
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGroup.Location = new Point(34, 18);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(115, 45);
            lblGroup.TabIndex = 6;
            lblGroup.Text = "Group";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContact.Location = new Point(534, 18);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(135, 45);
            lblContact.TabIndex = 7;
            lblContact.Text = "Contact";
            // 
            // ucContactGroupManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblContact);
            Controls.Add(lblGroup);
            Controls.Add(lvwContactFollowingGroup);
            Controls.Add(btnOpen);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lvwContactGroupManagement);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucContactGroupManagement";
            Size = new Size(1192, 352);
            Load += ucContactGroupManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvwContactGroupManagement;
        private ColumnHeader colContactGroup_Name;
        private ColumnHeader colContactGroup_Description;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnOpen;
        private ListView lvwContactFollowingGroup;
        private ColumnHeader colContact_ID;
        private ColumnHeader colContact_Name;
        private ColumnHeader colContact_Email;
        private ColumnHeader colContact_PhoneNumber;
        private ColumnHeader colContact_Favorite;
        private ColumnHeader colContact_Description;
        private Label lblGroup;
        private Label lblContact;
    }
}
