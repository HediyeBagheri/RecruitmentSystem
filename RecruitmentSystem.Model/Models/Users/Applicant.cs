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
        public string FatherName { get; set; }
        public int Age { get; set; }
        public int ServeStatus { get; set;}
    }
}
