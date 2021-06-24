using System;

namespace prescriptionSystem_project
{
    public class Prescription : IPrescription
    {
        public int Id { get; set; }
        public int PatientNIF { get; set; }
        public int TherapistNIF { get; set; }
        public ItemType Item { get; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

        public Prescription(int patientNif, int therapistNif, ItemType item, string description, DateTime date, int quantity)
        {
            PatientNIF = patientNif;
            TherapistNIF = therapistNif;
            Item = item;
            Description = description;
            Date = date;
            Quantity = quantity;
        }

        public Prescription(int id, int patientNif, int therapistNif, ItemType item, string description, DateTime date, int quantity)
        {
            Id = id;
            PatientNIF = patientNif;
            TherapistNIF = therapistNif;
            Item = item;
            Description = description;
            Date = date;
            Quantity = quantity;
        }

        public string DisplayMemberChecklist
        {
            get
            {
                return Item + ", (" + Date + ")";
            }
        }

    }
}