using Microsoft.Data.SqlClient;
using RecruitmentSystem.InfraStructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.InfraStructure.Repositories
{
    public class ForAdminRepository : QueryRepository,IForAdminRepository
    {
        public DataTable GetApplicantInfo()
        {
            DataTable dataTable = new DataTable();

            var cmd = new System.Data.SqlClient.SqlCommand("Usp_Applicant_ForAdmin", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();

            var reader = cmd.ExecuteReader();

            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;

        }
    }
}
