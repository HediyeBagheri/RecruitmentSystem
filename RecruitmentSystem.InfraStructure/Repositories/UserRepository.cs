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

        public void Update()
        {
            throw new NotImplementedException();
        }

        
    }
}
