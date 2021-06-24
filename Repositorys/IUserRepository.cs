using System.Collections;
using System.Collections.Generic;

namespace prescriptionSystem_project.Repositorys
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUserById(int nif);
        void InsertUserTherapist(Therapist user);
        void InsertUserPatient(Patient user);
        bool CheckAuthentication(int nif, string password);
        //void DeleteUser(int nif);
        //void UpdateUser(User user);
        //void Save();
    }
}