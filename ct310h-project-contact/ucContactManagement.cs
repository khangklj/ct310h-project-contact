using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ct310h_project_contact
{
    public partial class ucContactManagement : UserControl
    {
        private int currentPage = 1;
        private int pageSize = 5;
        private int totalRecords = 0;
        private int totalPages = 0;

        public ucContactManagement()
        {
            InitializeComponent();
        }

        private void ucContactManagement_Load(object sender, EventArgs e)
        {
            LoadContacts(currentPage);
        }

        private void LoadContacts(int page)
        {
            try
            {
                clsDatabase.OpenConnection();

                // Count total records first
                string countQuery = "SELECT COUNT(*) FROM Contact";
                SqlCommand countCmd = new SqlCommand(countQuery, clsDatabase.conn);
                totalRecords = (int)countCmd.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                // SQL query for pagination using OFFSET and FETCH NEXT
                string query = $@"
            SELECT Contact_ID, Contact_Name, Contact_PhoneNumber, Contact_Favorite 
            FROM Contact 
            ORDER BY Contact_ID 
            OFFSET {(page - 1) * pageSize} ROWS 
            FETCH NEXT {pageSize} ROWS ONLY";

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, clsDatabase.conn);
                adapter.Fill(dt);

                dgvContacts.AutoGenerateColumns = false;
                dgvContacts.DataSource = dt;

                clsDatabase.CloseConnection();

                // Update UI controls
                lblPageNumber.Text = $"Page {currentPage} / {totalPages}";
                btnPrevious.Enabled = (currentPage > 1);
                btnNext.Enabled = (currentPage < totalPages);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading contacts:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditContact frm = new frmEditContact();
            frm.ShowDialog();
            // Reload
            ucContactManagement_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditContact frm = new frmEditContact(Convert.ToInt16(dgvContacts.SelectedRows[0].Cells["colID"].Value?.ToString()));
            frm.ShowDialog();
            // Reload
            ucContactManagement_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected contacts?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        clsDatabase.OpenConnection();

                        foreach (DataGridViewRow row in dgvContacts.SelectedRows)
                        {
                            int contactId = Convert.ToInt32(row.Cells["colID"].Value);

                            // Delete from database
                            string query = "DELETE FROM Contact WHERE Contact_ID = @Contact_ID";
                            using (SqlCommand cmd = new SqlCommand(query, clsDatabase.conn))
                            {
                                cmd.Parameters.AddWithValue("@Contact_ID", contactId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        clsDatabase.CloseConnection();

                        MessageBox.Show("Selected contacts deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting contacts:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Reload
                ucContactManagement_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select at least one row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnOpen.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnOpen.Enabled = false;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            frmContactDetails frm = new frmContactDetails(Convert.ToInt16(dgvContacts.SelectedRows[0].Cells["colID"].Value?.ToString()));
            frm.ShowDialog();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadContacts(currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadContacts(currentPage);
            }
        }
    }
}
