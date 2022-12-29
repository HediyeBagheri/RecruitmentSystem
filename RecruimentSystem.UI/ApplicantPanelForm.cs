using RecruimentSystem.UI;
using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class ApplicantPanelForm : Form
    {
        private readonly IApplicantRepository applicantRepository;
        private int applicantId;
        private DataTable applicantData;

        public ApplicantPanelForm(int id)
        {
            InitializeComponent();
            applicantRepository = new ApplicantRepository();
            applicantId = id;

        }
        
        private void FillWelcomeData()
        {
            applicantData = applicantRepository.GetAll(applicantId);
            string name = "";
            foreach (var dataRow in applicantData.Select())
            {
                name = dataRow["Name"].ToString();
            }

            string x = LblWelcome.Text;
            string y = x + " " + name;
            LblWelcome.Text = y;
        }

        private void RecruitBtn_Click(object sender, EventArgs e)
        {
            var frm = new CompanyOfferForm();
            frm.Show();
            this.Hide();
        }

        private void TrainingBtn_Click(object sender, EventArgs e)
        {
            var frm = new TrainingForm();
            frm.Show();
            this.Hide();
        }

        private void BtnProfileUpdate_Click(object sender, EventArgs e)
        {
            var frm = new ApplicantProfile(applicantId);
            frm.Show();
            this.Hide();
        }

        private void ApplicantPanelForm_Load(object sender, EventArgs e)
        {
            FillWelcomeData();

        }

        //public new void Show(IWin32Window owner)
        //{
        //    base.Show(owner);
        //    FillWelcomeData();

        //}
    }
}
