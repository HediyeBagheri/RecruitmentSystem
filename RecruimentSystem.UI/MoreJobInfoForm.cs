using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Offers;
using RecruitmentSystem.UI.UserControls;
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
    public partial class MoreJobInfoForm : Form
    {
        private int companyId;
        private readonly ICompanyJobRepository companyJobRepository;


        public MoreJobInfoForm(int CompanyId)
        {
            InitializeComponent();
            this.companyId = CompanyId;
            companyJobRepository = new CompanyJobRepository();
        }

        private void MoreJobInfoForm_Load(object sender, EventArgs e)
        {
            var companyOfferDetails = companyJobRepository.GetAll();
            foreach (var companyOfferDetail in companyOfferDetails.Select())
            {
              LblComName.Text = companyOfferDetail["CompanyName"].ToString();
              LblJobName.Text = companyOfferDetail["JobName"].ToString();
              LblSalaryPropose.Text = companyOfferDetail["SalaryPropose"].ToString();
              LblLoc.Text = companyOfferDetail["Location"].ToString();
              LblMinWorkExperience.Text = companyOfferDetail["MinimumWorkExperience"].ToString();
              LblMinEducDegree.Text = companyOfferDetail["MinimumEducationDegree"].ToString();
                pictureBox1.Image = Image.FromFile(companyOfferDetail["ImagePath"].ToString());
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["CompanyOfferForm"];
            this.Hide();
            x.Show();
        }
    }
}
