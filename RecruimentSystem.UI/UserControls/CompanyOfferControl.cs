using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using RecruitmentSystem.Model.Offers;
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
    public partial class CompanyOfferControl : UserControl
    {
        private readonly ICompanyJobRepository companyJobRepository;
        private readonly IApplicantRepository applicantRepository;
        private int offerId;
        private int applicantId;

        public CompanyOfferControl(int offerId,int applicantId)
        {
            InitializeComponent();
            this.offerId = offerId;
            this.applicantId = applicantId;
            companyJobRepository = new CompanyJobRepository();
            applicantRepository = new ApplicantRepository();
        }

        private void SendingResumeBtn_Click(object sender, EventArgs e)
        {
            var y = applicantRepository.GetResumeById(applicantId);
            var z=y.Select();
            var s = z[0];
            string resumePath = s["ResumePath"].ToString();

            var x = new RequestForCompanyJob()
            {
                Date = DateTime.Now,
                CompanyJobId = offerId,
                ResumePath = resumePath,
                UserId=applicantId
            };
            companyJobRepository.AddToRequestForCompanyJobId(x);
            
        }

        private void ShowDetailsBtn_Click(object sender, EventArgs e)
        {

        }

        private void JobName_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CompanyOfferControl_Load(object sender, EventArgs e)
        {

        }
    }

}
