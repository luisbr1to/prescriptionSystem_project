namespace prescriptionSystem_project
{
    public interface ISession
    {
        int TherapistId { get; set; }
        int PatientId { get; set; }
        Treatment Treatments { get; set; }
        string Notes { get; set; }
    }

    public class Session : ISession
    {
        public int TherapistId { get; set; }
        public int PatientId { get; set; }
        public Treatment Treatments { get; set; }
        public string Notes { get; set; }

        public Session(int therapist, int patient, Treatment treatment, string notes)
        {
            TherapistId = therapist;
            PatientId = patient;
            Treatments = treatment;
            Notes = notes;
        }
    }
}