using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class ApplicantProfile : Form
    {
        private readonly IApplicantRepository applicantRepository;
        private int applicantId;
        public ApplicantProfile(int applicantId)
        {
            applicantRepository = new ApplicantRepository();
            this.applicantId = applicantId;
            InitializeComponent();
        }

        private void PutData()
        {
            var dt = applicantRepository.GetAll(applicantId);
            var drs = dt.Select();
            var dr = drs[0];
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                TxtBoxName.Text = dr[1].ToString();
                TxtBoxLastName.Text = dr[2].ToString();
                TxtBoxFatherName.Text = dr[3].ToString();
                TxtBoxAge.Text = dr[4].ToString();
                CmbBoxServeStatus.SelectedIndex = Convert.ToInt32(dr[5].ToString());
                TxtWorkExperience.Text = dr[6].ToString();
                TxtSalaryPropose.Text = dr[7].ToString();
                JobCmbBox.SelectedIndex = Convert.ToInt32(dr[8].ToString());
                TxtDescription.Text = dr[9].ToString();
            }

           
        }

        private void ValidateUser()
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {
            FormLoadJob();
            var dt = applicantRepository.GetServeStatusData();
            KeyValue keyValue1;

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
            PutData();

        }

        private void FormLoadJob()
        {
            var dt = applicantRepository.GetJobData();
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
                ServeStatusTypeId = CmbBoxServeStatus.SelectedIndex + 1,
                WorkExperience = TxtWorkExperience.Text,
                SalaryRequest = Convert.ToDecimal(TxtSalaryPropose.Text),
                JobId = JobCmbBox.SelectedIndex,
                ResumeDescription = TxtDescription.Text
            };
            applicantRepository.Update(applicant,applicantId);
            var frm = Application.OpenForms;
            var x = frm["ApplicantPanelForm"];
            
            x.Show();
            this.Hide();

        }
    }
}
