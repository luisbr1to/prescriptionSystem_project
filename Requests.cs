namespace prescriptionSystem_project
{
    interface Request
    {
        int Id { get; set; }
        int PrescriptionId { get; set; }
        int TherapistId { get; set; }
        int PatientId { get; set; }
        string Status { get; set; }
    
    }

    public class Requests : Request
    {
        public int Id { get; set; }
        public int PrescriptionId { get; set; }
        public int TherapistId { get; set; }
        public int PatientId { get; set; }
        public string Status { get; set; }

        public Requests(int prescription, int therapist, int patient, string status)
        {
            PrescriptionId = prescription;
            TherapistId = therapist;
            PatientId = patient;
            Status = status;
        }

        public Requests(int id, int prescription, int therapist, int patient, string status)
        {
            Id = id;
            PrescriptionId = prescription;
            TherapistId = therapist;
            PatientId = patient;
            Status = status;
        }
    }
}