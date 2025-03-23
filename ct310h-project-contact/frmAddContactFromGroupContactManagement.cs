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
    public partial class frmAddContactFromGroupContactManagement : Form
    {
        int? accountid = AuthService.accountID;
        int? groupid;
        string groupName;
        public frmAddContactFromGroupContactManagement(int? groupid, string groupName)
        {
            InitializeComponent();
            this.groupid = groupid;
            this.groupName = groupName;
        }

        private void frmAddContactFromGroupContactManagement_Load(object sender, EventArgs e)
        {
            LoadContact();
        }

        private void LoadContact()
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = @"
                            SELECT Contact_ID, Contact_Name 
                            FROM CONTACT
                            WHERE Account_ID = @Account_ID 
                            AND ContactGroup_ID IS NULL";
                SqlCommand comm = new SqlCommand(query, clsDatabase.conn);
                comm.Parameters.AddWithValue("@Account_ID", accountid);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //cboContact.DataSource = dt;
                //cboContact.DisplayMember = "Contact_Name";
                //cboContact.ValueMember = "Contact_ID";

                lstContact.DataSource = dt;
                lstContact.DisplayMember = "Contact_Name";
                lstContact.ValueMember = "Contact_ID";

                lstContact.SelectionMode = SelectionMode.MultiSimple;
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                if(lstContact.SelectedItems.Count < 1 ) {
                    MessageBox.Show($"Please select any contact to add into group {groupName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    clsDatabase.OpenConnection();
                    String query = @"
                            UPDATE Contact
                            SET ContactGroup_ID = @ContactGroup_ID
                            WHERE Contact_ID = @Contact_ID 
                            AND Account_ID = @Account_ID";
                    SqlCommand comm = new SqlCommand(query, clsDatabase.conn);



                    foreach (DataRowView rowview in lstContact.SelectedItems)
                    {
                        comm.Parameters.Clear();
                        int contact_ID = Convert.ToInt32(rowview["Contact_ID"]);
                        comm.Parameters.AddWithValue("@Account_ID", accountid);
                        comm.Parameters.AddWithValue("@Contact_ID", contact_ID);
                        comm.Parameters.AddWithValue("@ContactGroup_ID", groupid);
                        comm.ExecuteNonQuery();
                    }

                    clsDatabase.CloseConnection();
                    LoadContact();
                    MessageBox.Show($"Contact(s) is added into \"{groupName}\" successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstContact.SelectedItems.Clear();
            this.Close();
        }

        private void lstContact_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
