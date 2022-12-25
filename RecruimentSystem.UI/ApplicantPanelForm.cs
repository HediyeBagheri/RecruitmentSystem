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

        public ApplicantPanelForm(int Id)
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void RecruitBtn_Click(object sender, EventArgs e)
        {
            var frm = new CompanyOfferForm();
            frm.Show();
        }

        private void TrainingBtn_Click(object sender, EventArgs e)
        {
            var frm = new TrainingForm();
            frm.Show();
        }

        private void BtnProfileUpdate_Click(object sender, EventArgs e)
        {
            var frm = new ApplicantProfile();
            frm.Show();
        }
    }
}
