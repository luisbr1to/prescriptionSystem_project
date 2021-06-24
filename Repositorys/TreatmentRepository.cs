using System;
using System.Diagnostics.Eventing.Reader;
using prescriptionSystem_project.Database;

namespace prescriptionSystem_project.Repositorys
{
    public interface TreatmentRepo
    {
        void InsertTreatment(Treatment treatment);
    }

    public class TreatmentRepository : TreatmentRepo
    {
        private DatabaseManager dbManager = DatabaseManager.GetInstance();
        public void InsertTreatment(Treatment treatment)
        {
            string strartDate = treatment.StartDate.ToString("yyyy-MM-dd hh:mm:ss");
            string endDate = treatment.StartDate.ToString("yyyy-MM-dd hh:mm:ss");
            
            if(String.IsNullOrEmpty(treatment.PrescriptionId.ToString()))
            {
                dbManager.createTreatment(treatment.TherapistId, treatment.PatientId, strartDate, endDate, treatment.Action.ToString());
            }
            else
            {
                dbManager.createTreatment(treatment.TherapistId, treatment.PatientId, strartDate, endDate, treatment.PrescriptionId, treatment.Action.ToString());
            }
            
        }
    }
}