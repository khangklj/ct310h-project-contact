using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            loadContactGroup();

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
                    txtContactEmail.Text = reader["Contact_Email"].ToString();
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
                int contactId = this.isEditing ? Int32.Parse(txtContactID.Text) : getNewContactId();
                string name = txtContactName.Text.Trim();
                string phoneNumber = txtPhoneNumber.Text.Trim();
                string email = txtContactEmail.Text.Trim();
                bool favorite = chkFavorite.Checked;
                string description = txtContactDescription.Text.Trim();
                int? accountId = AuthInfo.accountID;
                int? contactGroupId = (int?)cboGroup.SelectedValue;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Contact Name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Contact email is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContactEmail.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(phoneNumber))
                {
                    MessageBox.Show("Phone Number is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(phoneNumber, @"^\d{10}$"))
                {
                    MessageBox.Show("Phone Number must be 10 digits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContactEmail.Focus();
                    return;
                }

                if (!string.IsNullOrEmpty(email))
                {
                    if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    {
                        MessageBox.Show("Invalid email format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query;

                if (this.isEditing)
                {
                    query = @"UPDATE Contact 
                      SET Contact_Name = @Name, 
                          Contact_PhoneNumber = @PhoneNumber, 
                          Contact_Email = @Email,
                          Contact_Favorite = @Favorite, 
                          Contact_Description = @Description, 
                          Account_ID = @AccountID, 
                          ContactGroup_ID = @GroupID 
                      WHERE Contact_ID = @ContactID";
                }
                else
                {
                    query = @"INSERT INTO Contact (Contact_ID, Contact_Name, Contact_PhoneNumber, Contact_Email, Contact_Favorite, Contact_Description, Account_ID, ContactGroup_ID)
                      VALUES (@ContactID, @Name, @PhoneNumber, @Email, @Favorite, @Description, @AccountID, @GroupID)";
                }

                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);

                cmd.Parameters.AddWithValue("@ContactID", contactId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Favorite", favorite);
                cmd.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AccountID", accountId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GroupID", contactGroupId ?? (object)DBNull.Value);

                int rowsAffected = cmd.ExecuteNonQuery();

                clsDatabase.CloseConnection();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Contact saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the contact:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
