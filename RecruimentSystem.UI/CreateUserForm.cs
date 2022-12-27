using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecruimentSystem.UI
{
    public partial class CreateUserForm : Form
    {
        private readonly IUserRepository userRepository;
        private bool isValid = true;
        public CreateUserForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            var dt = userRepository.GetUserTypeData();
            KeyValue keyValue;

            List<KeyValue> list = new List<KeyValue>();
            foreach (var dataRow in dt.Select())
            {
                keyValue = new KeyValue()
                {
                    Value = Convert.ToInt32(dataRow["Value"].ToString()),
                    Key = dataRow["Key"].ToString(),
                };
                list.Add(keyValue);
            }
            cmbUserType.DataSource = list;
            cmbUserType.ValueMember = "Value";
            cmbUserType.DisplayMember = "Key";
        }

        private void ValidateUser()
        {
            isValid = true;

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Username Is Empty!");
                isValid = false;
            }

            if (txtUserName.Text.Length > 18 || txtUserName.Text.Length < 3)
            {
                MessageBox.Show("Username Lenght Must Be More Then 3 Letters And Less Than 18!");
                isValid = false;
            }

            if (txtPassword.Text.Length > 18 || txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password Characters Must Be Between 8 And 18 Letters!");
                isValid = false;
            }

            if (txtPhoneNumber.Text.Length > 64)
            {
                MessageBox.Show("Phone Number Is Not Valid!");
                isValid = false;
            }


            if (txtEmail.Text.Length > 64)
            {
                MessageBox.Show("EMail Is Not Valid");
                isValid = false;
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            ValidateUser();
            if (isValid)
            {
                var user = new User()
                {
                    UserName = txtUserName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    UserTypeId = cmbUserType.SelectedIndex + 1,
                };
                userRepository.Add(user);
                var frm = new LoginOrCreateUserForm();
                frm.Show();
                this.Hide();
            }

        }

    }
}
