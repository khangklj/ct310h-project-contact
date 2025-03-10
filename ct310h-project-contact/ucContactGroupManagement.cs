using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ct310h_project_contact
{
    public partial class ucContactGroupManagement : UserControl
    {

        private readonly int? account_ID = AuthInfo.AccountID;

        public ucContactGroupManagement()
        {
            InitializeComponent();
        }

        private void ucContactGroupManagement_Load(object sender, EventArgs e)
        {
            LoadDataContactGroup();
            enableEditDelete(false);
        }

        private void LoadDataContactGroup()
        {
            try
            {
                clsDatabase.OpenConnection();
                String query = @"
                         SELECT ContactGroup_ID, ContactGroup_Name, ContactGroup_Description
                         FROM ContactGroup
                         WHERE Account_ID = @Account_ID
                         ORDER BY ContactGroup_Name ASC";
                SqlCommand command = new SqlCommand(query, clsDatabase.conn);
                command.Parameters.AddWithValue("@Account_ID", account_ID);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lvwContactGroupManagement.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["ContactGroup_ID"].ToString());
                    item.SubItems.Add(row["ContactGroup_Name"].ToString());
                    item.SubItems.Add(row["ContactGroup_Description"].ToString());
                    lvwContactGroupManagement.Items.Add(item);
                }

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void LoadContactFollowingGroup(int contactGroupID)
        {
            try
            {
                // Save currently selected contact ID if available
                int? selectedContactID = lvwContactFollowingGroup.SelectedItems.Count > 0
                    ? Convert.ToInt32(lvwContactFollowingGroup.SelectedItems[0].SubItems[0].Text)
                    : (int?)null;

                String query = @"
                            SELECT Contact_ID, Contact_Name, Contact_Email, Contact_PhoneNumber, Contact_Favorite, Contact_Description
                            FROM Contact
                            WHERE ContactGroup_ID = @ContactGroup_ID";
                SqlCommand comm = new SqlCommand(query, clsDatabase.conn);
                comm.Parameters.AddWithValue("@ContactGroup_ID", contactGroupID);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                da.Fill(dt);
            
                lvwContactFollowingGroup.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["Contact_ID"].ToString());
                    item.SubItems.Add(row["Contact_Name"].ToString());
                    item.SubItems.Add(row["Contact_Email"].ToString());
                    item.SubItems.Add(row["Contact_PhoneNumber"].ToString());
                    bool isFavorite = Convert.ToBoolean(row["Contact_Favorite"]);
                    String check = isFavorite ? "✔️" : "";
                    item.SubItems.Add(check);
                    item.SubItems.Add(row["Contact_Description"].ToString());

                    lvwContactFollowingGroup.Items.Add(item);

                    // Restore previous selection
                    if (selectedContactID.HasValue && selectedContactID.Value.ToString() == row["Contact_ID"].ToString())
                    {
                        item.Selected = true;
                    }
                }

               
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditGroupContact frm = new frmEditGroupContact();
            frm.ShowDialog();
            LoadDataContactGroup();
        }

        private void lvwContactGroupManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwContactGroupManagement.SelectedItems.Count > 0)
                {
                    enableEditDelete(true);
                    LoadContactFollowingGroup(Convert.ToInt32(lvwContactGroupManagement.SelectedItems[0].SubItems[0].Text));
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error when selecting contact group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwContactGroupManagement.SelectedItems.Count > 0) {
                frmEditGroupContact frm = new frmEditGroupContact(Convert.ToInt32(lvwContactGroupManagement.SelectedItems[0].SubItems[0].Text.ToString()));
                frm.ShowDialog();
                LoadDataContactGroup();
            } else
            {
                MessageBox.Show("Please select a contact group to edit.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwContactGroupManagement.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected contact group?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        clsDatabase.OpenConnection();
                        ListViewItem selectedItem = lvwContactGroupManagement.SelectedItems[0];
                        String id = selectedItem.SubItems[0].Text;

                        String updateQuery = @"
                                            UPDATE Contact
                                            SET ContactGroup_ID = NULL
                                            WHERE ContactGroup_ID = @ContactGroup_ID";
                        SqlCommand updateCom = new SqlCommand(updateQuery, clsDatabase.conn);
                        updateCom.Parameters.AddWithValue("@ContactGroup_ID", id);
                        updateCom.ExecuteNonQuery();

                        String deleteQuery = "DELETE FROM ContactGroup WHERE ContactGroup_ID = @ContactGroup_ID";
                        SqlCommand comm = new SqlCommand(deleteQuery, clsDatabase.conn);
                        comm.Parameters.AddWithValue("@ContactGroup_ID", id);
                        comm.ExecuteNonQuery();
                        clsDatabase.CloseConnection();
                        LoadDataContactGroup();
                        MessageBox.Show("Selected contact group deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting contacts:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                
                


            } else
            {
               
                MessageBox.Show("Please select at least one row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            }
        }

        private void lvwContactFollowingGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwContactFollowingGroup.SelectedItems.Count >= 0)
                {
                    enableEditDelete(false);

                    if (lvwContactFollowingGroup.SelectedItems.Count > 0)
                    {
                        btnOpen.Enabled = true;

                    }
                    else
                    {
                        enableEditDelete(true);

                        btnOpen.Enabled = false;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error when selecting Contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwContactFollowingGroup.SelectedItems.Count > 0)
                {
                    frmContactDetails frm = new frmContactDetails(Convert.ToInt32(lvwContactFollowingGroup.SelectedItems[0].SubItems[0].Text));
                    frm.ShowDialog();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enableEditDelete(bool enable)
        {
            btnEdit.Enabled = enable ? true : false;
            btnDelete.Enabled = enable ? true : false;
        }

    }
}
