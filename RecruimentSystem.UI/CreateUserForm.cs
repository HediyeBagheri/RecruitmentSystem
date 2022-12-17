using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        private void Form_Load(object sender, EventArgs e)
        {
            var dt = userRepository.GetUserTypeData();
            KeyValue keyValue=default;

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

        private void Save_Click(object sender, EventArgs e)
        {
            ValidateUser();
            var user = new User()
            {
                UserName = txtUserName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                PhoneNumber = txtPhoneNumber.Text,
                UserTypeId = cmbUserType.SelectedIndex+1,
            };
            userRepository.Add(user);
            var frm = new LoginOrCreateUserForm();
            frm.Show();
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
