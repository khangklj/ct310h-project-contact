using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ct310h_project_contact
{
    internal class EmailService
    {
        private string smtpServer;
        private int smtpPort;
        private string email;
        private string password;
        private MailMessage msg;

        public string? ToEmail { get; private set; }
        public string? Subject { get; private set; }
        public string? Body { get; private set; }
        public string? CC { get; private set; }
        public string? BCC { get; private set; }

        public EmailService(string email, string password, string smtpServer = "smtp.ethereal.email", int smtpPort = 587)
        {
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.email = email;
            this.password = password;
            this.msg = new MailMessage();
            
        }

        public void ConstructEmail(string toEmail, string subject, string body, [Optional] string cc, [Optional] string bcc)
        {
            ToEmail = toEmail;
            Subject = subject;
            Body = body;
            CC = cc;
            BCC = bcc;

            // Construct the MailMessage object
            msg.From = new MailAddress(email);
            msg.To.Clear();  // Clear any existing recipients
            msg.To.Add(ToEmail!);
            msg.Subject = Subject;
            msg.Body = Body;

            if (!string.IsNullOrWhiteSpace(CC))
            {
                msg.CC.Clear();  // Clear existing CCs
                msg.CC.Add(CC);
            }

            if (!string.IsNullOrWhiteSpace(BCC))
            {
                msg.Bcc.Clear();  // Clear existing BCCs
                msg.Bcc.Add(BCC);
            }
        }

        public void SendEmail()
        {
            try
            {
                using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
                {
                    NetworkCredential cred = new NetworkCredential(email, password);
                    client.Credentials = cred;
                    client.EnableSsl = true;

                    client.Send(msg);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                msg.Attachments.Clear();  // Clear attachments after sending
            }
        }

        public void AddAttachments(List<string>? attachments)
        {
            // Clear existing attachments
            msg.Attachments.Clear();

            if (attachments != null)
            {
                foreach (var attachmentPath in attachments)
                {
                    if (!string.IsNullOrWhiteSpace(attachmentPath))
                    {
                        var attachment = new Attachment(attachmentPath);
                        msg.Attachments.Add(attachment);
                    }
                }
            }
        }
        
    }
}
