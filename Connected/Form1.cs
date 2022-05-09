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
    public partial class Form1 : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;

        public string login()
        {
            //validate login
            if(name_text.Text=="" || pass_text.Text=="")
                return "Should Enter Data";
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select memberid from users where memberemail=:email and pass =:pass and membertype = 'applicant'";
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
       public bool addestofav()
        {
            //chek if current job added to fav before or not
            string log = login();
            bool added = false;
            //validate login and choose job
            if (log != "Should Enter Data" && log != "Invalid Data" && desc_tex.Text != "")
            {
                string jobid = jobId_hidden_cmb.SelectedItem.ToString();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from addtofavorate where userid=:userid and jobid=:jobid";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("userid", log);
                cmd.Parameters.Add("jobid", jobid);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    added = true;
                }
                dr.Close();
            }
            return added;
        }
        public bool Applied()
        {
            //chek if current job added to fav before or not
            string log = login();
            bool added = false;
            //validate login and choose job
            if (log != "Should Enter Data" && log != "Invalid Data" && desc_tex.Text != "")
            {
                string jobid = jobId_hidden_cmb.SelectedItem.ToString();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from applyrequest where userid=:userid and jobid=:jobid";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("userid", log);
                cmd.Parameters.Add("jobid", jobid);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    added = true;
                }
                dr.Close();
            }
            return added;
        }

        public bool Responded()
        {
            //chek if current job added to fav before or not
            string log = login();
            bool added = false;
            //validate login and choose job
            if (log != "Should Enter Data" && log != "Invalid Data" && desc_tex.Text != "")
            {
                string jobid = jobId_hidden_cmb.SelectedItem.ToString();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from responds where userid=:userid and jobid=:jobid";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("userid", log);
                cmd.Parameters.Add("jobid", jobid);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    added = true;
                }
                dr.Close();
            }
            return added;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //combo box has id of jobs
            jobId_cmb.Visible = false;
            jobId_hidden_cmb.Visible = false;

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select jobid,jobname from jobs where jobstatus = 'accept'";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            //load jobs name and id to combobox
            while (dr.Read())
            {
                jobId_hidden_cmb.Items.Add(dr[0]);
                alljobs_cmb.Items.Add(dr[1]);
            }
            dr.Close();
        }
        private void alljobs_cmd_SelectedIndexChanged(object sender, EventArgs e)
        {
             OracleCommand cmd = new OracleCommand();
             cmd.Connection = conn;

            jobId_hidden_cmb.SelectedIndex = alljobs_cmb.SelectedIndex;
            string jobid = jobId_hidden_cmb.SelectedItem.ToString();
            //display desc and company name
             cmd.CommandText = "select jobdescription,membername from jobs,users where jobid =:id and companyid=memberid and membertype='company'";
             cmd.CommandType = CommandType.Text;
             cmd.Parameters.Add("id", jobid);
             OracleDataReader dr = cmd.ExecuteReader();
             if (dr.Read())
             {
                 desc_tex.Text = dr[0].ToString();
                 compname_text.Text = dr[1].ToString();
             }
             dr.Close();
            //if added to fav change text
            if (addestofav() == true)
            {
                addfav.Text = "Remove Fav";
            }
            else
            {
                addfav.Text = "Add To Fav";
            }

            /*display feedbacks*/
            feed_cmb.Items.Clear();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select messagefeedback from feedback where jobid =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", jobid);
            OracleDataReader dreader = c.ExecuteReader();
            if (dreader.Read())
            {
                feed_cmb.Items.Add(dreader[0]);
            }
            dr.Close();
        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            string log = login();

            jobId_hidden_cmb.SelectedIndex = alljobs_cmb.SelectedIndex;
            string jobid = jobId_hidden_cmb.SelectedItem.ToString();
            //apply jobs if login
            if (log!= "Should Enter Data" && log!= "Invalid Data" && desc_tex.Text!="")
            {
                if (cv_text.Text != "")
                {
                    if (Applied() == true || Responded()==true)
                    {
                        MessageBox.Show("Applied Before");
                    }
                    else
                    {
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into applyrequest values(:userid,:jobid,:cv)";
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Add("userid", log);
                        cmd.Parameters.Add("jobid", jobid);
                        cmd.Parameters.Add("cv", cv_text.Text);
                        int r = cmd.ExecuteNonQuery();
                        if (r != -1)
                        {
                            MessageBox.Show("Applied successfully");
                        }
                    }
                }else
                    MessageBox.Show("Enter Link Of Cv");
            }
            else
                MessageBox.Show(log);

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gui G = new Gui();
            G.ShowDialog();
        }

        private void responds_btn_Click(object sender, EventArgs e)
        {
            responds_cmb.Items.Clear();
            responds_cmb.Text="";
            stat_text.Text = "";
            date_text.Text = "";
            jobId_cmb.Items.Clear();
            string log = login();
            //display my responds on this job
            if (log != "Should Enter Data" && log != "Invalid Data")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "GET_RESPONDS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", log);
                cmd.Parameters.Add("job_name", OracleDbType.RefCursor,ParameterDirection.Output);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    responds_cmb.Items.Add(dr[0]);
                    jobId_cmb.Items.Add(dr[1]);
                }
                dr.Close();
            }else
                MessageBox.Show(log);
        }

        private void responds_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            jobId_cmb.SelectedIndex = responds_cmb.SelectedIndex;
            string jobid = jobId_cmb.SelectedItem.ToString();
            //display statues of this respond
            cmd.CommandText = "select message, interviewdate from responds r,jobs j where r.userid=:id and r.jobid=:job and r.jobid = j.jobid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", login());
            cmd.Parameters.Add("id", jobid);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                stat_text.Text = dr[0].ToString();
                date_text.Text = dr[1].ToString();
            }
            dr.Close();
           
        }

        private void addfav_Click(object sender, EventArgs e)
        {
            string log = login();
            //validate login and choosing job
            if (log != "Should Enter Data" && log != "Invalid Data" && desc_tex.Text != "")
            {
                bool added = addestofav();
                string jobid = jobId_hidden_cmb.SelectedItem.ToString();
                //if added to fav remove it else added
                if (added == true)
                {
                    OracleCommand c = new OracleCommand();
                    c.Connection = conn;
                    c.CommandText = "delete from addtofavorate where userid=:userid and jobid=:jobid";
                    c.CommandType = CommandType.Text;

                    c.Parameters.Add("userid", log);
                    c.Parameters.Add("jobid", jobid);
                    int r = c.ExecuteNonQuery();
                      if (r != -1)
                      {
                          MessageBox.Show("remove fav");
                          addfav.Text = "Add To Fav";
                    }
                }
                else if(added==false)
                {
                    OracleCommand c = new OracleCommand();
                    c.Connection = conn;
                    c.CommandText = "insert into addtofavorate values(:userid,:jobid)";
                    c.CommandType = CommandType.Text;

                    c.Parameters.Add("userid", log);
                    c.Parameters.Add("jobid", jobid);
                    int r = c.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Added to fav");
                        addfav.Text = "Remove Fav";
                    }
                }
               
            }
            else
                MessageBox.Show(log);
                
        }

        private void feedback_Click(object sender, EventArgs e)
        {
            string log = login();

            if (log != "Should Enter Data" && log != "Invalid Data" && desc_tex.Text != "")
            {
                //add feedback
                if (feed_text.Text != "")
                {
                    string jobid = jobId_hidden_cmb.SelectedItem.ToString();

                    OracleCommand c = new OracleCommand();
                    c.Connection = conn;
                    c.CommandText = "insert into feedback values(:userid,:jobid,:message)";
                    c.CommandType = CommandType.Text;

                    c.Parameters.Add("userid", log);
                    c.Parameters.Add("jobid", jobid);
                    c.Parameters.Add("jobid", feed_text.Text);
                    int r = c.ExecuteNonQuery();
                    if (r != -1)
                    {
                        feed_cmb.Items.Add(feed_text.Text);
                        MessageBox.Show("Added");
                        feed_text.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Enter message feedback");
                }
            }
            else
                MessageBox.Show(log);

        }
    }
}
