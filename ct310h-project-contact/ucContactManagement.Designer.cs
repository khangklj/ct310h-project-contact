namespace ct310h_project_contact
{
    partial class ucContactManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvContacts = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colMail = new DataGridViewTextBoxColumn();
            colPhoneNumber = new DataGridViewTextBoxColumn();
            colFavorite = new DataGridViewCheckBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnOpen = new Button();
            lblPageNumber = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToAddRows = false;
            dgvContacts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dgvContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvContacts.BackgroundColor = Color.White;
            dgvContacts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Columns.AddRange(new DataGridViewColumn[] { colName, colMail, colPhoneNumber, colFavorite, colID });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvContacts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvContacts.EnableHeadersVisualStyles = false;
            dgvContacts.GridColor = Color.LightGray;
            dgvContacts.Location = new Point(12, 69);
            dgvContacts.Margin = new Padding(2);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.ReadOnly = true;
            dgvContacts.RowHeadersWidth = 62;
            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContacts.Size = new Size(640, 208);
            dgvContacts.TabIndex = 0;
            dgvContacts.SelectionChanged += dgvContacts_SelectionChanged;
            dgvContacts.KeyDown += dgvContacts_KeyDown;
            // 
            // colName
            // 
            colName.DataPropertyName = "contact_name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 150;
            // 
            // colMail
            // 
            colMail.DataPropertyName = "contact_email";
            colMail.HeaderText = "Mail";
            colMail.Name = "colMail";
            colMail.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.DataPropertyName = "contact_phoneNumber";
            colPhoneNumber.HeaderText = "Phone Number";
            colPhoneNumber.MinimumWidth = 8;
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.ReadOnly = true;
            colPhoneNumber.Width = 150;
            // 
            // colFavorite
            // 
            colFavorite.DataPropertyName = "contact_favorite";
            colFavorite.HeaderText = "Favorite";
            colFavorite.MinimumWidth = 8;
            colFavorite.Name = "colFavorite";
            colFavorite.ReadOnly = true;
            colFavorite.Resizable = DataGridViewTriState.True;
            colFavorite.SortMode = DataGridViewColumnSortMode.Automatic;
            colFavorite.Width = 150;
            // 
            // colID
            // 
            colID.DataPropertyName = "contact_id";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            colID.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(154, 311);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 20);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(236, 311);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(78, 20);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(319, 311);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 20);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpen
            // 
            btnOpen.Enabled = false;
            btnOpen.Location = new Point(401, 311);
            btnOpen.Margin = new Padding(2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(78, 20);
            btnOpen.TabIndex = 6;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(297, 290);
            lblPageNumber.Margin = new Padding(2, 0, 2, 0);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(53, 15);
            lblPageNumber.TabIndex = 5;
            lblPageNumber.Text = "page 1/1";
            lblPageNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(211, 287);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(70, 20);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(364, 287);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 20);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 16);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 7;
            label1.Text = "Contact Management";
            // 
            // ucContactManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(lblPageNumber);
            Controls.Add(btnOpen);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvContacts);
            Margin = new Padding(2);
            Name = "ucContactManagement";
            Size = new Size(665, 345);
            Load += ucContactManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContacts;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnOpen;
        private Label lblPageNumber;
        private Button btnPrevious;
        private Button btnNext;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colMail;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewCheckBoxColumn colFavorite;
        private DataGridViewTextBoxColumn colID;
        private Label label1;
    }
}
