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
 IAmirMoeinBranch
        void Update(Applicant applicant, int applicantId);
        DataTable GetServeStatusData();
=======
        void Update(Applicant applicant, int applicantId);
        DataTable GetSevrveStatusData();
  main
        DataTable GetJobData();
        DataTable GetAll(int applicantId);
    }
}
