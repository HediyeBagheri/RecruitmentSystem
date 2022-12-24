using RecruitmentSystem.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.InfraStructure.IRepositories
{
    public interface IApplicantRepository
    {
        void Add(Applicant applicant);
        DataTable GetSevrveStatusData();
        DataTable GetJobData();
    }
}
