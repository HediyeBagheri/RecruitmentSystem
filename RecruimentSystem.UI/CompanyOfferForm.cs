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
        private readonly ICompanyOfferDetailRepository companyOfferRepository;

        public CompanyOfferForm()
        {
            InitializeComponent();
            companyOfferRepository = new CompanyOfferDetailRepository();
            FillForm();
        }

        public void FillForm()
        {
            var companyOfferDetails = companyOfferRepository.GetAll1();
            foreach (var companyOfferDetail in companyOfferDetails.Select())
            {
                var companyOfferControl = new CompanyOfferControl();
                companyOfferControl.CompanyNameLbl.Text = companyOfferDetail["CompanyName"].ToString();
                companyOfferControl.JonNameLbl.Text = companyOfferDetail["JobName"].ToString();
                companyOfferControl.SalaryProposeLbl.Text = companyOfferDetail["SalaryPropose"].ToString();
                companyOfferControl.LocationLbl.Text = companyOfferDetail["Location"].ToString();
                companyOfferControl.WorkExperienceLbl.Text = companyOfferDetail["MinimumWorkExperience"].ToString(); 
                companyOfferControl.EducationDegreeLbl.Text = companyOfferDetail["MinimumEducationDegree"].ToString(); 
                companyOfferControl.richTxtDescription.Text = companyOfferDetail["SalaryPropose"].ToString();
                companyOfferControl.LblTypeOfCooperation.Text = companyOfferDetail["TypeOfCooperationId"].ToString();
                //companyOfferControl.pictureBox1.Image = Image.FromFile(companyOfferDetail["ImagePath"].ToString());
                flowLayoutPanel1.Controls.Add(companyOfferControl);
            }
        }
    }
}
