using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.Model.Offers
{
    public class CompanyOfferDetail
    {
        public int Id { get; set; }
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
        public string Descreption { get; set; }
        [StringLength(128)]
        public string ImagePath { get; set; }

    }
}
