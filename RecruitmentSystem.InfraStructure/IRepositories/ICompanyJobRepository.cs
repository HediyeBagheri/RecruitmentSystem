using RecruitmentSystem.Model.Offers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.InfraStructure.IRepositories
{
    public interface ICompanyJobRepository
    {
        List<CompanyJob> GetAll();
        DataTable GetComOfferCooperationType();
        void Add(CompanyJob companyOffer);
        DataTable GetJobData();
        DataTable GetAll1();

        DataTable GetName(int id);



    }
}
