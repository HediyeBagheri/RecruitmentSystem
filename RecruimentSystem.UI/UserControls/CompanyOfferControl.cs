﻿using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using RecruitmentSystem.Model.Offers;
using RecruitmentSystem.UI.UserControls;
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
        private readonly ICompanyJobRepository companyJobRepository;
        private int offerId;
        private int applicantId;
        private int companyId;


        public CompanyOfferControl(int offerId)
        {
            InitializeComponent();
            this.offerId = offerId;
            companyJobRepository = new CompanyJobRepository();
        }

        private void SendingResumeBtn_Click(object sender, EventArgs e)
        {

        }

        private void ShowDetailsBtn_Click(object sender, EventArgs e)
        {

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
