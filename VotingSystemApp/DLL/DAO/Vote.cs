using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApp.DLL.DAO
{
    class Vote
    {
        public int  Id { get; set; }
        public int  CandidateId { get; set; }
        public Candidate ACandidate { get; set; }
        public string Email { get; set; }
        
    }
}
