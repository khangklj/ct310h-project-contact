using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ct310h_project_contact
{
    public partial class frmContactDetails : Form
    {
        private int contactID;

        public frmContactDetails(int contactID)
        {
            InitializeComponent();
            this.contactID = contactID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContactDetails_Load(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();

                string query = @"SELECT c.Contact_ID, c.Contact_Name, c.Contact_PhoneNumber, 
                                c.Contact_Favorite, c.Contact_Description, 
                                cg.ContactGroup_Name 
                         FROM Contact c
                         LEFT JOIN ContactGroup cg ON c.ContactGroup_ID = cg.ContactGroup_ID
                         WHERE c.Contact_ID = @contactID";

                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);
                cmd.Parameters.AddWithValue("@contactID", this.contactID);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtContactID.Text = reader["Contact_ID"].ToString();
                    txtContactName.Text = reader["Contact_Name"].ToString();
                    txtContactPhoneNumber.Text = reader["Contact_PhoneNumber"].ToString();
                    chkFavorite.Checked = Convert.ToBoolean(reader["Contact_Favorite"]);
                    txtContactDescription.Text = reader["Contact_Description"].ToString();

                    txtContactGroup.Text = reader["ContactGroup_Name"] != DBNull.Value
                        ? reader["ContactGroup_Name"].ToString()
                        : "No Group";
                }

                reader.Close();
                cmd.Dispose();
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading contact details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
