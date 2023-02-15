using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using RecruitmentSystem.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class AdminPanelForm : Form
    {
        private readonly IForAdminRepository adminRepository;
        private readonly ICompanyRepository companyRepository;

        public AdminPanelForm()
        {
            InitializeComponent();
            adminRepository = new ForAdminRepository();
            companyRepository = new CompanyRepository();
        }


        public void FillTabApplicantList()
        {
            var applicants = adminRepository.GetApplicantInfo();
            DgvApplicant.DataSource = applicants;
            
            
        }

        public void FillTabCompanyList()
        {
            var coms = companyRepository.GetAll();
            dataGridView1.DataSource = coms;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            FillTabApplicantList();
            FillTabCompanyList();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var mainFrm = new MainForm();
            mainFrm.Show();
            this.Hide();
        }
    }
}
