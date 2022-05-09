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
    public partial class RegisterForm : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection con;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gui f = new Gui();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name_txt.Text != "" && email_txt.Text != "" && phone_txt.Text != "" && address_txt.Text != "" && password_txt.Text != "")
            {

                OracleCommand cmd_1 = new OracleCommand();
                cmd_1.Connection = con;
                // create auto increment id
                /*
                 create or replace PROCEDURE GET_MEMBER_ID
                ( mem_ID OUT NUMBER)
                AS
                BEGIN
                select max(MemberID)
                into mem_ID
                from Users;
                END GET_MEMBER_ID;
                 */
                int current_id;
                cmd_1.CommandText = "GET_MEMBER_ID";
                cmd_1.CommandType = CommandType.StoredProcedure;
                cmd_1.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd_1.ExecuteNonQuery();
                try
                {
                    current_id = Convert.ToInt32(cmd_1.Parameters["id"].Value.ToString());
                    current_id += 1;
                }
                catch
                {
                    current_id = 1;
                }


                /**/
                //birt_txt.Value.Year=;
                /**/
                //insert data
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = @"INSERT INTO Users
                             (MemberID,MemberName,Pass,MemberEmail,birthday,MemberPhone,MemberType,MemberAddress)
                             VALUES(:id,:name,:password,:mail,:birth,:phone,:type,:address)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", current_id);
                cmd.Parameters.Add("name", name_txt.Text);
                cmd.Parameters.Add("password", password_txt.Text);
                cmd.Parameters.Add("mail", email_txt.Text);
                cmd.Parameters.Add("birth", Convert.ToDateTime(birt_txt.Text));
                cmd.Parameters.Add("phone", phone_txt.Text);
                if (applicant_radio.Checked)
                {
                    cmd.Parameters.Add("type", "applicant");
                }
                else if (company_radio.Checked)
                {
                    cmd.Parameters.Add("type", "company");
                }
                cmd.Parameters.Add("address", address_txt.Text);
                int returned_value = cmd.ExecuteNonQuery();
                if (returned_value != -1)
                {
                    MessageBox.Show("Successfully Added");
                }
            }else
            {
                MessageBox.Show("Enter All Data");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Dispose();
        }
    }
}
