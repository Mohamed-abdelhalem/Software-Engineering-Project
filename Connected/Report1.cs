using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace Connected
{
    public partial class Report1 : Form
    {
        CrystalReport1 cr;
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            crystalReportViewer1.ReportSource = cr;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gui G = new Gui();
            G.ShowDialog();
        }
    }
}
