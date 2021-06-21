using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace prescriptionSystem_project
{
    public class Therapist : User
    {
        public Therapist(int nif, string password, string fullName, int phone, string address, DateTime birthDate)
        {
            Nif = nif;
            Password = password;
            FullName = fullName;
            Phone = phone;
            Address = address;
            BirthDate = birthDate;
            Age = GenerateAge();
            UserType = "therapist";
        }
    }
}