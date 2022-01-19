using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System
{
    public class ErrorCodes
    {
        public readonly static int UsernameExistent = 0;
        public readonly static int UsernameNull = 1;
        public readonly static int PasswordNull = 2;
        public readonly static int FirstNameNull = 3;
        public readonly static int LastPassNull = 4;
        public readonly static int DOBNull = 5;
        public readonly static int CNPNULL = 6;
        public readonly static int CNPLengthError = 7;
        public readonly static int InvalidCNP = 8;
        public readonly static int Succes = 9;

        public readonly static int DescriptionLessThan50 = 10;
        public readonly static int DescriptionMoreThan200 = 11;
        public readonly static int DescriptionNull = 12;

    }
}
