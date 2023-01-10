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
    public partial class MyOffer : UserControl
    {
        private readonly ICompanyJobRepository companyJobRepository;
        private int companyJobId;
        public MyOffer(int companyJobId)
        {
            InitializeComponent();
            companyJobRepository = new CompanyJobRepository();
            this.companyJobId = companyJobId;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            companyJobRepository.Delete(companyJobId);
            this.Hide();
        }
    }
}
