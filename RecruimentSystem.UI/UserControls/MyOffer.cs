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
        private int companyId;
        public MyOffer(int companyId,int companyJobId)
        {
            InitializeComponent();
            companyJobRepository = new CompanyJobRepository();
            this.companyJobId = companyJobId;
            this.companyId = companyId;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            companyJobRepository.Delete(companyJobId);
            this.Hide();
        }

        private void MyOffer_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["CompanyRequestForm"];
            var y = openForms["MyOffers"];
            if (x != null)
                x.Close();

            var frm = new CompanyRequestForm(companyId, companyJobId);
            this.Hide();
            y.Close();
            frm.Show();
        }
    }
}
