using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_System.Models;

namespace Voting_System.Controllers {
    public class CandidateController {
        public static int NewCandidate (string firstName, string lastName, string Description) {

            if (firstName == "") return ErrorCodes.FirstNameNull;
            if (lastName == "") return ErrorCodes.LastPassNull;
            if (Description == "") return ErrorCodes.DescriptionNull;
            if (Description.Length < 50) return ErrorCodes.DescriptionLessThan50;
            if (Description.Length > 200) return ErrorCodes.DescriptionMoreThan200;
 
            CandidateModel candidateModel = new CandidateModel();
            candidateModel.FirstName = firstName;
            candidateModel.LastName = lastName;
            candidateModel.Description = Description;
            candidateModel.NrOfVotes = 0;

            using (CandidateDbContext cdb = new CandidateDbContext()) {
                cdb.Candidates.Add(candidateModel);
                cdb.SaveChanges();
            }
            return ErrorCodes.Succes;
        }
    }
}
