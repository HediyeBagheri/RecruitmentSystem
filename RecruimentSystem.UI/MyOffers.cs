using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.UI.UserControls;
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
    public partial class MyOffers : Form
    {
        private readonly ICompanyJobRepository companyJobRepository;
        private int companyId;
        public MyOffers(int companyId)
        {
            InitializeComponent();
            companyJobRepository = new CompanyJobRepository();
            this.companyId = companyId;
            FillForm();
        }

        private void MyOffers_Load(object sender, EventArgs e)
        {
            
        }
        public void FillForm()
        {
            var companyOfferDetails = companyJobRepository.GetById(companyId);
            foreach (var companyOfferDetail in companyOfferDetails.Select())
            {
                var myOffer = new MyOffer(Convert.ToInt32(companyOfferDetail["Id"].ToString()));
                myOffer.LblJob.Text = companyOfferDetail["JobName"].ToString();
                myOffer.LblDate.Text = companyOfferDetail["Date"].ToString();
                myOffer.PicBoxMyOffer.Image =Image.FromFile(companyOfferDetail["ImagePath"].ToString());
                flowLayoutPanel1.Controls.Add(myOffer);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["CompanyPanelForm"];
            this.Hide();
            x.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
