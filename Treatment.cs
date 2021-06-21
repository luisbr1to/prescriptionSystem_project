using System;
using System.Security;
using prescriptionSystem_project.Database;

namespace prescriptionSystem_project
{
    public class Treatment : ITreatment
    {
        public int TherapistId { get; set; }
        public int PatientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ActionsType Action { get; set; }
        public int PrescriptionId { get; set;}
        public string Status { get; set; }

        protected Treatment(int therapist, int patient, ActionsType actiontype, int prescription, DateTime endDate, string status)
        {
            TherapistId = therapist;
            PatientId = patient;
            StartDate = DateTime.Now;
            EndDate = endDate;
            PrescriptionId = prescription;
            Action = actiontype;
            Status = status;
        }

    }
}