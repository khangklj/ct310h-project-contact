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
using System.Xml.Linq;

namespace ct310h_project_contact
{
    public partial class frmEditContact : Form
    {
        private int contactId;
        private bool isEditing;
        
        public frmEditContact(int contactId = -1)
        {
            InitializeComponent();

            if (contactId == -1)
            {
                this.Text = "Add Contact Form";
                lblHeader.Text = "Add Contact";
                btnSave.Text = "Add";
                this.contactId = getNewContactId();
                txtContactID.Text = this.contactId.ToString();
                this.isEditing = false;
            }
            else
            {
                this.Text = "Edit Contact Form";
                lblHeader.Text = "Edit Contact";
                btnSave.Text = "Save";
                this.contactId = contactId;
                txtContactID.Text = this.contactId.ToString();
                loadContact(contactId);
                this.isEditing = true;
            }

            loadContactGroup();
        }

        private int getNewContactId()
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "SELECT ISNULL(MAX(Contact_ID), 0) + 1 FROM Contact";

                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);
                int newId = Convert.ToInt32(cmd.ExecuteScalar());

                clsDatabase.CloseConnection();
                return newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating a new contact ID:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void loadContact(int contactId)
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "SELECT * FROM Contact WHERE Contact_ID = @Contact_ID";

                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);
                cmd.Parameters.AddWithValue("@Contact_ID", contactId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtContactName.Text = reader["Contact_Name"].ToString();
                    txtPhoneNumber.Text = reader["Contact_PhoneNumber"].ToString();
                    chkFavorite.Checked = Convert.ToBoolean(reader["Contact_Favorite"]);
                    txtContactDescription.Text = reader["Contact_Description"].ToString();

                    if (reader["ContactGroup_ID"] != DBNull.Value)
                        cboGroup.SelectedValue = Convert.ToInt32(reader["ContactGroup_ID"]);
                }
                else
                {
                    MessageBox.Show("Contact not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading contact:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadContactGroup()
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "SELECT ContactGroup_ID, ContactGroup_Name FROM ContactGroup WHERE Account_ID = @Account_ID";

                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);
                cmd.Parameters.AddWithValue("@Account_ID", AuthInfo.accountID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboGroup.DataSource = dt;
                cboGroup.DisplayMember = "ContactGroup_Name";
                cboGroup.ValueMember = "ContactGroup_ID";

                cboGroup.SelectedIndex = -1;

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading contact groups:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();

                int contactId = Int32.Parse(txtContactID.Text);
                string name = txtContactName.Text;
                string phoneNumber = txtPhoneNumber.Text;
                bool favorite = chkFavorite.Checked;
                string description = txtContactDescription.Text;
                int? accountId = AuthInfo.accountID;
                int? contactGroupId = (int?) cboGroup.SelectedValue;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
                {
                    MessageBox.Show("Name and Phone Number are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clsDatabase.conn;

                if (this.isEditing)
                {
                    query = @"UPDATE Contact 
                      SET Contact_Name = @Name, 
                          Contact_PhoneNumber = @PhoneNumber, 
                          Contact_Favorite = @Favorite, 
                          Contact_Description = @Description, 
                          Account_ID = @AccountID, 
                          ContactGroup_ID = @GroupID 
                      WHERE Contact_ID = @ContactID";
                    cmd.Parameters.AddWithValue("@ContactID", contactId);
                }
                else
                {
                    query = @"INSERT INTO Contact (Contact_ID, Contact_Name, Contact_PhoneNumber, Contact_Favorite, Contact_Description, Account_ID, ContactGroup_ID)
                      VALUES (@ContactID, @Name, @PhoneNumber, @Favorite, @Description, @AccountID, @GroupID)";
                    contactId = getNewContactId();
                    cmd.Parameters.AddWithValue("@ContactID", contactId);
                }

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Favorite", favorite);
                cmd.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AccountID", accountId);
                cmd.Parameters.AddWithValue("@GroupID", (object)contactGroupId ?? DBNull.Value);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Contact saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Close form on success
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the contact:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
