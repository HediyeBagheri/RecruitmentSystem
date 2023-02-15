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
    public partial class CompanyOfferForm : Form
    {
        private readonly ICompanyJobRepository companyJobRepository;
        private int applicantId;
        public CompanyOfferForm(int applicantId)
        {
            InitializeComponent();
            this.applicantId = applicantId;
            companyJobRepository = new CompanyJobRepository();
            FillForm();
        }

        

        public void FillForm()
        {
            
            var companyOfferDetails = companyJobRepository.GetAll();
            foreach (var companyOfferDetail in companyOfferDetails.Select())
            {
                
                var companyOfferControl = new CompanyOfferControl(Convert.ToInt16(companyOfferDetail["Id"].ToString()),applicantId);
                companyOfferControl.LblCompanyName.Text = companyOfferDetail["CompanyName"].ToString();
                companyOfferControl.JobName.Text = companyOfferDetail["JobName"].ToString();
                //companyOfferControl.SalaryProposeLbl.Text = companyOfferDetail["SalaryPropose"].ToString();
                //companyOfferControl.LocationLbl.Text = companyOfferDetail["Location"].ToString();
                //companyOfferControl.WorkExperienceLbl.Text = companyOfferDetail["MinimumWorkExperience"].ToString(); 
                //companyOfferControl.EducationDegreeLbl.Text = companyOfferDetail["MinimumEducationDegree"].ToString(); 
                //companyOfferControl.richTxtDescription.Text = companyOfferDetail["Description"].ToString();
                //companyOfferControl.LblTypeOfCooperation.Text = companyOfferDetail["TypeOfCooperationId"].ToString();
                companyOfferControl.PicBoxOfferControll.Image = Image.FromFile(companyOfferDetail["ImagePath"].ToString());
                companyOfferControl.lblDate.Text = companyOfferDetail["Date"].ToString();

                
                flowLayoutPanel1.Controls.Add(companyOfferControl);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["ApplicantPanelForm"];
            this.Hide();
            x.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CompanyOfferForm_Load(object sender, EventArgs e)
        {

        }
    }
}
