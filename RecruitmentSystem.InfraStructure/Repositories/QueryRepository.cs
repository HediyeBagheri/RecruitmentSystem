using RecruitmentSystem.InfraStructure.ConnectionStrings;
using RecruitmentSystem.InfraStructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.InfraStructure.Repositories
{
    public class QueryRepository : IQueryRepository
    {
        protected SqlConnection sqlConnection;
        public QueryRepository()
        {
            sqlConnection = new SqlConnection(ConnectionString.RecruitmentConnectionString);
        }

        public DataTable GetAll(string procdeureName)
        {
            var dt = new DataTable();
            SqlCommand cmd = new SqlCommand(procdeureName, sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();

            SqlDataReader? reader = cmd.ExecuteReader();
            dt.Load(reader);
            sqlConnection.Close();

            return dt;
        }
    }
}
