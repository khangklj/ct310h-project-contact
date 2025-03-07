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
    public partial class frmGroupEditContact : Form
    {

        private int account_ID = (int)AuthInfo.AccountID;
        private bool isEditing;
        private int contactGroupID;


        public frmGroupEditContact(int contactGroupID = -1)
        {
            InitializeComponent();
            if (contactGroupID == -1)
            {
                this.Text = "Add Contact Group";
                lblContactGropManagement.Text = "Add Contact Group";
                btnAddSave.Text = "Add";
                this.contactGroupID = GetNewContactGroupID();
                txtContactGroup_ID.Text = this.contactGroupID.ToString();
                this.isEditing = false;
            }
            else
            {
                this.Text = "Edit Contact Group";
                lblContactGropManagement.Text = "Edit Contact Group";
                btnAddSave.Text = "Save";
                this.contactGroupID = contactGroupID;
                LoadContactGroup(contactGroupID);
                this.isEditing = true;
            }
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                int contactGroupID = this.isEditing ? Convert.ToInt32(txtContactGroup_ID.Text) : this.contactGroupID;
                String contactGroupName = txtContactGroup_Name.Text;
                String contactGroupDescription = rtxContactGroup_Description.Text;

                if (string.IsNullOrEmpty(contactGroupName))
                {
                    MessageBox.Show("Contact Group Name is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(contactGroupDescription))
                {
                    MessageBox.Show("Contact Group Description is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clsDatabase.OpenConnection();

                if (isEditing)
                {
                    String updateQuery = @"
                                       UPDATE ContactGroup
                                       SET ContactGroup_Name = @ContactGroup_Name,
                                           ContactGroup_Description = @ContactGroup_Description
                                       WHERE ContactGroup_ID = @ContactGroup_ID AND Account_ID = @Account_ID";
                    SqlCommand comm = new SqlCommand(updateQuery, clsDatabase.conn);
                    comm.Parameters.AddWithValue("@ContactGroup_ID", txtContactGroup_ID.Text);
                    comm.Parameters.AddWithValue("@ContactGroup_Name", txtContactGroup_Name.Text);
                    comm.Parameters.AddWithValue("@ContactGroup_Description", rtxContactGroup_Description.Text);
                    comm.Parameters.AddWithValue("@Account_ID", account_ID);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Contact Group edited successfully", "Annoucement", MessageBoxButtons.OK);

                }
                else
                {
                    String insertQuery = @"
                                INSERT INTO ContactGroup 
                                VALUES (@ContactGroup_ID, @ContactGroup_Name, @ContactGroup_Description, @Account_ID)";
                    SqlCommand comm = new SqlCommand(insertQuery, clsDatabase.conn);
                    comm.Parameters.AddWithValue("@ContactGroup_ID", txtContactGroup_ID.Text);
                    comm.Parameters.AddWithValue("@ContactGroup_Name", txtContactGroup_Name.Text);
                    comm.Parameters.AddWithValue("@ContactGroup_Description", rtxContactGroup_Description.Text);
                    comm.Parameters.AddWithValue("@Account_ID", account_ID);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Contact Group added successfully", "Annoucement", MessageBoxButtons.OK);
                    ResetAddEditContactGroup();

                }
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OKCancel);
            }

        }

        private void ResetAddEditContactGroup()
        {
            txtContactGroup_ID.Text = GetNewContactGroupID().ToString();
            txtContactGroup_Name.Clear();
            rtxContactGroup_Description.Clear();
        }

        private int GetNewContactGroupID()
        {
            try
            {
                clsDatabase.OpenConnection();
                String queryString = "SELECT MAX(ContactGroup_ID) from ContactGroup";
                SqlCommand comm = new SqlCommand(queryString, clsDatabase.conn);
                comm.Parameters.AddWithValue("@Account_ID", account_ID);
                int ContactGroup_ID = Convert.ToInt32(comm.ExecuteScalar());
                int newContactGroup_ID = ContactGroup_ID + 1;
                clsDatabase.CloseConnection();

                return newContactGroup_ID;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error whiling getting new contact ID: \n" + ex.Message, "Error", MessageBoxButtons.OKCancel);
                return -1;
            }

        }

        private void LoadContactGroup(int contactGroupID)
        {
            try
            {
                clsDatabase.OpenConnection();
                String query = @"SELECT ContactGroup_ID, ContactGroup_Name, ContactGroup_Description
                                FROM ContactGroup
                                WHERE ContactGroup_ID = @ContactGroup_ID";
                SqlCommand comm = new SqlCommand(query, clsDatabase.conn);
                comm.Parameters.AddWithValue("@ContactGroup_ID", contactGroupID);
                using SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtContactGroup_ID.Text = reader["ContactGroup_ID"].ToString();
                    txtContactGroup_Name.Text = reader["ContactGroup_Name"].ToString();
                    rtxContactGroup_Description.Text = reader["ContactGroup_Description"].ToString();
                }
                else
                {
                    MessageBox.Show("No record found with the given ID.");
                }
                reader.Close();
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading data: \n" + ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtContactGroup_ID.Clear();
            this.Hide();
        }
    }
}
