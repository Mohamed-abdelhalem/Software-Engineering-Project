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
    public partial class Report2 : Form
    {
        CrystalReport2 cr;
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();

            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
                cr.SetParameterValue(0, comboBox1.Text);
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
