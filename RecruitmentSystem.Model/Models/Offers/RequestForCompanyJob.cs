using System;

namespace RecruitmentSystem.Model.Offers
{
    public class RequestForCompanyJob
    {
        public int Id { get; set; }
        public int CompanyJobId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string ResumePath { get; set; }

    }
}
