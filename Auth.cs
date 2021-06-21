using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace prescriptionSystem_project
{
    public class Auth
    {
        public Auth() //login
        {
        }

        public User CheckAuth(int nif, string pass)
        {
            User user;

            Database.DatabaseManager DB = Database.DatabaseManager.GetInstance();

            string query = string.Format("SELECT * FROM Users WHERE nif='{0}' AND password= '{1}'", nif, pass);
           
            user = DB.GetUserData(query);
            return user;
        }
    }
}