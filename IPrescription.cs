using System;

namespace prescriptionSystem_project
{
    public enum ItemType
    {
        Medicine,
        Meal,
        Exercise,
        Physiotherapy
    }

    public interface IPrescription
    {
        int PatientNIF { get; set; }
        int TherapistNIF { get; set; }
        ItemType Item { get;}
        DateTime Date { get; set; }
        int Quantity { get; set; }
        string Description { get; set; }
    }
}