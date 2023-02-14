using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.Model.Offers
{
    public class CompanyJob
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [StringLength(128)]
        public string CompanyName { get; set; }
        [StringLength(64)]
        public string JobName { get; set; }
        public decimal SalaryPropose { get; set; }
        [StringLength(64)]
        public string Location { get; set; }
        [StringLength(64)]
        public int MinimumWorkExperience { get; set; }
        [StringLength(64)]
        public int TypeOfCooperationId { get; set; }
        [StringLength(128)]
        public string MinimumEducationDegree { get; set; }
        public string Description { get; set; }
        [StringLength(128)]
        public string ImagePath { get; set; }

        public DateTime Date { get; set; }

    }
}
