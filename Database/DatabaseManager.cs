using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace prescriptionSystem_project.Database
{
    public sealed class DatabaseManager
    {
        //Singleton + constructor
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

        //Vars
        private string DATE = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

        private static string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Brito\\source\\repos\\prescriptionSystem_project\\Database\\Database.mdf;Integrated Security=True";

        private SqlCommand _execQuery;

        private static SqlConnection connection = new SqlConnection(connectionString);


        //General Methods
        private  void addToDb(string query)
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
                Debug.WriteLine("Degub: {0}", ex);
            }
        }


        //User Related Methods
        public List<User> GetUsers()
        {
            string query = "SELECT * FROM Users";
            var list = new List<User>();

            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int tableNif = int.Parse(reader["nif"].ToString());
                        string tablePassword = reader["password"].ToString();
                        string tableName = reader["fullname"].ToString();
                        string tableAddress = reader["address"].ToString();
                        int tablePhone = int.Parse(reader["phone"].ToString());
                        DateTime tableBirth = DateTime.Parse(reader["birthdate"].ToString());
                        string tableType = reader["type"].ToString();

                        User user = null;
                        if (tableType == "patient")
                        {
                            user = new Patient(tableNif, tablePassword, tableName, tablePhone, tableAddress, tableBirth);
                        }
                        else if (tableType == "therapist")
                        {
                            user = new Therapist(tableNif, tablePassword, tableName, tablePhone, tableAddress, tableBirth);
                        }
                        else
                        {
                            user = null;
                        }
                        list.Add(user);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public User GetUserById(int nif)
        {
            string query = ($"SELECT * FROM Users WHERE nif='{nif}'");
            User user = null;

            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int tableNif = int.Parse(reader["nif"].ToString());
                        string tablePassword = reader["password"].ToString();
                        string tableName = reader["fullname"].ToString();
                        string tableAddress = reader["address"].ToString();
                        int tablePhone = int.Parse(reader["phone"].ToString());
                        DateTime tableBirth = DateTime.Parse(reader["birthdate"].ToString());
                        string tableType = reader["type"].ToString();

                        if (tableType == "patient")
                        {
                            user = new Patient(tableNif, tablePassword, tableName, tablePhone, tableAddress, tableBirth);
                        }
                        else if (tableType == "therapist")
                        {
                            user = new Therapist(tableNif, tablePassword, tableName, tablePhone, tableAddress, tableBirth);
                        }
                        else
                        {
                            user = null;
                        }
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return user;
        }

        public void addPatient(Patient patient)
        {
            string query = string.Format("INSERT INTO Users VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', 'patient') ", patient.Nif, patient.Password, patient.FullName, patient.Address, patient.Phone, patient.BirthDate, patient.Age);
            addToDb(query);
        }

        public void addTherapist(Therapist therapist)
        {
            string query = string.Format("INSERT INTO Users VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', 'therapist') ", therapist.Nif, therapist.Password, therapist.FullName, therapist.Address, therapist.Phone, therapist.BirthDate, therapist.Age);
            addToDb(query);
        }

        public bool verifyAuthentication(int nif, string password)
        {
            string query =
                string.Format(
                    "SELECT CASE WHEN EXISTS (SELECT * FROM Users WHERE nif='{0}' AND password= '{1}') THEN CAST('True' AS VARCHAR(10)) ELSE CAST('False' AS VARCHAR(10)) END",
                    nif, password);
            
            bool result = false;
            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                
                try
                {
                    while (reader.Read())
                        result = bool.Parse(reader[0].ToString());
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }

            return result;
        }


        // Patient Related Methods
        public List<Patient> GetAllPatients()
        {
            var list = new List<Patient>();
            Patient patient;

            string query = "SELECT * FROM Users WHERE type='patient'";
            
            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int nif = int.Parse(reader["nif"].ToString());
                        string password = reader["password"].ToString();
                        string name = reader["fullname"].ToString();
                        string address = reader["address"].ToString();
                        int phone = int.Parse(reader["phone"].ToString());
                        DateTime birthDate = DateTime.Parse(reader["birthdate"].ToString());
                        
                        patient = new Patient(nif, password, name, phone, address, birthDate);
                     
                        list.Add(patient);
                        
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public List<Treatment> GetPatientTreatments(int patientnif)
        {
            var list = new List<Treatment>();
            Treatment treatment;

            string query = string.Format("SELECT * FROM Treatments WHERE patientid ='{0}' ORDER BY startdate ASC", patientnif);

            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int therapistId = int.Parse(reader["therapistid"].ToString());
                        int patientId = int.Parse(reader["patientid"].ToString());
                        DateTime startDate = DateTime.Parse(reader["startdate"].ToString());
                        DateTime endDate = DateTime.Parse(reader["enddate"].ToString());
                        int prescriptionId = int.Parse(reader["prescriptionid"].ToString());
                        ActionsType action = (ActionsType)Enum.Parse(typeof(ActionsType), reader["action"].ToString());
                        string status = reader["status"].ToString();

                        treatment = new Treatment(therapistId, patientId, action, prescriptionId,startDate, endDate, status);

                        list.Add(treatment);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public List<Prescription> GetPatientPrescriptions(int patientnif)
        {   

            var list = new List<Prescription>();
            Prescription prescription;
            string query = string.Format("SELECT * FROM Prescriptions WHERE patientid ='{0}' ORDER BY date ASC", patientnif);

            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        int therapistId = int.Parse(reader["therapistid"].ToString());
                        int patientId = int.Parse(reader["patientid"].ToString());
                        ItemType item = (ItemType)Enum.Parse(typeof(ItemType), reader["item"].ToString());
                        string description = reader["description"].ToString();
                        DateTime date = DateTime.Parse(reader["date"].ToString());
                        int quantity = int.Parse(reader["quantity"].ToString());

                        prescription = new Prescription(id, patientId, therapistId, item, description, date, quantity);

                        list.Add(prescription);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public List<Treatment> GetPatientTreatmentsAction(int patientnif , string type)
        {
            var list = new List<Treatment>();
            Treatment treatment;
            string query = string.Format("SELECT * FROM Treatments WHERE patientid ='{0}' AND action ='{1}' AND status ='Active' ORDER BY startdate ASC", patientnif, type);

            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        int therapistId = int.Parse(reader["therapistid"].ToString());
                        int patientId = int.Parse(reader["patientid"].ToString());
                        DateTime startDate = DateTime.Parse(reader["startdate"].ToString());
                        DateTime endDate = DateTime.Parse(reader["enddate"].ToString());
                        int prescriptionId = int.Parse(reader["prescriptionid"].ToString());
                        ActionsType action = (ActionsType)Enum.Parse(typeof(ActionsType), reader["action"].ToString());
                        string status = reader["status"].ToString();

                        treatment = new Treatment(id,therapistId, patientId, action, prescriptionId, startDate, endDate, status);

                        list.Add(treatment);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        // Therapists Methods
    
        // Prescriptions Methods
        public void createPrescription(int therapistnif, int patientnif, string item, string description, int quantity)
        {
            string query = string.Format("INSERT INTO Prescriptions VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", therapistnif, patientnif, item, description, DATE, quantity);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    addToDb(query);

                    string query2 = "SELECT TOP 1 id FROM Prescriptions ORDER BY id DESC";
                    int id = 0;
                    connection.Open();
                    _execQuery = new SqlCommand(query2, connection);
                    using (SqlDataReader oReader = _execQuery.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            id = int.Parse(oReader["id"].ToString());
                        }
                    }
                    _execQuery.Dispose();
                    connection.Close();

                    string query3 = string.Format("INSERT INTO Prescription_History VALUES('{0}','{1}', '{2}')", id, therapistnif, patientnif);

                    addToDb(query3);
                }
            }
            catch (Exception ex)
            {
                // Manage your exception here
                Debug.WriteLine("Degub: {0}", ex);
            }
        }


        //Prescription History Methods
        public List<Prescription> getAllPrescriptionsByPatientWithAccess(int patient, int therapist)
        {
            string query = ($"SELECT Prescriptions.Id, Prescriptions.therapistid, Prescriptions.patientid, Prescriptions.item, Prescriptions.description, Prescriptions.quantity, Prescriptions.date FROM Prescriptions INNER JOIN Prescription_History ON Prescription_History.prescriptionid = Prescriptions.Id AND Prescription_History.therapistid = '{therapist}' AND Prescriptions.patientid = '{patient}'");
            var list = new List<Prescription>();
            Prescription prescription;

            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        int therapistId = int.Parse(reader["therapistid"].ToString());
                        int patientId = int.Parse(reader["patientid"].ToString());
                        ItemType item = (ItemType)Enum.Parse(typeof(ItemType), reader["item"].ToString());
                        string description = reader["description"].ToString();
                        DateTime date = DateTime.Parse(reader["date"].ToString());
                        int quantity = int.Parse(reader["quantity"].ToString());

                        prescription = new Prescription(id, patientId, therapistId, item, description, date, quantity);

                        list.Add(prescription);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public List<Prescription> getAllPrescriptionsFromOtherTherapist(int patient, int therapist)
        {
            string query = ($"SELECT * FROM Prescriptions WHERE Prescriptions.therapistid <> '{therapist}' AND Prescriptions.patientid = '{patient}'");
            var list = new List<Prescription>();
            Prescription prescription;

            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        int therapistId = int.Parse(reader["therapistid"].ToString());
                        int patientId = int.Parse(reader["patientid"].ToString());
                        ItemType item = (ItemType)Enum.Parse(typeof(ItemType), reader["item"].ToString());
                        string description = reader["description"].ToString();
                        DateTime date = DateTime.Parse(reader["date"].ToString());
                        int quantity = int.Parse(reader["quantity"].ToString());

                        prescription = new Prescription(id, patientId, therapistId, item, description, date, quantity);

                        list.Add(prescription);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public void updatePrescriptionHistory(int prescriptionid, int therapistnif, int patientnif)
        {
            string query3 = string.Format("INSERT INTO Prescription_History VALUES('{0}','{1}', '{2}')", prescriptionid, therapistnif, patientnif);

            addToDb(query3);
        }

        // Treatments Methods
        public void createTreatment(int therapistnif, int patientnif, string startdate, string enddate, int prescriptionid, string action)
        {

            string query = string.Format("INSERT INTO Treatments VALUES('{0}','{1}','{2}','{3}','{4}','{5}','Active')", therapistnif, patientnif, startdate, enddate, prescriptionid, action);

            addToDb(query);
        }

        public void createTreatment(int therapistnif, int patientnif, string startdate, string enddate, string action)
        {

            string query = string.Format("INSERT INTO Treatments VALUES('{0}','{1}','{2}','{3}','{4}','{5}','Active')", therapistnif, patientnif, startdate, enddate, null, action);

            addToDb(query);
        }


        // Session Methods
        public void createSession(int therapistnif, int patientnif, string notes)
        {
            string query = string.Format("INSERT INTO Sessions VALUES('{0}','{1}','{2}','{3}')", therapistnif, patientnif, notes, DATE);

            addToDb(query);
        }

        public int getLastSessionId()
        {
            int id = 0;
            string query = "SELECT TOP 1 id FROM Sessions ORDER BY id DESC"; //busca o id da ultima sessao adicionada

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
                            id = int.Parse(oReader["id"].ToString());
                            Debug.WriteLine("Degub: {0}", id);
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
                id = 0;
            }
            return id;
        }

        public void addSessions_Treatments(int sessionid, int treatmentid)
        {
            string query = string.Format("INSERT INTO Sessions_Treatments VALUES('{0}','{1}')", sessionid, treatmentid);

            addToDb(query);
        }


        // Requests Methods
        public List<Requests> getAllRequestsForTherapist(int therapist)
        {
            List<Requests> list = new List<Requests>();

            string query = $"SELECT * FROM Requests WHERE therapistid ='{therapist}'";

            Requests request;

            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        int prescriptionId = int.Parse(reader["prescriptionId"].ToString());
                        int therapistId = int.Parse(reader["therapistid"].ToString());
                        int patientId = int.Parse(reader["patientid"].ToString());
                        string status = reader["status"].ToString();

                        request = new Requests(id, prescriptionId, therapistId, patientId, status);

                        list.Add(request);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public List<Requests> getAllRequestsForPatient(int patient)
        {
            List<Requests> list = new List<Requests>();

            string query = $"SELECT * FROM Requests WHERE patientid ='{patient}' AND status = 'Pending'";

            Requests request;

            connection.Open();
            _execQuery = new SqlCommand(query, connection);
            try
            {
                var reader = _execQuery.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        int prescriptionId = int.Parse(reader["prescriptionId"].ToString());
                        int therapistId = int.Parse(reader["therapistid"].ToString());
                        int patientId = int.Parse(reader["patientid"].ToString());
                        string status = reader["status"].ToString();

                        request = new Requests(id, prescriptionId, therapistId, patientId, status);

                        list.Add(request);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public void InsertRequest(Requests request)
        {
            string query = $"INSERT INTO Requests VALUES('{request.PrescriptionId}','{request.TherapistId}','{request.PatientId}','{request.Status}')";
            addToDb(query);
        }

        public void updateRequest(int requestId, string status)
        {
            string query = $"UPDATE Requests SET status = '{status}' WHERE id = '{requestId}'";
            addToDb(query);
        }
    }
}