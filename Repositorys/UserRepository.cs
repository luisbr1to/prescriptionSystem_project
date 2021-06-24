using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using prescriptionSystem_project.Database;

namespace prescriptionSystem_project.Repositorys
{
    public class UserRepository : IUserRepository
    {
        private DatabaseManager dbManager = DatabaseManager.GetInstance();

        public List<User> GetUsers() //get all users
        {
            return dbManager.GetUsers().ToList();
        }

        public User GetUserById(int nif) //get user by nif
        {
            return dbManager.GetUserById(nif);
        }

        public void InsertUserTherapist(Therapist therapist)
        {
            dbManager.addTherapist(therapist);
        }

        public void InsertUserPatient(Patient patient)
        {
            dbManager.addPatient(patient);
        }

        public bool CheckAuthentication(int nif, string password)
        {
            return dbManager.verifyAuthentication(nif, password);
        }

    }
}