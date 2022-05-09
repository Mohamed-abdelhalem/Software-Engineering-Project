using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Connected
{
    public partial class company_form : Form
    {
         OracleDataAdapter adapder;
         OracleCommandBuilder builder;
         DataSet dataSet;
         string ordb = "data source=orcl; user id=scott; password=tiger;";
         OracleConnection conn;
        //function to validate login
        public string login()
        {
            if (name_text.Text == "" || pass_text.Text == "")
                return "Should Enter Data";
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                //select id where found email and password and type = company
                cmd.CommandText = "select memberid from users where memberemail=:email and pass =:pass and membertype = 'company'";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("email", name_text.Text);
                cmd.Parameters.Add("pass", pass_text.Text);

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr[0].ToString();
                }
                dr.Close();

                return "Invalid Data";
            }
        }
       
        public company_form()
        {
            InitializeComponent();
        }

        private void company_form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            //combo box has id of jobs
             jobs_hide_cmb.Visible = false;
             app_hide_cmb.Visible = false;
        }
        //display my jobs
        private void show_btn_Click(object sender, EventArgs e)
        {
            jobs_cmb.Items.Clear();
            jobs_hide_cmb.Items.Clear();
            responds_cmb.Items.Clear();
            app_hide_cmb.Items.Clear();
            jobs_cmb.Text = "";
            jobs_hide_cmb.Text = "";
            responds_cmb.Text = "";
            app_hide_cmb.Text = "";
            String log = login();
            if (log != "Should Enter Data" && log != "Invalid Data")
            {
                string constring = "Data Source=orcl;User Id=scott;Password=tiger;";

                string cmdstring = "select * from jobs WHERE companyid =: id";

                adapder = new OracleDataAdapter(cmdstring, constring);
                adapder.SelectCommand.Parameters.Add("id", log);
                dataSet = new DataSet();
                adapder.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                //dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[3].Visible = false;
                //dataGridView1.Columns[4].ReadOnly = true;

                /*display jobs*/
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select jobid,jobname from jobs where jobstatus = 'accept' and companyid=:id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("uid", log);
                OracleDataReader dr = cmd.ExecuteReader();
                //load jobs name and id to combobox
                while (dr.Read())
                {
                    jobs_hide_cmb.Items.Add(dr[0]);
                    jobs_cmb.Items.Add(dr[1]);
                }
                dr.Close();

            }
            else
                MessageBox.Show(log);
        }

        private void save_Click(object sender, EventArgs e)
        {
            String log = login();
            if (log != "Should Enter Data" && log != "Invalid Data")
            {
                builder = new OracleCommandBuilder(adapder);
                adapder.Update(dataSet.Tables[0]);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gui G = new Gui();
            G.ShowDialog();
        }

        private void responds_Click(object sender, EventArgs e)
        {
            String log = login();
            string type=null;
            bool ch = false;
            if (log != "Should Enter Data" && log != "Invalid Data" )
            {
                if(cv_text.Text != "")
                {
                    string jobid = jobs_hide_cmb.SelectedItem.ToString();
                    string userid = app_hide_cmb.SelectedItem.ToString();

                    if (radioButton1.Checked)
                    {
                        ch = true;
                        type = "accepted";
                    }
                    else if (radioButton2.Checked)
                    {
                        ch = true;
                        type = "rejected";
                    }
                    if (ch == false)
                    {
                        MessageBox.Show("Sould checked status");
                    }
                    else
                    {
                        //insert in responds
                        OracleCommand c = new OracleCommand();
                        c.Connection = conn;
                        c.CommandText = "insert into responds values(:userid,:jobid,:message,:interviewdate)";
                        c.CommandType = CommandType.Text;

                        c.Parameters.Add("userid", userid);
                        c.Parameters.Add("jobid", jobid);
                        c.Parameters.Add("m", type);
                        if(type=="accepted")
                            c.Parameters.Add("date", Convert.ToDateTime(dateTimePicker1.Text));
                        else
                            c.Parameters.Add("date", "");

                        int r = c.ExecuteNonQuery();
                        if (r != -1)
                        {
                            //delete from applied
                            OracleCommand c1 = new OracleCommand();
                            c1.Connection = conn;
                            c1.CommandText = "delete from applyrequest where userid=:userid and jobid=:jobid";
                            c1.CommandType = CommandType.Text;

                            c1.Parameters.Add("userid", userid);
                            c1.Parameters.Add("jobid", jobid);
                            int r1 = c1.ExecuteNonQuery();
                            if (r1 != -1)
                            {
                                MessageBox.Show("send respond");
                            }
                            //remove from combobox
                            app_hide_cmb.Items.RemoveAt(jobs_hide_cmb.SelectedIndex);
                            responds_cmb.Items.RemoveAt(responds_cmb.SelectedIndex);
                        }
                        
                    }
                }
                else MessageBox.Show("Sould choose Applicant");
            }
            else
                MessageBox.Show(log);
        }

        private void jobs_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            responds_cmb.Items.Clear();
            app_hide_cmb.Items.Clear();
            responds_cmb.Text = "";
            cv_text.Text = "";
            dateTimePicker1.ResetText();
            groupBox1.ResetText();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            jobs_hide_cmb.SelectedIndex = jobs_cmb.SelectedIndex;
            string jobid = jobs_hide_cmb.SelectedItem.ToString();
            cmd.CommandText = "select u.memberemail,a.userid from applyrequest a, users u where a.userid = u.memberid and a.jobid=:jobid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", jobid);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                responds_cmb.Items.Add(dr[0]);
                app_hide_cmb.Items.Add(dr[1]);
            }
            dr.Close();
        }

        private void responds_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            app_hide_cmb.SelectedIndex = responds_cmb.SelectedIndex;
            string jobid = jobs_hide_cmb.SelectedItem.ToString();
            string userid = app_hide_cmb.SelectedItem.ToString();

            cmd.CommandText = "select cv from applyrequest where userid = :userid and jobid=:jobid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("userid", userid);
            cmd.Parameters.Add("jobid", jobid);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cv_text.Text= dr[0].ToString();
            }
            dr.Close();
        }
    }
}
