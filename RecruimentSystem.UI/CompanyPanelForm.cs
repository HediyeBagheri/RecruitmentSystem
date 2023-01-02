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
        private readonly ICompanyRepository companyRepository;
        private DataTable companyData;
        private int companyId;
        public CompanyPanelForm(int companyId)
        {
            InitializeComponent();
            companyRepository = new CompanyRepository();
            this.companyId = companyId;
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


     


    }
}
