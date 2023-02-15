using System.ComponentModel.DataAnnotations;

namespace RecruitmentSystem.Model.Models.Users
{
    public class Applicant
    {
        public int Id { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(64)]
        public string LastName { get; set; }

        [StringLength(64)]
        public string FathersName { get; set; }

        public int? Age { get; set; }

        public int ServeStatusTypeId { get; set;}

        public string WorkExperience { get; set; }

        public decimal SalaryRequest { get; set; }

        [StringLength(64)]
        public int JobId { get; set; }

        public string ImagePath { get; set; }
        public string ResumePath { get; set; }
    }
}
