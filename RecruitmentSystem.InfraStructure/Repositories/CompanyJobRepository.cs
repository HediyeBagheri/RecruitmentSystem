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
    public class CompanyOfferDetailRepository : QueryRepository, ICompanyOfferDetailRepository
    {


        public List<CompanyJob> GetAll()
        {
            return new List<CompanyJob>
            {
                new CompanyJob
                {

                        Id = 1,
                        CompanyName = "استدیو پیکسیون",
                        SalaryPropose = 12000000,
                        JobName = "طراح سایت (Wordpress)",
                        Location = "تهران",
                        MinimumWorkExperience = 3,
                        TypeOfCooperationId = 1,
                        MinimumEducationDegree = "کارشناسی",
                        Description = "مسلط به وردپرس، المنتور و پلاگین های مرتبط",
                        ImagePath = @"C:\Users\ADMIN\Pictures\pisicon.png"


                },

                new CompanyJob
                {
                    Id = 2,
                    CompanyName = "شرکت سهلان",
                    SalaryPropose = 7000000,
                    JobName = "طراح معماری",
                    Location = "تهران",
                    MinimumWorkExperience = 3,
                    TypeOfCooperationId = 2,
                    MinimumEducationDegree = "کارشناسی",
                    Description = "مسلط به نرم افزارهای ,AutoCad,3D Max ,Sketch up ,V ray, Photoshop",
                    ImagePath = @"C:\Users\ADMIN\Pictures\sahlan.png"
                },
                new CompanyJob
                {
                    Id = 2,
                    CompanyName = "شرکت صنایع",
                    SalaryPropose = 9000000,
                    JobName = "مسئول دفتر ",
                    Location = "تهران",
                    MinimumWorkExperience = 3,
                    TypeOfCooperationId = 2,
                    MinimumEducationDegree = "کارشناسی",
                    Description = "تسلط بر نرم افزارهای WORD و EXCEL و OUTLOOK",
                    ImagePath = @"C:\Users\ADMIN\Pictures\sanaye.png"
                }

            };
        }

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

            cmd.Parameters.AddWithValue("@CompanyName", companyOffer.CompanyName);
            cmd.Parameters.AddWithValue("@SalaryPropose", companyOffer.SalaryPropose);
            cmd.Parameters.AddWithValue("@JobName", companyOffer.JobName);
            cmd.Parameters.AddWithValue("@Location", companyOffer.Location);
            cmd.Parameters.AddWithValue("@MinimumWorkExperience", companyOffer.MinimumWorkExperience);
            cmd.Parameters.AddWithValue("@TypeOfCooperationId", companyOffer.TypeOfCooperationId);
            cmd.Parameters.AddWithValue("@MinimumEducationDegree", companyOffer.MinimumEducationDegree);
            cmd.Parameters.AddWithValue("@Description", companyOffer.Description);
            //cmd.Parameters.AddWithValue("@ImagePath", companyOffer.ImagePath);


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

        public DataTable GetAll1()
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
    }
}

