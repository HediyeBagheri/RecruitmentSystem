using RecruimentSystem.UI;
using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class ApplicantPanelForm : Form
    {
        private readonly IUserRepository userRepository;

        public ApplicantPanelForm(int ID)
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void tsmRecruitItem_Click(object sender, EventArgs e)
        {
            var frm = new RecruitForm();
            frm.Show();
        }

        private void tsmTrainingItem_Click(object sender, EventArgs e)
        {
            var frm = new TrainingForm();
            frm.Show();
        }

        private void tsmProfileItem_Click(object sender, EventArgs e)
        {
            var frm = new ApplicantProfile();
            frm.Show();
        }

        private void tsmEditResumeItem_Click(object sender, EventArgs e)
        {
            var frm = new ResumeForm();
            frm.Show();
        }

        private void tsmExitItem_Click(object sender, EventArgs e)
        {
            var frm = new LoginOrCreateUserForm();
            frm.Show();
        }
    }
}
