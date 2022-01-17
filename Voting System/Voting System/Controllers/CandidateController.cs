using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_System.Models;

namespace Voting_System.Controllers {
    public class CandidateController {
        public void NewCandidate (string fn, string ln, string desc) {
            CandidateModel candidateModel = new CandidateModel();
            candidateModel.FirstName = fn;
            candidateModel.LastName = ln;
            candidateModel.Description = desc;
            candidateModel.NrOfVotes = 0;

            using (CandidateDbContext cdb = new CandidateDbContext()) {
                cdb.Candidates.Add(candidateModel);
            }
        }
    }
}
