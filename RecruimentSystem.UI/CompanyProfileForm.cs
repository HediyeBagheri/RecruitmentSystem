using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using System;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class CompanyProfileForm : Form
    {
        private readonly ICompanyRepository companyRepository;
        private int companyId;

        public CompanyProfileForm(int companyId)
        {
            InitializeComponent();
            companyRepository = new CompanyRepository();
            this.companyId = companyId;
        }


        private void Form_Load(object sender, EventArgs e)
        {
            var dt = companyRepository.GetAll(companyId);
            var drs = dt.Select();
            var dr = drs[0];

            TxtCompanyName.Text = dr["Name"].ToString() + "";
            TxtManagerName.Text = dr["ManagerName"].ToString() + "";
            TxtBusiness.Text = dr["Business"].ToString() + "";
            TxtAddress.Text = dr["Address"].ToString() + "";
        }
        private void ValidateCompany()
        {

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateCompany();
            var company = new Company()
            {
                Name = TxtCompanyName.Text,
                ManagerName = TxtManagerName.Text,
                Business = TxtBusiness.Text,
                Address = TxtAddress.Text
            };
            companyRepository.Update(company, companyId);
            var openForms = Application.OpenForms;
            var x = openForms["CompanyPanelForm"];
            x.Close();
            var frm = new CompanyPanelForm(companyId);
            this.Hide();
            frm.Show();
        }
    }
}
