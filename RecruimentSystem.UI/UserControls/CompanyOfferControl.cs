using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.Model.Models.Users;
using RecruitmentSystem.Model.Offers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class CompanyOfferControl : UserControl
    {
        private int offerId;
        public CompanyOfferControl(int offerId)
        {
            InitializeComponent();
            this.offerId = offerId;
        }

        private void SendingResumeBtn_Click(object sender, EventArgs e)
        {
             
        }

        private void ShowDetailsBtn_Click(object sender, EventArgs e)
        {
            var detail = new CompanyJob();

        }

        private void JobName_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        
        }
    }

}
