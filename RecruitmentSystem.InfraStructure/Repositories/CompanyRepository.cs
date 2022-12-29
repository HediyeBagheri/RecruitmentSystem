using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.InfraStructure.Repositories
{
    public class CompanyRepository : QueryRepository,ICompanyRepository
    {
        public void Update(Company company)
        {
            var cmd = new SqlCommand("Usp_Company_Update", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", company.Id);
            cmd.Parameters.AddWithValue("@Name", company.Name);
            cmd.Parameters.AddWithValue("@ManagerName", company.ManagerName);
            cmd.Parameters.AddWithValue("@Business", company.Business);
            cmd.Parameters.AddWithValue("@Address", company.Address);


            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public DataTable GetAll(int companyId)
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
    }
}
