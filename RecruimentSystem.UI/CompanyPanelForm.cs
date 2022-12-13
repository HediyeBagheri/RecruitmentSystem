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
    public partial class CompanyPanelForm : Form
    {
        public CompanyPanelForm()
        {
            InitializeComponent();
        }

        private void companyRecruitBtn_Click(object sender, EventArgs e)
        {
            var frm = new RecruitmentForm();
            frm.Show();
        }

        private void educationBtn_Click(object sender, EventArgs e)
        {
            var frm = new EducationForm();
            frm.Show();
        }
    }
}
