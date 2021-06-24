using System.Collections.Generic;
using prescriptionSystem_project.Database;

namespace prescriptionSystem_project.Repositorys
{

    interface IRequestRepo
    {
        List<Requests> getAllRequestsForTherapist(int therapist);

        List<Requests> getAllRequestsForPatient(int patient);

        void InsertRequest(Requests request);

        void updateRequest(int requestId, string status);
    }

    public class RequestsRepository
    {
        private DatabaseManager dbManager = DatabaseManager.GetInstance();

        public List<Requests> getAllRequestsForTherapist(int therapist) //getl all requests for that therapist
        {
            return dbManager.getAllRequestsForTherapist(therapist);
        }

        public List<Requests> getAllRequestsForPatient(int patient) //getl all requests for that therapist
        {
            return dbManager.getAllRequestsForPatient(patient);
        }

        public void InsertRequest(Requests request)
        {
            dbManager.InsertRequest(request);
        }

        public void updateRequest(int requestId, string status)
        {
            dbManager.updateRequest(requestId, status);
        }
    }
}