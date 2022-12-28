﻿using System.Data.SqlClient;
using RecruitmentSystem.InfraStructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitmentSystem.Model.Models.Users;

namespace RecruitmentSystem.InfraStructure.Repositories
{
    public class ApplicantRepository : QueryRepository,IApplicantRepository
    {

        public void Add(Applicant applicant)
        {
            var cmd = new SqlCommand("Usp_Applicant_Add", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", applicant.Name);
            cmd.Parameters.AddWithValue("@LastName", applicant.LastName);
            cmd.Parameters.AddWithValue("@FathersName", applicant.FathersName);
            cmd.Parameters.AddWithValue("@Age", applicant.Age);
            cmd.Parameters.AddWithValue("@WorkExperience", applicant.WorkExperience);
            cmd.Parameters.AddWithValue("@SalaryRequest", applicant.SalaryRequest);
            cmd.Parameters.AddWithValue("@JobName", applicant.JobName);
            cmd.Parameters.AddWithValue("@ResumeDescription", applicant.ResumeDescription);
            cmd.Parameters.AddWithValue("@ServeStatusTypeId", applicant.ServeStatusTypeId);


            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public DataTable GetSevrveStatusData()
        {
            
                DataTable dataTable = new DataTable();

                var cmd = new SqlCommand("Usp_ServeStatusType_Select", sqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;



                sqlConnection.Open();

                var reader = cmd.ExecuteReader();

                dataTable.Load(reader);
                sqlConnection.Close();
                return dataTable;
            
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
    }
}
