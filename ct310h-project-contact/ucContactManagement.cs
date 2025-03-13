using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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
        private int pageSize = 3;
        private int totalRecords = 0;
        private int totalPages = 0;

        public ucContactManagement()
        {
            InitializeComponent();
        }

        private void ucContactManagement_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            LoadContacts(currentPage);
        }

        private void LoadContacts(int page)
        {
            try
            {
                clsDatabase.OpenConnection();

                // Count total records first
                totalRecords = CountTotalRecords();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                // SQL query for pagination using OFFSET and FETCH NEXT
                string query = @"
                    SELECT Contact_ID, Contact_Name, Contact_PhoneNumber, Contact_Favorite, Contact_Email
                    FROM Contact 
                    WHERE Account_ID = @Account_ID
                    ORDER BY Contact_ID 
                    OFFSET @Offset ROWS 
                    FETCH NEXT @PageSize ROWS ONLY";

                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);

                // Bind parameters
                cmd.Parameters.AddWithValue("@Account_ID", AuthInfo.AccountID);
                cmd.Parameters.AddWithValue("@Offset", (page - 1) * pageSize);
                cmd.Parameters.AddWithValue("@PageSize", pageSize);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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

        private int CountTotalRecords()
        {
            try
            {
                clsDatabase.OpenConnection();

                string countQuery = "SELECT COUNT(*) FROM Contact WHERE ACCOUNT_ID = @Account_ID";
                SqlCommand countCmd = new SqlCommand(countQuery, clsDatabase.conn);
                countCmd.Parameters.AddWithValue("@Account_ID", AuthInfo.AccountID);

                int countRecords = (int)countCmd.ExecuteScalar();

                clsDatabase.CloseConnection();

                return countRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading contacts:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditContact frm = new frmEditContact();
            frm.ShowDialog();
            currentPage = totalPages;
            // Reload
            LoadContacts(currentPage);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditContact frm = new frmEditContact(Convert.ToInt16(dgvContacts.SelectedRows[0].Cells["colID"].Value?.ToString()));
            frm.ShowDialog();
            // Reload
            LoadContacts(currentPage);
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

                    int remainingRecords = CountTotalRecords();
                    int totalPagesAfterDeletion = (int)Math.Ceiling((double)remainingRecords / pageSize);

                    if (currentPage > totalPagesAfterDeletion)
                    {
                        currentPage = totalPagesAfterDeletion;
                    }

                    LoadContacts(currentPage);
                }
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
