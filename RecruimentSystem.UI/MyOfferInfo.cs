﻿using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Offers;
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
    public partial class MyOfferInfo : Form
    {
        private readonly ICompanyJobRepository companyJobRepository;
        private int companyId;
        private int companyJobId;
        public MyOfferInfo(int companyJobId, int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
            this.companyJobId = companyJobId;
            companyJobRepository = new CompanyJobRepository();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            var data = companyJobRepository.GetAllRequestForOffers(companyJobId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["MyOffers"];
            if (x != null)
                x.Close();

            var frm = new MyOffers(companyId);
            frm.Show();
            
        }
    }
}
