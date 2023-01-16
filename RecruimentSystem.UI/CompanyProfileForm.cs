using RecruitmentSystem.InfraStructure.IRepositories;
using RecruitmentSystem.InfraStructure.Repositories;
using RecruitmentSystem.Model.Models.Users;
using System;
using System.IO;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class CompanyProfileForm : Form
    {
        private readonly ICompanyRepository companyRepository;
        private int companyId;
        private string imagePath = default;
        private string imageName = default;

        public CompanyProfileForm(int companyId)
        {
            InitializeComponent();
            companyRepository = new CompanyRepository();
            this.companyId = companyId;
        }


        private void Form_Load(object sender, EventArgs e)
        {
            var dt = companyRepository.GetAllById(companyId);
            var drs = dt.Select();
            var dr = drs[0];

            TxtCompanyName.Text = dr["Name"].ToString() + "";
            TxtManagerName.Text = dr["ManagerName"].ToString() + "";
            TxtBusiness.Text = dr["Business"].ToString() + "";
            TxtAddress.Text = dr["Address"].ToString() + "";
        }
        private void ValidateCompany()
        {

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateCompany();
            SaveFile(imagePath);
            var company = new Company()
            {
                Name = TxtCompanyName.Text,
                ManagerName = TxtManagerName.Text,
                Business = TxtBusiness.Text,
                Address = TxtAddress.Text,
                ImagePath = imageName
            };
            companyRepository.Update(company, companyId);
            var openForms = Application.OpenForms;
            var x = openForms["CompanyPanelForm"];
            x.Close();
            var frm = new CompanyPanelForm(companyId);
            this.Hide();
            frm.Show();
        }

        private void SaveFile(string imagePath)
        {
            using Stream stream = new FileStream(imagePath, FileMode.Open);
            using var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);

            string directory = string.Concat(AppDomain.CurrentDomain.BaseDirectory);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllBytes(string.Concat(directory, imageName), memoryStream.ToArray());
        }

        private void BtnPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // PicBoxComRequest.BackgroundImage = new Bitmap(openFileDialog1.FileName);

                imagePath = openFileDialog2.FileName;
                imageName = "Images\\" + openFileDialog2.SafeFileName;
            }
        }
    }
}
