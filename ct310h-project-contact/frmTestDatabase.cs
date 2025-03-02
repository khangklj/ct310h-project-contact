namespace ct310h_project_contact
{
    public partial class frmTestDatabase : Form
    {
        public frmTestDatabase()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                bool b = clsDatabase.OpenConnection();
                if (!b)
                {
                    return;
                }
                clsDatabase.CloseConnection();
                MessageBox.Show("Connect to database successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void frmTestDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTestAuth_Click(object sender, EventArgs e)
        {
            int? accountID = AuthInfo.AccountID;
            if (accountID == null)
            {
                MessageBox.Show("Can't retrieve auth info");
            } else
            {
                MessageBox.Show($"You are logged with id = {accountID}");
            }
        }
    }
}
