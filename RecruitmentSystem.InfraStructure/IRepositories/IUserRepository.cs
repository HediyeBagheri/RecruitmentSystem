using RecruitmentSystem.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RecruitmentSystem.InfraStructure.IRepositories
{
    public interface IUserRepository : IQueryRepository
    {
        void Add(User user);
        void Update();

            
    }
}
