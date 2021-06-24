using System.Collections.Generic;
using System.Linq;
using prescriptionSystem_project.Database;

namespace prescriptionSystem_project.Repositorys
{
    public interface IPatientRepo
    {
        List<Patient> GetAllPatients();
        List<Treatment> GetPatientTreatmentsByNif(int nif);
        List<Prescription> GetPatientPrescriptionsByNif(int nif);
        List<Treatment> GetPatientTreatmentsByAction(int nif, string action);
    }

    public class PatientRepository : IPatientRepo
    {
        private DatabaseManager dbManager = DatabaseManager.GetInstance();

        public List<Patient> GetAllPatients() //get all users
        {
            return dbManager.GetAllPatients();
        }

        public List<Treatment> GetPatientTreatmentsByNif(int nif)
        {
            return dbManager.GetPatientTreatments(nif);
        }

        public List<Prescription> GetPatientPrescriptionsByNif(int nif)
        {
            return dbManager.GetPatientPrescriptions(nif);
        }

        public List<Treatment> GetPatientTreatmentsByAction(int nif, string type)
        {
            return dbManager.GetPatientTreatmentsAction(nif, type);
        }
    }
}