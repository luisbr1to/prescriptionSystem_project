using System;

namespace prescriptionSystem_project
{
    public interface IUser
    {
        int Nif { get; set; }
        string Password { get; set; }
        string FullName { get; set; }
        int Phone { get; set; }
        string Address { get; set; }
        DateTime BirthDate { get; set; }
        int Age { get; set; }
        string UserType { get;}

    }

    public abstract class User : IUser
    {
        public int Nif { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string UserType { get; protected set; }

        public int GenerateAge()
        {
            return (DateTime.Now.Year - BirthDate.Year);
        }
    }
}