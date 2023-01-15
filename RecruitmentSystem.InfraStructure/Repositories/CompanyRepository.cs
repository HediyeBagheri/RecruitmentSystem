using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.Model.Models.Users;
using System.Data;
using System.Data.SqlClient;

namespace RecruitmentSystem.InfraStructure.Repositories
{
    public class CompanyRepository : QueryRepository, ICompanyRepository
    {
        public void Update(Company company, int id)
        {
            var cmd = new SqlCommand("Usp_Company_Update", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", company.Name);
            cmd.Parameters.AddWithValue("@ManagerName", company.ManagerName);
            cmd.Parameters.AddWithValue("@Business", company.Business);
            cmd.Parameters.AddWithValue("@Address", company.Address);
            cmd.Parameters.AddWithValue("@ImagePath", company.ImagePath);

            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public DataTable GetAllById(int companyId)
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_Company_GetData", sqlConnection);
            cmd.Parameters.AddWithValue("@Id", companyId);

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

            var cmd = new SqlCommand("Usp_Company_Select", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;



            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }

    }
}
