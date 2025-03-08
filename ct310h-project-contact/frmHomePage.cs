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
        //private string avatarUrl = "https://github-production-user-asset-6210df.s3.amazonaws.com/160006238/420578901-7242486e-31f0-445b-8413-adec87813679.jpg";
        private string avatarUrl = "https://img.freepik.com/premium-vector/avatar-icon0002_750950-43.jpg";

        public frmHomePage()
        {
            InitializeComponent();
            rbtnAccount.Text = "";
            rbtnAccount.BackgroundImage = LoadImageFromUrl(rbtnAccount, avatarUrl);
            rbtnAccount.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private Image LoadImageFromUrl(RJControls.RJButton button, string url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(url);
                    using (System.IO.MemoryStream stream = new System.IO.MemoryStream(imageData))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch
            {
                return new Bitmap(button.Width, button.Height); // Return empty image if download fails
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

        private void rbtnAccount_Click(object sender, EventArgs e)
        {
            cmsAccount.Show(rbtnAccount, new Point(rbtnAccount.Width / 2, rbtnAccount.Height / 2));
        }

        private void btnManageContact_Click(object sender, EventArgs e)
        {

        }

        private void btnManageGroup_Click(object sender, EventArgs e)
        {

        }
    }
}
