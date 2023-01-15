using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.Model.Models.Users;
using System.Data;
using System.Data.SqlClient;

namespace RecruitmentSystem.InfraStructure.Repositories
{
    public class ApplicantRepository : QueryRepository, IApplicantRepository
    {
        public void Update(Applicant applicant, int applicantId)
        {
            var cmd = new SqlCommand("Usp_Applicant_Update", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", applicantId);
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
        public DataTable GetAllById(int applicantId)
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

        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_Applicant_Select", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;



            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
    }
}
