using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentSystem.UI.UserControls
{
    public partial class ApplicantControl : UserControl
    {
        private readonly IApplicantRepository applicantRepository;

        public ApplicantControl()
        {
            InitializeComponent();
            applicantRepository = new ApplicantRepository();
        }

        private void ApplicantControl_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
