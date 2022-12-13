using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using RecruitmentSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruimentSystem.UI
{
    public partial class CreateUserForm : Form
    {
        private readonly IUserRepository userRepository;
        public CreateUserForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void save_Click(object sender, EventArgs e)
        {
            ValidateUser();
            var user = new User()
            {
                UserName = txtUserName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                PhoneNumber = txtPhoneNumber.Text,
                UserTypeId = Convert.ToInt32(txtUserTypeId.Text),
            };
            userRepository.Add(user);
            var frm = new ResumeForm();
            frm.Show();
            
        }

        private void ValidateUser()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
                throw new ArgumentNullException();

            if (txtUserName.Text.Length > 64)
                throw new ArgumentOutOfRangeException();

            if (txtPassword.Text.Length > 64 )
                throw new ArgumentOutOfRangeException();

            if (txtPhoneNumber.Text.Length > 64)
                throw new ArgumentOutOfRangeException();

            if (txtEmail.Text.Length > 64)
                throw new ArgumentOutOfRangeException();

        }

        
    }
}
