using RecruitmentSystem.InfraStructure.ConnectionStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitmentSystem.Model.Models.Users;

namespace RecruitmentSystem.InfraStructure.Contexts
{
    public class RecruitmentContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString.RecruitmentConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
