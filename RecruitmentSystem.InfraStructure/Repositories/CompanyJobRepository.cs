using Microsoft.Data.SqlClient;
using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.Model.Models.Users;
using RecruitmentSystem.Model.Offers;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlCommand = System.Data.SqlClient.SqlCommand;

namespace RecruitmentSystem.InfraStructure.Repositories
{
    public class CompanyJobRepository : QueryRepository, ICompanyJobRepository
    {
        public DataTable GetComOfferCooperationType()
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_CooperationType_Select", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }

        public void Add(CompanyJob companyOffer)
        {
            var cmd = new SqlCommand("Usp_CompanyJob_Add", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompanyId", companyOffer.CompanyId);
            cmd.Parameters.AddWithValue("@CompanyName", companyOffer.CompanyName);
            cmd.Parameters.AddWithValue("@SalaryPropose", companyOffer.SalaryPropose);
            cmd.Parameters.AddWithValue("@JobName", companyOffer.JobName);
            cmd.Parameters.AddWithValue("@Location", companyOffer.Location);
            cmd.Parameters.AddWithValue("@MinimumWorkExperience", companyOffer.MinimumWorkExperience);
            cmd.Parameters.AddWithValue("@TypeOfCooperationId", companyOffer.TypeOfCooperationId);
            cmd.Parameters.AddWithValue("@MinimumEducationDegree", companyOffer.MinimumEducationDegree);
            cmd.Parameters.AddWithValue("@Description", companyOffer.Description);
            cmd.Parameters.AddWithValue("@Date", companyOffer.Date);
            cmd.Parameters.AddWithValue("@ImagePath", companyOffer.ImagePath);


            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void Update(CompanyJob companyOffer)
        {
            var cmd = new SqlCommand("Usp_CompanyJob_Update", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", companyOffer.Id);
            cmd.Parameters.AddWithValue("@CompanyName", companyOffer.CompanyName);
            cmd.Parameters.AddWithValue("@SalaryPropose", companyOffer.SalaryPropose);
            cmd.Parameters.AddWithValue("@JobName", companyOffer.JobName);
            cmd.Parameters.AddWithValue("@Location", companyOffer.Location);
            cmd.Parameters.AddWithValue("@MinimumWorkExperience", companyOffer.MinimumWorkExperience);
            cmd.Parameters.AddWithValue("@TypeOfCooperationId", companyOffer.TypeOfCooperationId);
            cmd.Parameters.AddWithValue("@MinimumEducationDegree", companyOffer.MinimumEducationDegree);
            cmd.Parameters.AddWithValue("@Description", companyOffer.Description);
            cmd.Parameters.AddWithValue("@ImagePath", companyOffer.ImagePath);


            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public DataTable GetJobData()
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_Job_Select", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_CompanyJob_Select", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;



            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }


        public DataTable GetName(int id)
        {

            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_CompanyJob_GetName", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;

        }


        public DataTable GetById(int id)
        {

            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_CompanyJob_GetById", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompanyId", id);

            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }

        public DataTable GetByJobId(int id)
        {

            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_CompanyJob_GetByJobId", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }

        public void Delete(int id)
        {
            var cmd = new SqlCommand("Usp_CompanyJob_Delete", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();

            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            
        }

        public DataTable GetAllRequestForOffers(int companyJobId)
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_CompanyJob_GetAllRequestForOffer", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompanyJobId", companyJobId);

            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        public DataTable GetAllRequestForOffersById(int requestForCJId)
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_CompanyJob_GetAllInfoForOffer", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RequestForCompanyJobId", requestForCJId);

            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        public void AddToRequestForCompanyJobId(RequestForCompanyJob rfcj)
        {
            var cmd = new SqlCommand("Usp_RequestForCompanyJob_Add", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompanyJobId", rfcj.CompanyJobId);
            cmd.Parameters.AddWithValue("@UserId", rfcj.UserId);
            cmd.Parameters.AddWithValue("@Date", rfcj.Date);
            cmd.Parameters.AddWithValue("@ResumePath", rfcj.ResumePath);
            
            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void DeleteToRequestForCompanyJobId(int rfcjId)
        {
            var cmd = new SqlCommand("Usp_RequestForCompanyJob_Delete", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RequestForCompanyJobId", rfcjId);

            sqlConnection.Open();

            cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }

    }
}

