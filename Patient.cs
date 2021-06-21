using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace prescriptionSystem_project
{
    public class Patient : User
    {

        public Patient(int nif, string password, string fullName, int phone, string address, DateTime birthDate)
        {
            Nif = nif;
            Password = password;
            FullName = fullName;
            Phone = phone;
            Address = address;
            BirthDate = birthDate.Date;
            Age = GenerateAge();
            UserType = "patient";
        }
    }
}