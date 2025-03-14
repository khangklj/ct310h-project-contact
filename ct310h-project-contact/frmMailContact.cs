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

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string fromEmail = "rosalind66@ethereal.email";
                string password = "Cubfdp3ftgVx3EeHPj";
                string toEmail = txtMailTo.Text.Trim();
                string subject = txtMailSubject.Text.Trim();
                string body = txtMailBody.Text.Trim();
                string cc = txtMailCc.Text.Trim();
                string bcc = txtMailBcc.Text.Trim();

                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

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

                if (!string.IsNullOrWhiteSpace(cc) && !Regex.IsMatch(cc, emailPattern))
                {
                    MessageBox.Show("Invalid CC email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMailCc.Focus();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(bcc) && !Regex.IsMatch(bcc, emailPattern))
                {
                    MessageBox.Show("Invalid BCC email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMailBcc.Focus();
                    return;
                }

                EmailService emailService = new EmailService(fromEmail, password);

                emailService.ConstructEmail(toEmail, subject, body, cc, bcc);
                emailService.SendEmail();

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
