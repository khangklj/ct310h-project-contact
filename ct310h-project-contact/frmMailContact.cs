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

namespace ct310h_project_contact
{
    public partial class frmMailContact : Form
    {
        private string email;

        public frmMailContact(string email)
        {
            this.email = email;
            InitializeComponent();
            txtMailTo.Text = this.email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            frmLoadingScreen frmLoading = new frmLoadingScreen();            
            try
            {         
                string fromEmail = "rosalind66@ethereal.email";
                string password = "Cubfdp3ftgVx3EeHPj";
                string toEmail = txtMailTo.Text.Trim();
                string subject = txtMailSubject.Text.Trim();
                string body = txtMailBody.Text.Trim();
                string cc = GetEmailsFromListBox(lstCc);
                string bcc = GetEmailsFromListBox(lstBcc);

                if (string.IsNullOrWhiteSpace(toEmail))
                {
                    MessageBox.Show("Recipient email (To) cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMailTo.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(subject))
                {
                    MessageBox.Show("Subject cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMailSubject.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(body))
                {
                    MessageBox.Show("Email body cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMailBody.Focus();
                    return;
                }

                List<string> attachments = new List<string>();
                foreach (var item in lstFiles.Items)
                {
                    attachments.Add(item.ToString()!);
                }

                EmailService emailService = new EmailService(fromEmail, password);

                emailService.ConstructEmail(toEmail, subject, body, cc, bcc);

                if (attachments.Count > 0)
                {
                    emailService.AddAttachments(attachments);
                }
                this.Enabled = false;
                frmLoading.StartPosition = FormStartPosition.CenterScreen;
                frmLoading.Show();
                await emailService.SendEmail();

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the loading form
                if (frmLoading.IsHandleCreated)
                {
                    frmLoading.Invoke((MethodInvoker)(() => frmLoading.Close()));
                }
                this.Enabled = true;
            }
        }

        private string GetEmailsFromListBox(ListBox listBox)
        {
            List<string> emails = new List<string>();

            foreach (var item in listBox.Items)
            {
                emails.Add(item.ToString()!);
            }

            return string.Join(",", emails); // Return emails as comma-separated string
        }

        private void btnInsertFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        if (!lstFiles.Items.Contains(file)) // Prevent duplicates
                        {
                            lstFiles.Items.Add(file);
                        }
                    }
                }
            }
        }

        private void btnDeleteFiles_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                lstFiles.Items.Remove(lstFiles.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a file to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsertCc_Click(object sender, EventArgs e)
        {
            using (frmEmailInput inputForm = new frmEmailInput())
            {
                inputForm.Text = "Enter CC Email";

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string ccEmail = inputForm.EnteredEmail;

                    if (!lstCc.Items.Contains(ccEmail))
                    {
                        lstCc.Items.Add(ccEmail);
                    }
                    else
                    {
                        MessageBox.Show("This CC email is already added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnDeleteCc_Click(object sender, EventArgs e)
        {
            if (lstCc.SelectedItem != null)
            {
                lstCc.Items.Remove(lstCc.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a CC email to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsertBcc_Click(object sender, EventArgs e)
        {
            using (frmEmailInput inputForm = new frmEmailInput())
            {
                inputForm.Text = "Enter BCC Email";

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string bccEmail = inputForm.EnteredEmail;

                    if (!lstBcc.Items.Contains(bccEmail))
                    {
                        lstBcc.Items.Add(bccEmail);
                    }
                    else
                    {
                        MessageBox.Show("This BCC email is already added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnDeleteBcc_Click(object sender, EventArgs e)
        {
            if (lstBcc.SelectedItem != null)
            {
                lstBcc.Items.Remove(lstBcc.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a BCC email to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMailSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtMailBody.Focus();
            }
        }

        private void lstCc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lstBcc.Focus();
            }
        }

        private void lstBcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lstFiles.Focus();
            }
        }

        private void lstFiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
    }
}
