using System.ComponentModel.DataAnnotations;

namespace RecruitmentSystem.Model.Models.Users
{
    public class Company
    {
        public int Id { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(64)]
        public string ManagerName { get; set; }

        [StringLength(64)]
        public string Business { get; set; }

        [StringLength(128)]
        public string Address { get; set; }

        [StringLength(128)]
        public string ImagePath { get; set; }
    }
}
