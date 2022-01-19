using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_System.Models;


namespace Voting_System.Controllers {
    public class UserController {
        public static int NewUser (string username, string password, string firstName, string lastName, DateTime dateOfBirth, string cnp) {
            using (UserDbContext udb = new UserDbContext()) {

                int query = (from u in udb.Users
                             where u.Username == username
                             select u).Count();

                if (username == "") return ErrorCodes.UsernameNull;
                if (query != 0) return ErrorCodes.UsernameExistent;
                if (password == "") return ErrorCodes.PasswordNull;
                if (firstName == "") return ErrorCodes.FirstNameNull;
                if (lastName == "") return ErrorCodes.LastPassNull;
                if (dateOfBirth == null) return ErrorCodes.DOBNull;

                if (cnp == "") return ErrorCodes.CNPNULL;
                if (cnp.Length != 13) return ErrorCodes.CNPLengthError;

                string constCNP = "279146358279";
                int c = 0;
                for(int i =0; i < 12; i++)
                {
                    c += (int.Parse(cnp[i].ToString()) * int.Parse(constCNP[i].ToString()));
                }
                int rez = c % 11;
                if (rez == 10) rez = 1;
                if (rez != int.Parse(cnp[12].ToString())) return ErrorCodes.InvalidCNP;

                UserModel userModel = new UserModel();
                userModel.Username = username;
                userModel.Password = password.GetHashCode();
                userModel.FirstName = firstName;
                userModel.LastName = lastName;
                userModel.DateOfBirth = dateOfBirth;
                userModel.CNP = cnp;
                userModel.HasVoted = false;
                userModel.CandidateID = -1;

                udb.Users.Add(userModel);
                udb.SaveChanges();
            }
            return ErrorCodes.Succes;
        }

        public static bool UserExists(string username, int hashed_pwd) {
            //int hashed_pwd = pwd.GetHashCode();
            using (UserDbContext udb = new UserDbContext()) {
                int count = (from u in udb.Users
                             where u.Username == username && u.Password == hashed_pwd
                             select u
                             ).Count();

                return (count > 0);
            }
        }

        public static int GetUserID(string username) {
            Console.WriteLine(username);
            using (UserDbContext udb = new UserDbContext()) {
                UserModel user = udb.Users.Where(i => i.Username == username).First();

                return user.ID;
            }
        }

        public static void ChangeVoteState (int userID, int candidateID) {
            using (UserDbContext udb = new UserDbContext()) {
                UserModel user = (from u in udb.Users
                                  where u.ID == userID
                                  select u).First();

                user.HasVoted = true;
                user.CandidateID = candidateID;
                udb.SaveChanges();
            }
            
        }

        public static bool GetVoteState (int userID) {
            using (UserDbContext udb = new UserDbContext()) {
                return (from u in udb.Users
                                  where u.ID == userID
                                  select u.HasVoted
                                  ).First();

            }
        }
    }
}
