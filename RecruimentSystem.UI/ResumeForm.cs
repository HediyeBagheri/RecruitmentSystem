using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
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
    public partial class ResumeForm : Form
    {
        private readonly IUserRepository userRepository;
        public ResumeForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void ResumeForm_Load(object sender, EventArgs e)
        {
            var dt = userRepository.GetJobData();
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
    }
}
