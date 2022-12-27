using RecruitmentSystem.InfraStructure.ConnectionStrings;
using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RecruitmentSystem.InfraStructure.Repositories
{
    public class UserRepository : QueryRepository, IUserRepository
    {
        public void Add(User user)
        {
                var cmd = new SqlCommand("Usp_User_SignUp", sqlConnection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@UserType", user.UserTypeId);
                cmd.Parameters.AddWithValue("@PassWord", user.Password);
                cmd.Parameters.AddWithValue("@TelephoneNum", user.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", user.Email);


                sqlConnection.Open();

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
        }

        public DataTable GetUserTypeData()
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_UserType_Select", sqlConnection);

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

        public DataTable GetUserLoginData(string UserName,string Password)
        {
            DataTable dataTable = new DataTable();

            var cmd = new SqlCommand("Usp_User_Login", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@PassWord", Password);

            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;

        }

        public void CompanyUpdate(int Id,Company company)
        {
            var cmd = new SqlCommand("Usp_User_SignUp", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserName", company.Name);
            cmd.Parameters.AddWithValue("@UserType", company.ManagerName);
            cmd.Parameters.AddWithValue("@PassWord", company.Business);
            cmd.Parameters.AddWithValue("@TelephoneNum", company.Address);


            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void CompanyUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
