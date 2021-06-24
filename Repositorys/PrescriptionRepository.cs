using System.Collections.Generic;
using prescriptionSystem_project.Database;

namespace prescriptionSystem_project.Repositorys
{
    public interface IPrescriptionRepo
    {
        void InsertPrescription(Prescription prescription);
        List<Prescription> getAllPrescriptionsFromPatient_WithAccess(int therapist, int patient);

        List<Prescription> getAllPrescriptionsFromOtherTherapists(int therapist, int patient);

        void updatePrescriptionHistory(int prescriptionid, int therapistnif, int patientnif);
    }

    public class PrescriptionRepository : IPrescriptionRepo
    {
        private DatabaseManager dbManager = DatabaseManager.GetInstance();

        public void InsertPrescription(Prescription prescription)
        {
            dbManager.createPrescription(prescription.PatientNIF, prescription.TherapistNIF, prescription.Item.ToString(), prescription.Description, prescription.Quantity);
        }

        public List<Prescription> getAllPrescriptionsFromPatient_WithAccess(int therapist, int patient)
        { 
            return dbManager.getAllPrescriptionsByPatientWithAccess(patient, therapist);
        }

        public List<Prescription> getAllPrescriptionsFromOtherTherapists(int therapist, int patient)
        {
            return dbManager.getAllPrescriptionsFromOtherTherapist(patient, therapist);
        }

        public void updatePrescriptionHistory(int prescriptionid, int therapistnif, int patientnif)
        {
            dbManager.updatePrescriptionHistory(prescriptionid, therapistnif, patientnif);
        }

    }
}