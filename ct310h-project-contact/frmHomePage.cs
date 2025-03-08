using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ct310h_project_contact
{
    public partial class frmHomePage : Form
    {
        private string avatarUrl = "https://github-production-user-asset-6210df.s3.amazonaws.com/160006238/420578901-7242486e-31f0-445b-8413-adec87813679.jpg";
        //private string avatarUrl = "https://img.freepik.com/premium-vector/avatar-icon0002_750950-43.jpg";

        public frmHomePage()
        {
            InitializeComponent();

            SetAccountName();
            LoadAvatar();
        }

        private void SetAccountName()
        {
            try
            {
                clsDatabase.OpenConnection();

                string query = "SELECT Account_Name FROM Account WHERE Account_ID = @Account_ID";

                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);
                cmd.Parameters.AddWithValue("@Account_ID", AuthInfo.AccountID);

                object result = cmd.ExecuteScalar();

                lblAccountName.Location = new Point(
                    rbtnAccount.Left + (rbtnAccount.Width - lblAccountName.Width) / 2,
                    rbtnAccount.Bottom + 5 // 5px spacing below the button
                );
                if (result != null)
                {
                    lblAccountName.Text = result.ToString();

                }
                else
                {
                    lblAccountName.Text = "Unknown User";
                }

                clsDatabase.CloseConnection();
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading account name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void LoadAvatar()
        {
            string localImagePath = await DownloadAvatarAsync(avatarUrl);

            if (!string.IsNullOrEmpty(localImagePath) && File.Exists(localImagePath))
            {
                rbtnAccount.ImageLocation = localImagePath;
                rbtnAccount.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private static async Task<string> DownloadAvatarAsync(string avatarUrl)
        {
            string localImagePath = Path.Combine(Application.StartupPath, "default_avatar.jpg");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageData = await client.GetByteArrayAsync(avatarUrl);
                    await File.WriteAllBytesAsync(localImagePath, imageData);
                }
                return localImagePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading image: " + ex.Message);
                return null;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnManageContact_Click(object sender, EventArgs e)
        {
            ucContactManagement contactManagementControl = new ucContactManagement();
            contactManagementControl.Location = new Point(178, 50);

            this.Controls.Add(contactManagementControl);

        }

        private void btnManageGroup_Click(object sender, EventArgs e)
        {

        }

        private void rbtnAccount_Click(object sender, EventArgs e)
        {
            cmsAccount.Show(rbtnAccount, new Point(rbtnAccount.Width / 2, rbtnAccount.Height / 2));
        }
    }
}
