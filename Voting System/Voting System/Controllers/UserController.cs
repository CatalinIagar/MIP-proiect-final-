using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_System.Models;


namespace Voting_System.Controllers {
    public class UserController {
        public static void NewUser (string uname, int pwd, string fn, string ln, DateTime dob, string cnp) {
            UserModel userModel = new UserModel();
            userModel.Username = uname;
            userModel.Password = pwd;
            userModel.FirstName = fn;
            userModel.LastName = ln;
            userModel.DateOfBirth = dob;
            userModel.CNP = cnp;
            userModel.HasVoted = false;
            userModel.CandidateID = -1;

            using(UserDbContext udb = new UserDbContext()) {
                udb.Users.Add(userModel);
            }
        }
    }
}
