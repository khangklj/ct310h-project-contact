﻿using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ct310h_project_contact
{
    public partial class frmAccountDetails : Form
    {
        private string currentAvatarPath = "";
        private readonly string defaultAvatarPath = Path.Combine(Application.StartupPath, "Assets", "defaultavatar.jpg");
        private const int maxFileSize = 1024 * 1024; // 1MB

        public frmAccountDetails()
        {
            InitializeComponent();
            this.Load += frmAccountDetails_Load;
        }

        private void frmAccountDetails_Load(object? sender, EventArgs e)
        {

            LoadAccounts();
        }

        private void LoadAccounts()
        {
            try
            {
                clsDatabase.OpenConnection();

                string query = @"SELECT Account_Username, Account_Password, Account_Name, Account_Avatar FROM Account WHERE Account_ID = @Account_ID";
                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.conn))
                {
                    cmd.Parameters.AddWithValue("@Account_ID", AuthService.AccountID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUsername.Text = reader["Account_Username"].ToString();
                            txtPassword.Text = reader["Account_Password"].ToString();
                            txtName.Text = reader["Account_Name"].ToString();

                            // Kiểm tra ảnh đại diện
                            if (reader["Account_Avatar"] != DBNull.Value)
                            {
                                try
                                {
                                    byte[] imageBytes = (byte[])reader["Account_Avatar"];
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        picAvatar.Image = Image.FromStream(ms);
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Avatar image is broken, showing default image.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    LoadDefaultAvatar();
                                }
                            }
                            else
                            {
                                LoadDefaultAvatar();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load account:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDefaultAvatar()
        {
            if (File.Exists(defaultAvatarPath))
            {
                picAvatar.Image = Image.FromFile(defaultAvatarPath);
                currentAvatarPath = defaultAvatarPath;
            }
            else
            {
                MessageBox.Show("Can't find Default avatar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    if (fileInfo.Length > maxFileSize)
                    {
                        MessageBox.Show("Size not exceeding 1MB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    currentAvatarPath = openFileDialog.FileName;
                    picAvatar.Image = Image.FromFile(currentAvatarPath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name can not empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password can not empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                clsDatabase.OpenConnection();


                bool updateAvatar = !string.IsNullOrEmpty(currentAvatarPath) && File.Exists(currentAvatarPath);

                string query = updateAvatar
                    ? @"UPDATE Account SET Account_Password = @Password, Account_Name = @Name, Account_Avatar = @Avatar WHERE Account_ID = @Account_ID"
                    : @"UPDATE Account SET Account_Password = @Password, Account_Name = @Name WHERE Account_ID = @Account_ID";

                using (SqlCommand cmd = new SqlCommand(query, clsDatabase.conn))
                {
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Account_ID", AuthService.AccountID);

                    if (updateAvatar)
                    {
                        try
                        {
                            byte[] imageBytes = File.ReadAllBytes(currentAvatarPath);
                            cmd.Parameters.Add("@Avatar", SqlDbType.VarBinary).Value = imageBytes;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi đọc ảnh: " + ex.Message);
                            return;
                        }
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update Account:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
