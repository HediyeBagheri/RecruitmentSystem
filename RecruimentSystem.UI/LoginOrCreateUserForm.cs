using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.UI;
using System;
using System.Windows.Forms;

namespace RecruimentSystem.UI
{
    public partial class LoginOrCreateUserForm : Form
    {
        private readonly IUserRepository userRepository;
        private bool isValid;

        public LoginOrCreateUserForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            var frm = new CreateUserForm();
            frm.Show();
            this.Hide();
        }


        private void ValidateForLogin()
        {
            isValid = true;
            if (string.IsNullOrEmpty(txtUserNameLogin.Text))
            {
                MessageBox.Show("Username Is Empty!");
                isValid = false;
            }

            if (txtUserNameLogin.Text.Length > 64)
            {
                MessageBox.Show("Username Lenght Is Not Valid!");
                isValid = false;
            }

            if (txtPassForLogin.Text.Length > 64)
            {
                MessageBox.Show("Password Lenght Is Not Valid");
                isValid = false;
            }
        }

        private void LoginToUserPanel_Click(object sender, EventArgs e)
        {
            ValidateForLogin();
            if (isValid)
            {
                var dt = userRepository.GetUserLoginData(txtUserNameLogin.Text, txtPassForLogin.Text);
                int id = 0;
                int userTypeId = 0;
                foreach (var dataRow in dt.Select())
                {
                    userTypeId = Convert.ToInt32(dataRow["UserTypeId"].ToString());
                    id = Convert.ToInt32(dataRow["ID"].ToString());
                }

                if (userTypeId == 1)
                {
                    var appFrm = new ApplicantPanelForm(id);
                    appFrm.Show();
                    this.Hide();
                }
                else if (userTypeId == 2)
                {
                    var comFrm = new CompanyPanelForm(id);
                    comFrm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("No User Found");
            }
        }




    }
}
