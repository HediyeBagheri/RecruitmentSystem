using Microsoft.Data.SqlClient;
using RecruimentSystem.UI;
using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using RecruitmentSystem.Model.Offers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class CompanyRequestForm : Form
    {
        private readonly ICompanyOfferDetailRepository companyOfferRepository;
        public CompanyRequestForm()
        {
            InitializeComponent();
            companyOfferRepository = new CompanyOfferDetailRepository();
            FillCmbJob();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            var dt = companyOfferRepository.GetComOfferCooperationType();
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

        private void FillCmbJob()
        {
            var dt = companyOfferRepository.GetJobData();
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
            if (string.IsNullOrEmpty(TxtCompanyName.Text))
                throw new ArgumentNullException();
            if (string.IsNullOrEmpty(CmbJobName.Text))
                throw new ArgumentNullException();
            if (string.IsNullOrEmpty(TxtSalaryPropose.Text))
                throw new ArgumentNullException();
            if (string.IsNullOrEmpty(TxtLocation.Text))
                throw new ArgumentNullException();
            if (string.IsNullOrEmpty(TxtMinWorkExperience.Text))
                throw new ArgumentNullException();
            if (string.IsNullOrEmpty(CmbTypeOfCooperation.Text))
                throw new ArgumentNullException();
            if (string.IsNullOrEmpty(TxtMinEducationDegree.Text))
                throw new ArgumentNullException();

            if (TxtCompanyName.Text.Length > 128)
                throw new ArgumentOutOfRangeException();

            if (TxtLocation.Text.Length > 64)
                throw new ArgumentOutOfRangeException();

            if (TxtMinEducationDegree.Text.Length > 64)
                throw new ArgumentOutOfRangeException();

            if (TxtMinWorkExperience.Text.Length > 128)
                throw new ArgumentOutOfRangeException();

        }

        private void BtnCompanyReq_Click(object sender, EventArgs e)
        {
            ValidateCompanyOffer();
            var companyOfferDetail = new CompanyOfferDetail()
            { 
                CompanyName = TxtCompanyName.Text,
                JobName = CmbJobName.Text,
                SalaryPropose = Convert.ToDecimal(TxtSalaryPropose.Text),
                Location = TxtLocation.Text,
                MinimumWorkExperience = Convert.ToInt32(TxtMinWorkExperience.Text),
                TypeOfCooperationId = CmbTypeOfCooperation.SelectedIndex+1,
                MinimumEducationDegree = TxtMinEducationDegree.Text,
                Description = TxtDescription.Text,
                //ImagePath = 
            };
            companyOfferRepository.Add(companyOfferDetail);
            this.Hide();
        }
    }
}
