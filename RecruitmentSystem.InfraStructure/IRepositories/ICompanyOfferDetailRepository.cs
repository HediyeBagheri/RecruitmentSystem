using RecruitmentSystem.Model.Offers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.InfraStructure.IRepositories
{
    public interface ICompanyOfferDetailRepository
    {
        List<CompanyOfferDetail> GetAll();
        DataTable GetComOfferCooperationType();
        void Add(CompanyOfferDetail companyOffer,int companyId);
        DataTable GetJobData();
       // DataTable Get();
    }
}
