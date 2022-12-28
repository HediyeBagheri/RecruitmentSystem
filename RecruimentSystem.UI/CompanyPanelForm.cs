using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using System;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class CompanyPanelForm : Form
    {
        private readonly IUserRepository userRepository;
        private int applicantId;
        public CompanyPanelForm(int ID)
        {
            InitializeComponent();
            userRepository = new UserRepository();
            applicantId = ID;
        }

        private void CompanyRecruitBtn_Click(object sender, EventArgs e)
        {
            var frm = new RecruitmentForm();
            frm.Show();
            this.Hide();
        }

        private void EducationBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Request_Click(object sender, EventArgs e)
        {
            var frm = new CompanyRequestForm();
            this.Hide();
            frm.Show();

        }
    }
}
