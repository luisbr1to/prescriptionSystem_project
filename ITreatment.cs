using System;

namespace prescriptionSystem_project
{
    public enum ActionsType
    {
        Prescription,
        Exercice,
        Surgery,
        Physiotherapy,
        Diet
    }

    public interface ITreatment
    {
        int Id { get; set; }
        int TherapistId { get; set; }
        int PatientId { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        ActionsType Action { get; set; }
        int PrescriptionId { get; set; }
        string Status { get; set; }
    }
}