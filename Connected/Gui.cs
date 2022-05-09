using System;
using System.Windows.Forms;

namespace Connected
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        private void Gui_Load(object sender, EventArgs e)
        {

        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }

        private void applicant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void company_Click(object sender, EventArgs e)
        {
            this.Hide();
            company_form c = new company_form();
            c.ShowDialog();
        }

        private void R1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report1 r1 = new Report1();
            r1.ShowDialog();
        }

        private void R2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report2 r2 = new Report2();
            r2.ShowDialog();
        }
    }
}
