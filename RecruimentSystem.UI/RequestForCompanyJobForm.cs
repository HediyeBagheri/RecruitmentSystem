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

namespace RecruitmentSystem.UI
{
    public partial class RequestForCompanyJobForm : Form
    {
        private readonly ICompanyJobRepository _jobRepository;
        private int companyJobId;
        private int requestId;
        private int comId;
        public RequestForCompanyJobForm(int companyJobId,int comId,int requestId)
        {
            InitializeComponent();
            this.companyJobId = companyJobId;
            this.requestId = requestId; 
            this.comId = comId;
            _jobRepository= new CompanyJobRepository();
            FillForm();
        }

        private void FillForm()
        {
            var dt = _jobRepository.GetAllRequestForOffersById(requestId);
            var drs = dt.Select();
            var dr = drs[0];
            lblFullName.Text= dr["Name"].ToString() + " " + dr["LastName"].ToString();
            lblAge.Text = Convert.ToDateTime(dr["Date"]).ToString();
            lblEmail.Text = dr["Email"].ToString();
            lblPhoneNumber.Text = dr["TelephoneNumber"].ToString();
            pictureBox2.Image = Image.FromFile(dr["ImagePath"].ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["MyOfferInfo"];
            x.Close();
            var frm = new MyOfferInfo(companyJobId, comId);
            this.Hide();
            frm.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _jobRepository.DeleteToRequestForCompanyJobId(requestId);
            MessageBox.Show("Deleted SuccessFully");
            btnExit_Click(null, null);
        }
    }
}
