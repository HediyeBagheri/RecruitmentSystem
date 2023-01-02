using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using System;
using System.Data;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class CompanyPanelForm : Form
    {
        private readonly IUserRepository userRepository;
        private readonly ICompanyRepository companyRepository;
        private int companyId;
        public CompanyPanelForm(int id)
        {
            InitializeComponent();
            userRepository = new UserRepository();
            companyRepository = new CompanyRepository();
            companyId = id;
        }

        private void CompanyRecruitBtn_Click(object sender, EventArgs e)
        {
            var frm = new RecruitmentForm();
            frm.Show();
            this.Hide();
        }

        private void EducationBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Request_Click(object sender, EventArgs e)
        {
            var frm = new CompanyRequestForm();
            this.Hide();
            frm.Show();

        }

        private void LblWelcome_Click()
        {
            var companyData = companyRepository.GetAll(companyId);

        }
    }
}
