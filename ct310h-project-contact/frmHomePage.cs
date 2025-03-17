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
        public frmHomePage()
        {
            InitializeComponent();

            SetAccountName();
        }

        private void SetAccountName()
        {
            try
            {
                clsDatabase.OpenConnection();

                string query = "SELECT Account_Name FROM Account WHERE Account_ID = @Account_ID";

                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);
                cmd.Parameters.AddWithValue("@Account_ID", AuthService.AccountID);

                object result = cmd.ExecuteScalar();

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthService.ClearAuth();

            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnManageContact_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucContactManagement uc = new ucContactManagement();
            uc.Location = new Point()
            {
                X = pnlMain.Width / 2 - uc.Width / 2,
                Y = pnlMain.Height / 2 - uc.Height / 2,
            };
            pnlMain.Controls.Add(uc);
        }

        private void btnManageGroup_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucContactGroupManagement uc = new ucContactGroupManagement();
            uc.Location = new Point()
            {
                X = pnlMain.Width / 2 - uc.Width / 2,
                Y = pnlMain.Height / 2 - uc.Height / 2,
            };
            pnlMain.Controls.Add(uc);
        }

        private void rbtnAccount_Click(object sender, EventArgs e)
        {
            var pos = rbtnAccount.PointToScreen(new System.Drawing.Point(rbtnAccount.Width - cmsAccount.Width, rbtnAccount.Height));
            cmsAccount.Show(pos);
        }

        private void tsmiAccountDetails_Click(object sender, EventArgs e)
        {
            frmAccountDetails frm = new frmAccountDetails();
            frm.ShowDialog();
        }

        private void frmHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {            
            AuthService.ClearAuth();

            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
