using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ct310h_project_contact
{
    internal static class AuthInfo
    {
        // Remove the default value = 1 after implementing login function
        public static int? accountID = 1;    

        public static int? AccountID { get { return accountID; } }

        public static void SetAuth(int id)
        {            
            accountID = id;
        }
        public static void ClearAuth()
        {
            accountID = null;
        }
    }
}
