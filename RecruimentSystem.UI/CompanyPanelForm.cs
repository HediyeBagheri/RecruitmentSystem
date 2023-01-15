using RecruimentSystem.UI;
using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class CompanyPanelForm : Form
    {
        private readonly ICompanyRepository companyRepository;
        private int companyId;
        private DataTable companyData;
        public CompanyPanelForm(int companyId)
        {
            InitializeComponent();
            companyRepository = new CompanyRepository();
            this.companyId = companyId;
        }
        private void FillWelcomeData()

        {
            companyData = companyRepository.GetAll(companyId);
            string name = "";
            foreach (var dataRow in companyData.Select())
            {
                name = dataRow["Name"].ToString();
                if (dataRow["ImagePath"].ToString() != "")
                {
                    PicBoxCompanyPanel.Image = Image.FromFile(dataRow["ImagePath"].ToString());
                }
            }

            string x = LblWelcome.Text;
            string y = x + " " + name;
            LblWelcome.Text = y;
        }


        private void CompanyRecruitBtn_Click(object sender, EventArgs e)
        {
            var frm = new RecruitmentForm();
            frm.Show();
            this.Hide();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            var frm = new CompanyProfileForm(companyId);
            frm.Show();
            this.Hide();
        }

        private void Request_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["CompanyRequestForm"];
            if (x != null)
                x.Close();

            var frm = new CompanyRequestForm(companyId);
            this.Hide();
            frm.Show();
        }

        private void CompanyPanelForm_Load(object sender, EventArgs e)
        {
            FillWelcomeData();
        }

        private void BtnMyRequests_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["MyOffers"];
            if (x != null)
                x.Close();

            var frm = new MyOffers(companyId);
            this.Hide();
            frm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["CompanyPanelForm"];
            x.Close();
            var frm = new LoginOrCreateUserForm();
            this.Hide();
            frm.Show();
        }

        private void LblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
