using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Voting_System.Models {
    public class UserModel {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Username must be between 4 and 20 characters")]
        [MaxLength(20, ErrorMessage = "Username must be between 4 and 20 characters")]
        public string Username { get; set; }

        [Required]
        public int Password { get; set; } // the password will be hashed

        [Required]
        [MaxLength(20, ErrorMessage = "First Name must be 20 characters or less")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Last Name must be 20 characters or less")]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string CNP { get; set; }

        [Required]
        public bool HasVoted { get; set; }

        [Required]
        public int CandidateID { get; set; } // if the user has not voted yet, then CandidateID should be -1
    }

    public class UserDbContext : DbContext {
        public DbSet <UserModel> Users { get; set; }
    }
}