using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using RecruitmentSystem.Model.Offers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class CompanyRequestForm : Form
    {
        private readonly ICompanyJobRepository companyJobRepository;
        private bool isUpdating = false;
        private int companyId;
        private int companyJobId;
        private string imagePath = default;
        private string imageName = default;

        public CompanyRequestForm(int companyId)
        {
            InitializeComponent();

            companyJobRepository = new CompanyJobRepository();
            this.companyId = companyId;
            FillCmbJob();
        }
        public CompanyRequestForm(int companyId, int companyJobId) : this(companyId)
        {
            this.companyJobId = companyJobId;
            isUpdating = true;
            FillForm();

        }

        private void FillForm()
        {
            var dt = companyJobRepository.GetByJobId(companyJobId);
            var drs = dt.Select();
            var dr = drs[0];

            TxtCompanyName.Text = dr["CompanyName"].ToString() + "";
            TxtSalaryPropose.Text = dr["SalaryPropose"].ToString() + "";
            CmbJobName.Text = dr["JobName"].ToString() + "";
            TxtLocation.Text = dr["Location"].ToString() + "";
            TxtMinWorkExperience.Text = dr["MinimumWorkExperience"].ToString() + "";
            TxtMinEducationDegree.Text = dr["MinimumEducationDegree"].ToString() + "";
            CmbTypeOfCooperation.Text = dr["TypeOfCooperationId"].ToString() + "";
            TxtDescription.Text = dr["Description"].ToString() + "";
            imageName = dr["ImagePath"].ToString() + "";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            FillName();
            var dt = companyJobRepository.GetComOfferCooperationType();
            KeyValue keyValue;

            List<KeyValue> list = new List<KeyValue>();
            foreach (var dataRow in dt.Select())
            {
                keyValue = new KeyValue()
                {
                    Value = Convert.ToInt32(dataRow["Value"].ToString()),
                    Key = dataRow["Key"].ToString(),
                };
                list.Add(keyValue);
            }
            CmbTypeOfCooperation.DataSource = list;
            CmbTypeOfCooperation.ValueMember = "Value";
            CmbTypeOfCooperation.DisplayMember = "Key";

        }

        private void FillName()
        {
            var dt = companyJobRepository.GetName(companyId);
            var drs = dt.Select();
            var dr = drs[0];
            TxtCompanyName.Text = dr["Name"].ToString();
        }

        private void FillCmbJob()
        {
            var dt = companyJobRepository.GetJobData();
            KeyValue keyValue;

            List<KeyValue> list = new List<KeyValue>();
            foreach (var dataRow in dt.Select())
            {
                keyValue = new KeyValue()
                {
                    Value = Convert.ToInt32(dataRow["Value"].ToString()),
                    Key = dataRow["Key"].ToString(),
                };
                list.Add(keyValue);
            }
            CmbJobName.DataSource = list;
            CmbJobName.ValueMember = "Value";
            CmbJobName.DisplayMember = "Key";
        }

        private void ValidateCompanyOffer()
        {


        }

        private void BtnCompanyReq_Click(object sender, EventArgs e)
        {
            ValidateCompanyOffer();
            if (imagePath != null)
                FilesWork.SaveFile(imagePath, imageName);


            var companyOfferDetail = new CompanyJob()
            {
                Id = companyJobId,
                CompanyId = this.companyId,
                CompanyName = TxtCompanyName.Text,
                JobName = CmbJobName.Text,
                SalaryPropose = Convert.ToDecimal(TxtSalaryPropose.Text),
                Location = TxtLocation.Text,
                MinimumWorkExperience = Convert.ToInt32(TxtMinWorkExperience.Text),
                TypeOfCooperationId = CmbTypeOfCooperation.SelectedIndex + 1,
                MinimumEducationDegree = TxtMinEducationDegree.Text,
                Description = TxtDescription.Text,
                Date = DateTime.Now,
                ImagePath = imageName
            };
            if (isUpdating)
            {
                companyJobRepository.Update(companyOfferDetail);
                MessageBox.Show("Request Updated SuccessFully !");
                var frm = new MyOffers(companyId);
                frm.Show();
                this.Hide();
            }
            else
            {
                companyJobRepository.Add(companyOfferDetail);
                var openForms = Application.OpenForms;
                var x = openForms["CompanyPanelForm"];
                MessageBox.Show("Request Sent SuccessFully !");
                this.Hide();
                x.Show();
            }
        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // PicBoxComRequest.BackgroundImage = new Bitmap(openFileDialog1.FileName);

                imagePath = openFileDialog1.FileName;
                imageName = "Images\\" + openFileDialog1.SafeFileName;
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["CompanyPanelForm"];
            this.Hide();
            x.Show();
        }

        private void TxtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
