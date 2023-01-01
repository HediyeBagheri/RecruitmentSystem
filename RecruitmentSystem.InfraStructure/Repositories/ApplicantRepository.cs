using System.Data.SqlClient;
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

 IAmirMoeinBranch
        public void Update(Applicant applicant, int applicantId)
=======
        public void Update(Applicant applicant, int applicantId)
  main
        {
            var cmd = new SqlCommand("Usp_Applicant_Update", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

 IAmirMoeinBranch
            cmd.Parameters.AddWithValue("@Id", applicantId);
=======
            cmd.Parameters.AddWithValue("@Id", id);
 main
            cmd.Parameters.AddWithValue("@Name", applicant.Name);
            cmd.Parameters.AddWithValue("@LastName", applicant.LastName);
            cmd.Parameters.AddWithValue("@FathersName", applicant.FathersName);
            cmd.Parameters.AddWithValue("@Age", applicant.Age);
            cmd.Parameters.AddWithValue("@ServeStatusTypeId", applicant.ServeStatusTypeId);
            cmd.Parameters.AddWithValue("@WorkExperience", applicant.WorkExperience);
            cmd.Parameters.AddWithValue("@SalaryRequest", applicant.SalaryRequest);
            cmd.Parameters.AddWithValue("@JobId", applicant.JobId);
            cmd.Parameters.AddWithValue("@ResumeDescription", applicant.ResumeDescription);


            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public DataTable GetServeStatusData()
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
         public DataTable GetAll(int applicantId) 
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_Applicant_GetData", sqlConnection);
            cmd.Parameters.AddWithValue("@Id", applicantId);

            cmd.CommandType = CommandType.StoredProcedure;



            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }    
    }
}
