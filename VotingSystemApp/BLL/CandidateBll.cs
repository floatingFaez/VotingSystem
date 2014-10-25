using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApp.DLL.DAO;
using VotingSystemApp.DLL.Gateway;

namespace VotingSystemApp.BLL
{
    class CandidateBll
    {
        private CandidateGateway aCandidateGateway;

        public CandidateBll()
        {
            aCandidateGateway=new CandidateGateway();
        }

        public string Save(Candidate aCandidate)
        {
            return aCandidateGateway.Save(aCandidate);
        }

        public List<Candidate> GetAllCandidate(Candidate aCandidate)
        {
            return aCandidateGateway.GetAllCandidate(aCandidate);
        }
    }
}
