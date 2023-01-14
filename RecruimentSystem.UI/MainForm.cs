using RecruimentSystem.UI;
using System;
using System.Windows.Forms;

namespace RecruitmentSystem.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["LoginOrCreateUserForm"];
            if (x != null)
                x.Close();
            var frm = new LoginOrCreateUserForm(true);
            this.Hide();
            frm.Show();
        }

        private void BtnSignUser_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["LoginOrCreateUserForm"];
            if (x != null)
                x.Close();
            var frm = new LoginOrCreateUserForm();
            this.Hide();
            frm.Show();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            var x = openForms["CreateUserForm"];
            if (x != null)
                x.Close();
            var frm = new CreateUserForm();
            this.Hide();
            frm.Show();
        }
    }
}
