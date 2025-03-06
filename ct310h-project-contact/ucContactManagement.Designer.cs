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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvContacts = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // dgvContacts
            // 
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dgvContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvContacts.BackgroundColor = Color.White;
            dgvContacts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkBlue;
            dataGridViewCellStyle5.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Columns.AddRange(new DataGridViewColumn[] { colName, colPhoneNumber, colFavorite, colID });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvContacts.DefaultCellStyle = dataGridViewCellStyle6;
            dgvContacts.EnableHeadersVisualStyles = false;
            dgvContacts.GridColor = Color.LightGray;
            dgvContacts.Location = new Point(3, 3);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.ReadOnly = true;
            dgvContacts.RowHeadersWidth = 62;
            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContacts.Size = new Size(596, 346);
            dgvContacts.TabIndex = 0;
            dgvContacts.SelectionChanged += dgvContacts_SelectionChanged;
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
            btnAdd.Location = new Point(68, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(186, 413);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(304, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpen
            // 
            btnOpen.Enabled = false;
            btnOpen.Location = new Point(422, 413);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 34);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(253, 378);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(52, 25);
            lblPageNumber.TabIndex = 5;
            lblPageNumber.Text = "page";
            lblPageNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(150, 373);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(100, 34);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(344, 373);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 34);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ucContactManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(lblPageNumber);
            Controls.Add(btnOpen);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvContacts);
            Name = "ucContactManagement";
            Size = new Size(602, 450);
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
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewCheckBoxColumn colFavorite;
        private DataGridViewTextBoxColumn colID;
        private Label lblPageNumber;
        private Button btnPrevious;
        private Button btnNext;
    }
}
