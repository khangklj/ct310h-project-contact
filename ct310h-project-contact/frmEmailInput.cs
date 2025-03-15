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
    public partial class frmEmailInput : Form
    {
        public string EnteredEmail;

        public frmEmailInput()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string inputEmail = txtEmailInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(inputEmail) || !Regex.IsMatch(inputEmail, emailPattern))
            {
                MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailInput.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.EnteredEmail = inputEmail;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
