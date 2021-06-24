using prescriptionSystem_project.Database;

namespace prescriptionSystem_project.Repositorys
{

    public interface SessionRepo
    {
        void InsertSession(int therapist, int patient, string notes);
        int GetLastSessionId();
        void addSessions_Treatments(int sessionId, int treatmentId);
    }

    public class SessionRepository : SessionRepo
    {
        private DatabaseManager dbManager = DatabaseManager.GetInstance();
        public void InsertSession(int therapist, int patient, string notes)
        {
            dbManager.createSession(therapist, patient, notes);
        }

        public int GetLastSessionId()
        {
            return dbManager.getLastSessionId();
        }

        public void addSessions_Treatments(int sessionId, int treatmentId)
        {
            dbManager.addSessions_Treatments(sessionId, treatmentId);
        }
    }
}