using RecruimentSystem.UI;
using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using System;
using System.Data;
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
            applicantData = applicantRepository.GetAllById(applicantId);
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
            var openForms = Application.OpenForms;
            var x = openForms["CompanyOfferForm"];
            if (x!=null)
                x.Close();
            var frm = new CompanyOfferForm(applicantId);
            this.Hide();
            frm.Show();
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["ApplicantPanelForm"];
            x.Close();
            var frm = new LoginOrCreateUserForm();
            this.Hide();
            frm.Show();
        }

        //public new void Show(IWin32Window owner)
        //{
        //    base.Show(owner);
        //    FillWelcomeData();

        //}
    }
}
