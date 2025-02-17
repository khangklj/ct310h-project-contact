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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
