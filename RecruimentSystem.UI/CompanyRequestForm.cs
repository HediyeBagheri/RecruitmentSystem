using Microsoft.Data.SqlClient;
using RecruimentSystem.UI;
using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using RecruitmentSystem.Model.Offers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class CompanyRequestForm : Form
    {
        private readonly ICompanyOfferDetailRepository companyOfferRepository;
        private string imagePath = default;
        private string imageName = default;

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
            

        }

        private void BtnCompanyReq_Click(object sender, EventArgs e)
        {
            
            ValidateCompanyOffer();
            //SaveFile(imagePath);
            var companyOfferDetail = new CompanyJob()
            {
                CompanyName = TxtCompanyName.Text,
                JobName = CmbJobName.Text,
                SalaryPropose = Convert.ToDecimal(TxtSalaryPropose.Text),
                Location = TxtLocation.Text,
                MinimumWorkExperience = Convert.ToInt32(TxtMinWorkExperience.Text),
                TypeOfCooperationId = CmbTypeOfCooperation.SelectedIndex + 1,
                MinimumEducationDegree = TxtMinEducationDegree.Text,
                Description = TxtDescription.Text,
                ImagePath = ""
            };
            companyOfferRepository.Add(companyOfferDetail);
            this.Hide();
            var comOfferFrm = new CompanyOfferForm();
            comOfferFrm.Show();
        }

        //private void SaveFile(string imagePath)
        //{
        //    using Stream stream = new FileStream(imagePath, FileMode.Open);
        //    using var memoryStream = new MemoryStream();
        //    stream.CopyTo(memoryStream);

        //    string directory = string.Concat( AppDomain.CurrentDomain.BaseDirectory,"\\Images\\");
        //    if (!Directory.Exists(imagePath))
        //        Directory.CreateDirectory(imagePath);
        //    File.WriteAllBytes(string.Concat(directory,imageName),
        //        memoryStream.ToArray());

        //}

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicBoxComRequest.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }
    }
}
