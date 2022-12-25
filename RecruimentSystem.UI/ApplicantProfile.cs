using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using RecruimentSystem.UI;
using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecruitmentSystem.UI
{
    public partial class ApplicantProfile : Form
    {
        private readonly IApplicantRepository applicantRepository;
        public ApplicantProfile()
        {
            applicantRepository = new ApplicantRepository();
            InitializeComponent();
            FormLoadJob();
        }

        private void ValidateUser()
        {
            if (string.IsNullOrEmpty(TxtBoxName.Text))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(TxtBoxLastName.Text))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(TxtBoxAge.Text))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(TxtWorkExperience.Text))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(TxtSalaryPropose.Text))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(JobCmbBox.Text))
                throw new ArgumentNullException();


        }

        private void Form_Load(object sender, EventArgs e)
        {
            var dt = applicantRepository.GetSevrveStatusData();
            KeyValue keyValue1 = default;

            List<KeyValue> list = new List<KeyValue>();
            foreach (var dataRow in dt.Select())
            {
                keyValue1 = new KeyValue()
                {
                    Value = Convert.ToInt32(dataRow["Value"].ToString()),
                    Key = dataRow["Key"].ToString(),
                };
                list.Add(keyValue1);
            }
            CmbBoxServeStatus.DataSource = list;
            CmbBoxServeStatus.ValueMember = "Value";
            CmbBoxServeStatus.DisplayMember = "Key";

        }

        private void FormLoadJob()
        {
            var dt = applicantRepository.GetJobData();
            KeyValue keyValue = default;

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
            JobCmbBox.DataSource = list;
            JobCmbBox.ValueMember = "Value";
            JobCmbBox.DisplayMember = "Key";

        }


        private void SaveApplicant_Click(object sender, EventArgs e)
        {
            ValidateUser();
            var applicant = new Applicant()
            {
                Name = TxtBoxName.Text,
                LastName = TxtBoxLastName.Text,
                FathersName = TxtBoxFatherName.Text,
                Age = Convert.ToInt32(TxtBoxAge.Text),
                ServeStatusTypeId = CmbBoxServeStatus.SelectedIndex+1,
                WorkExperience = TxtWorkExperience.Text,
                SalaryRequest =Convert.ToDecimal(TxtSalaryPropose.Text),
                JobName = JobCmbBox.SelectedText ,
                ResumeDescription = TxtDescraption.Text
            };
            applicantRepository.Add(applicant);
            this.Hide();
        }
    }
}
