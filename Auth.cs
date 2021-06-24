using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
using prescriptionSystem_project.Repositorys;

namespace prescriptionSystem_project
{
    
    interface IAuthentication
    {
        bool checkAuthentication(int nif, string password);
    }

    public class Auth : IAuthentication
    {
        public bool checkAuthentication(int nif, string password)
        {
            Debug.Write($"Login efectuado com sucesso : User details nif: {nif} passowrd: {password}");
            return true;
        }
    }

    class Proxy : IAuthentication
    {
        private IAuthentication _authentication;
        private UserRepository userRepo = new UserRepository();
        public Proxy(IAuthentication authentication)
        {
            _authentication = authentication;
        }
        
        public bool checkAuthentication(int nif, string password)
        {
           bool result = userRepo.CheckAuthentication(nif, password);
            
            if (result == true)
            {
                _authentication.checkAuthentication(nif, password);
            }
            else
            {
                Debug.Write($"Erro na incerção de dados, ou Conta não registada!\n");
            }
            return result;
        }
    }
}