using RecruitmentSystem.InfraStructure.IRepositories;
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
        private DataTable dt;
        public MyOfferInfo(int companyJobId, int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
            this.companyJobId = companyJobId;
            companyJobRepository = new CompanyJobRepository();
            dt=new DataTable();
            FillDataGrid();
        }

        private void FillDataGrid()
        {

            var data = companyJobRepository.GetAllRequestForOffers(companyJobId);
            dgvRequests.DataSource = data;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["MyOffers"];
            if (x != null)
                x.Close();

            var frm = new MyOffers(companyId);
            this.Hide();
            frm.Show();
            
        }

        private void dgvRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = Convert.ToInt32(dgvRequests["Id", index].Value);
            var openforms = Application.OpenForms;
            var x = openforms["RequestForCompanyJobForm"];
            if (x!=null)
                x.Close();
            var form = new RequestForCompanyJobForm(companyJobId,companyId,id);
            form.Show();
            this.Hide();
        }
    }
}
