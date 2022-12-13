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
    public partial class LoginOrCreateUserForm : Form
    {
        private readonly IUserRepository userRepository;
        public LoginOrCreateUserForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            var frm = new CreateUserForm();
            frm.Show();
        }


        private void ValidateForLogin()
        {
            if (string.IsNullOrEmpty(txtUserNameLogin.Text))
                throw new ArgumentNullException();

            if(string.IsNullOrEmpty(userTypeCmbBox.Text)) 
                throw new ArgumentNullException();

            if (txtUserNameLogin.Text.Length > 64)
                throw new ArgumentOutOfRangeException();

            if (txtPassForLogin.Text.Length > 64)
                throw new ArgumentOutOfRangeException();
        }

        private void loginToUserPanel_Click(object sender, EventArgs e)
        {
            ValidateForLogin();
            if (userTypeCmbBox.Text == "Applicant")
            {
                var frm = new ApplicantPanelForm();
                frm.Show();
            }
            else
            {
                var frm = new CompanyPanelForm();
                frm.Show();
            }
        }
    }
}
