using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApp.DLL.DAO;

namespace VotingSystemApp.DLL.Gateway
{
    class CandidateGateway
    {
        private SqlConnection connection;

        public CandidateGateway()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString);
        }

        public string Save(Candidate aCandidate)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Candidate VALUES('{0}','{1}')", aCandidate.Name,
                aCandidate.Symbol);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRow = command.ExecuteNonQuery();
            if (affectedRow>0)
            {
                return @"Candidate has been saved sucessfully";
            }
            return @"Candidate save failed";
        }

        public List<Candidate> GetAllCandidate(Candidate aCandidate)
        {
            connection.Open();

        }

 
    }
}
