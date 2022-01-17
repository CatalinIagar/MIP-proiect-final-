using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Voting_System.Models {
    public class CandidateModel {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "First Name must be 20 characters or less")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Last Name must be 20 characters or less")]
        public string LastName { get; set; }

        [Required]
        [MinLength(50, ErrorMessage = "Username must be between 50 and 200 characters")]
        [MaxLength(200, ErrorMessage = "Username must be between 50 and 200 characters")]
        public string Description { get; set; }

        [Required]
        public int NrOfVotes { get; set; }
    }

    public class CandidateDbContext : DbContext {
        public DbSet <CandidateModel> Candidates { get; set; }
    }
}
