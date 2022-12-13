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

        public ApplicantPanelForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void recruitBtn_Click(object sender, EventArgs e)
        {
            var frm = new RecruitForm();
            frm.Show();
        }

        private void trainingBtn_Click(object sender, EventArgs e)
        {
            var frm = new TrainingForm();
            frm.Show();
        }

        private void editResumeBtn_Click(object sender, EventArgs e)
        {
            var frm = new ResumeForm();
            frm.Show();
        }
    }
}
