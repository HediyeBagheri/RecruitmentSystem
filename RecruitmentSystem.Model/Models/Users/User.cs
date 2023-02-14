using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.Model.Models.Users
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(64)]
        public string UserName { get; set; }

        public int UserTypeId { get; set; }

        [StringLength(64)]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        [StringLength(64)]
        public string Email { get; set; }
    }
}
