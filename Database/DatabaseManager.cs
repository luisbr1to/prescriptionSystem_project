using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace prescriptionSystem_project.Database
{
    public sealed class DatabaseManager
    {
        private DatabaseManager() { }

        private static DatabaseManager _instance;
        public static DatabaseManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DatabaseManager();
            }
            return _instance;
        }


        private string DATE = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

        private string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Brito\\source\\repos\\prescriptionSystem_project\\Database\\Database.mdf;Integrated Security=True";
        
        private SqlCommand _execQuery;
        
        public void addPatient(Patient patient)
        {
            string query = string.Format("INSERT INTO Users VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', 'patient') ", patient.Nif, patient.Password, patient.FullName, patient.Address, patient.Phone, patient.BirthDate, patient.Age);
            createUser(query);
        }

        public void addTherapist(Therapist therapist)
        {
            string query = string.Format("INSERT INTO Users VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', 'therapist') ", therapist.Nif, therapist.Password, therapist.FullName, therapist.Address, therapist.Phone, therapist.BirthDate, therapist.Age);
            createUser(query);
        }

        public void createUser(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Debug.WriteLine("Conectado com sucesso.");
                    _execQuery = new SqlCommand(query, connection);
                    _execQuery.ExecuteNonQuery();
                    _execQuery.Dispose();
                    connection.Close();
                    Debug.WriteLine("Iserido com sucesso.");
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
            }

        }

        public void createPrescription(int therapistnif, int patientnif, string item, string description, int quantity)
        {
            string query= string.Format("INSERT INTO Prescriptions VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", therapistnif,patientnif, item, description, DATE, quantity);
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Debug.WriteLine("Conectado com sucesso.");
                    _execQuery = new SqlCommand(query, connection);
                    _execQuery.ExecuteNonQuery();
                    _execQuery.Dispose();
                    connection.Close();
                    Debug.WriteLine("Iserido com sucesso.");
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
            }
        }

        public void createTreatment(int therapistnif, int patientnif,  string startdate, string enddate, int prescriptionid, string action)
        {
            string query = string.Format("INSERT INTO Treatments VALUES('{0}','{1}','{2}','{3}','{4}','{5}','Active')", therapistnif, patientnif, startdate, enddate, prescriptionid, action);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Debug.WriteLine("Conectado com sucesso.");
                    _execQuery = new SqlCommand(query, connection);
                    _execQuery.ExecuteNonQuery();
                    _execQuery.Dispose();
                    connection.Close();
                    Debug.WriteLine("Iserido com sucesso.");
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
            }
        }

        public User GetUserData(string query)
        {
            User user = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    _execQuery = new SqlCommand(query, connection);

                    using (SqlDataReader oReader = _execQuery.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            int tableNif = int.Parse(oReader["nif"].ToString());
                            string tablePassword = oReader["password"].ToString();
                            string tableName = oReader["fullname"].ToString();
                            string tableAddress = oReader["address"].ToString();
                            int tablePhone = int.Parse(oReader["phone"].ToString());
                            DateTime tableBirth = DateTime.Parse(oReader["birthdate"].ToString());
                            string tableType = oReader["type"].ToString();

                            if (tableType == "patient")
                            {
                                user = new Patient(tableNif, tablePassword, tableName, tablePhone, tableAddress, tableBirth);
                            }
                            else if(tableType == "therapist")
                            {
                                user = new Therapist(tableNif, tablePassword, tableName, tablePhone, tableAddress, tableBirth);
                            }
                            else
                            {
                                user = null;
                            }
                        }
                    }
                    _execQuery.Dispose();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
                user = null;
            }
            return user;
        }

        public List<Tuple<int, string>> GetAllUsers()
        {
            var list = new List<Tuple<int, string>>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    _execQuery = new SqlCommand("SELECT nif, fullname FROM Users WHERE type='patient'", connection);

                    using (SqlDataReader oReader = _execQuery.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            int tableNif = int.Parse(oReader["nif"].ToString());
                            string tableName = oReader["fullname"].ToString();

                            list.Add(new Tuple<int, string>(tableNif, tableName));
                        }
                    }
                    _execQuery.Dispose();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
                list = null;
            }

            return list;

        }


        public List<List<string>> getPatienttreatments(int patientnif)
        {
            var list = new List<List<string>>();
            string query = string.Format("SELECT action, startdate, enddate, prescriptionid, status FROM Treatments WHERE patientid ='{0}' ORDER BY startdate ASC", patientnif);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    _execQuery = new SqlCommand(query, connection);

                    using (SqlDataReader oReader = _execQuery.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            string action = oReader["action"].ToString();
                            string startdate = oReader["startdate"].ToString();
                            string enddate = oReader["enddate"].ToString();
                            string prescriptionid = oReader["prescriptionid"].ToString();
                            string status = oReader["status"].ToString();

                            list.Add(new List<string>() { action, startdate, enddate, prescriptionid, status }); 
                        }
                    }
                    _execQuery.Dispose();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
                list = null;
            }

            return list;
        }

        public void createSession(int therapistnif, int patientnif, int treatmentlistid, string notes)
        {
            string query = string.Format("INSERT INTO Treatments VALUES('{0}','{1}','{2}','{3}','{4}')", therapistnif, patientnif, treatmentlistid, notes, DATE);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Debug.WriteLine("Conectado com sucesso.");
                    _execQuery = new SqlCommand(query, connection);
                    _execQuery.ExecuteNonQuery();
                    _execQuery.Dispose();
                    connection.Close();
                    Debug.WriteLine("Iserido com sucesso.");
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
            }
        }

        public List<List<string>> GetUserPrescriptions(int patientnif)
        {
            var list = new List<List<string>>();
            string query = string.Format("SELECT id, item, date FROM Prescriptions WHERE patientid ='{0}' ORDER BY date ASC", patientnif);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    _execQuery = new SqlCommand(query, connection);

                    using (SqlDataReader oReader = _execQuery.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            string id = oReader["id"].ToString();
                            string item = oReader["item"].ToString();
                            string date = oReader["date"].ToString();

                            list.Add(new List<string>() { id, item, date});
                        }
                    }
                    _execQuery.Dispose();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
                list = null;
            }

            return list;
        }

        public List<List<string>> GetUserTreatments(int patientnif , string type)
        {
            var list = new List<List<string>>();

            string query = string.Format("SELECT id, action, startdate, enddate, status FROM Treatments WHERE patientid ='{0}' AND action ='{1}' AND status ='Active' ORDER BY startdate ASC", patientnif, type);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    _execQuery = new SqlCommand(query, connection);

                    using (SqlDataReader oReader = _execQuery.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            string id = oReader["id"].ToString();
                            string action = oReader["action"].ToString();
                            string startdate = oReader["startdate"].ToString();
                            string enddate = oReader["enddate"].ToString();
                            
                            list.Add(new List<string>() { id, action, startdate, enddate });
                        }
                    }
                    _execQuery.Dispose();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
                list = null;
            }

            return list;
        }
    }
}