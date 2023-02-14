﻿using RecruitmentSystem.Model.Offers;
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
        
        DataTable GetComOfferCooperationType();
        void Add(CompanyJob companyOffer);
        DataTable GetJobData();
        DataTable GetAll();
        void Update(CompanyJob companyOffer);
        DataTable GetById(int id);
        DataTable GetByJobId(int id);

        void Delete(int id);
        DataTable GetName(int id);
        DataTable GetAllRequestForOffers(int companyJobId);
        DataTable GetAllRequestForOffersById(int requestForCJId);
        void AddToRequestForCompanyJobId(RequestForCompanyJob rfcj);
        void DeleteToRequestForCompanyJobId(int rfcjId);
    }
}
