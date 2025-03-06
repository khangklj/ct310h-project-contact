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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }


        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
        private bool IsUsernameExists(string username)
        {
            try
            {
                if (!clsDatabase.OpenConnection()) return false;

                string query = "SELECT COUNT(*) FROM Account WHERE Account_UserName = @username";
                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return true;
            }
            finally
            {
                clsDatabase.CloseConnection();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtComfirm.Text.Trim();
            string name = txtName.Text.Trim();

            // check empty
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please confirm your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComfirm.Focus();
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            // check password & comfirm passowrd
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComfirm.Focus();
                return;
            }

            // Check exist Username
            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            // get acccount ID
            int newAccountID = GetNextAccountId();
            // call Register function
            if (RegisterUser(username, password, name, newAccountID))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin loginForm = new frmLogin(username, password);
                loginForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetNextAccountId()
        {
            int nextId = 1; // if null get id = 1

            try
            {
                if (!clsDatabase.OpenConnection())
                {
                    MessageBox.Show("Cannot connect to database.");
                    return nextId;
                }

                string query = "SELECT MAX(Account_ID) FROM Account";

                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        nextId = Convert.ToInt32(result) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving next Account_ID: " + ex.Message);
            }
            finally
            {
                clsDatabase.CloseConnection();
            }

            return nextId;
        }
        private bool RegisterUser(string username, string password, string name, int newAccountID)
        {
            try
            {
                if (!clsDatabase.OpenConnection()) return false;

                string query = "INSERT INTO Account (Account_ID,Account_UserName, Account_Password, Account_Name) VALUES (@AccountId,@username, @password, @name)";
                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@AccountId", newAccountID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                clsDatabase.CloseConnection();
            }
        }

        private void lblBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin loginform = new frmLogin();
            loginform.Show();
            this.Hide();
        }
    }
}
