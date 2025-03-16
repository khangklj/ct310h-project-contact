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

        private readonly int? account_ID = 2;
        private int selectedGroupID;
        public ucContactGroupManagement()
        {
            InitializeComponent();
            ResetIndices();
        }

        private void ucContactGroupManagement_Load(object sender, EventArgs e)
        {
            LoadDataContactGroup();
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
                            WHERE ContactGroup_ID = @ContactGroup_ID
                            AND Account_ID = @Account_ID";
                SqlCommand comm = new SqlCommand(query, clsDatabase.conn);
                comm.Parameters.AddWithValue("@ContactGroup_ID", contactGroupID);
                comm.Parameters.AddWithValue("@Account_ID", account_ID);

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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditGroupContact frm = new frmEditGroupContact();
            frm.ShowDialog();
            LoadDataContactGroup();
            ResetIndices();
        }

        private void lvwContactGroupManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwContactGroupManagement.SelectedItems.Count > 0)
                {
                    selectedGroupID = Convert.ToInt32(lvwContactGroupManagement.SelectedItems[0].SubItems[0].Text);
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    LoadContactFollowingGroup(selectedGroupID);
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error when loading contacts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwContactGroupManagement.SelectedItems.Count > 0)
            {
                frmEditGroupContact frm = new frmEditGroupContact(Convert.ToInt32(lvwContactGroupManagement.SelectedItems[0].SubItems[0].Text.ToString()));
                frm.ShowDialog();
                LoadDataContactGroup();
                ResetIndices();
            }
            else
            {
                MessageBox.Show("Please select a contact group to edit.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwContactGroupManagement.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected contact group?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                        ResetIndices();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting contacts:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select at least one row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvwContactFollowingGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwContactFollowingGroup.SelectedIndices.Count > 0)
            {
                btnOpen.Enabled = true;
                btnDeleteContact.Enabled = true;
            }
            else
            {
                btnOpen.Enabled = false;
                btnDeleteContact.Enabled = false;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwContactGroupManagement_Enter(object sender, EventArgs e)
        {
            lvwContactFollowingGroup.SelectedIndices.Clear();
            btnOpen.Enabled = false;
            btnDeleteContact.Enabled = false;
        }

        private void lvwContactFollowingGroup_Enter(object sender, EventArgs e)
        {
            lvwContactGroupManagement.SelectedIndices.Clear();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void ResetIndices()
        {
            lvwContactFollowingGroup.SelectedIndices.Clear();
            lvwContactGroupManagement.SelectedIndices.Clear();
            btnOpen.Enabled = false;
            btnDeleteContact.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwContactGroupManagement.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Please select any group to add contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int groupid = Convert.ToInt32(lvwContactGroupManagement.SelectedItems[0].SubItems[0].Text);
                    string groupName = lvwContactGroupManagement.SelectedItems[0].SubItems[1].Text;
                    frmAddContactFromGroupContactManagement frm = new frmAddContactFromGroupContactManagement(groupid, groupName);
                    frm.ShowDialog();
                    ResetIndices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (lvwContactFollowingGroup.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to DELETE the selected contact from Group?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    clsDatabase.OpenConnection();
                    string query = @"
                                UPDATE Contact
                                SET ContactGroup_ID = NULL
                                WHERE Account_ID = @Account_ID 
                                AND Contact_ID = @Contact_ID";
                    SqlCommand comm = new SqlCommand(query, clsDatabase.conn);
                    int contact_ID = Convert.ToInt32(lvwContactFollowingGroup.SelectedItems[0].SubItems[0].Text);
                    comm.Parameters.AddWithValue("@Account_ID", account_ID);
                    comm.Parameters.AddWithValue("@Contact_ID", contact_ID);
                    comm.ExecuteNonQuery();
                    clsDatabase.CloseConnection();
                    
                    MessageBox.Show("Contact is deleted the group successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadContactFollowingGroup(selectedGroupID);
                    //selectedGroupID = -1;
                }
            } else
            {
                MessageBox.Show("Please select any contact to DELETE from group.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
