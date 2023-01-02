using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.companyId=companyId;
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
            companyRepository.Update(company);

            var openForms = Application.OpenForms;
            var x = openForms["CompanyPanelForm"];
            x.Close();
            var frm = new CompanyPanelForm(companyId);
            this.Hide();
            frm.Show();
        }
    }
}
