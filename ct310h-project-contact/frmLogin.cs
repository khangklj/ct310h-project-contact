﻿using Microsoft.Data.SqlClient;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            int? userId = ValidateUser(username, password);

            if (userId.HasValue)
            {
                AuthInfo.SetAuth(userId.Value); // Gán ID người dùng vào AuthInfo
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                frmTestDatabase frm = new frmTestDatabase();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private int? ValidateUser(string username, string password)
        {
            try
            {
                // Kiểm tra kết nối với cơ sở dữ liệu
                if (!clsDatabase.OpenConnection())
                {
                    MessageBox.Show("Cannot connect to database.");
                    return null;
                }

                string query = "SELECT Account_ID FROM Account WHERE Account_UserName = @username AND Account_Password = @password";

                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.conn))
                {
                    // Tránh SQL Injection bằng cách khai báo rõ kiểu dữ liệu
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 100).Value = username;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 100).Value = password;

                    object result = cmd.ExecuteScalar();
                    return result != null ? (int?)Convert.ToInt32(result) : null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}