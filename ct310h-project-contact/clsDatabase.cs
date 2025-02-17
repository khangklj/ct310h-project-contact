using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ct310h_project_contact
{
    internal class clsDatabase
    {
        public static SqlConnection? conn;

        public static bool OpenConnection()
        {
            try
            {
                ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
                IConfiguration configuration = configurationBuilder.AddUserSecrets<clsDatabase>().Build();
                string strConn = configuration.GetSection("dbConnection")["connString"];
                string str = strConn;
                conn = new SqlConnection(str);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                conn!.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
