using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ct310h_project_contact
{
    internal static class AuthService
    {
        public static int? accountID;

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
