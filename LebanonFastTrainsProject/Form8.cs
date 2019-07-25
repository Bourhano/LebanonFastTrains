using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace LebanonFastTrainsProject
{
    public partial class Form8 : RadForm
    {
        public void openInForm<FormType>(FormType f) where FormType : Form
        {
            f.Tag = Tag;  //beddi el tag kermel hayda l InForm ye2der yeftah form jdid bi alb el FORM4.radTabel1
                          // mishen hek hala2 3melet el radTabel1.Modifiers = Public
            f.StartPosition = FormStartPosition.CenterParent;
            f.TopLevel = false;
            ((Form4)Tag).radPanel1.Controls.Add(f);
            f.Show();
        }
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f = new Form5();
            openInForm(f);
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            int userId;
            
            bool validMail = (radTextBox5.Text != null && new EmailAddressAttribute().IsValid(radTextBox5.Text));
            bool validNumber = true;
            foreach (char c in radTextBox5.Text)
            {
                validNumber = (c >= '0' && c <= '9');
                if (!validNumber) break;
            }

            if (!validNumber && !validMail)
            {
                HANO.msg("Alert!","Please enter a valid email address / mobile number");
                return;
            }
            SqlConnection conn = new SqlConnection(HANO.projConn);
            SqlCommand cmd = new SqlCommand("addUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = cmd.Parameters.Add("@fname", SqlDbType.VarChar, 20);
            param.Value = radTextBox3.Text;


            param = cmd.Parameters.Add("@lname", SqlDbType.VarChar, 20);
            param.Value = radTextBox4.Text;



            param = cmd.Parameters.Add("@bdate", SqlDbType.Date);
            param.Value = radDateTimePicker1.Value;


            param = cmd.Parameters.Add("@gender", SqlDbType.VarChar, 7);
            param.Value = (radCheckBox1.Checked ? "Male" : "Female");

            param = cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 50);
            param.Value = validMail ? radTextBox5.Text : "";

            param = cmd.Parameters.Add("@number", SqlDbType.BigInt);
            param.Value = validMail ? 0 : (Convert.ToUInt32(radTextBox5.Text));

            param = cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
            param.Value = radTextBox6.Text;

            param = cmd.Parameters.Add("@pass", SqlDbType.VarChar, 30);
            param.Value = radTextBox7.Text;

            param = cmd.Parameters.Add("@type", SqlDbType.VarChar, 10);
            param.Value = "employee";

            param = cmd.Parameters.Add("@country", SqlDbType.VarChar, 50);
            param.Value = radTextBox8.Text;

            param = cmd.Parameters.Add("@city", SqlDbType.VarChar, 50);
            param.Value = radTextBox9.Text;

            param = cmd.Parameters.Add("@street", SqlDbType.VarChar, 50);
            param.Value = radTextBox10.Text;

            // Add the output parameter.

            param = cmd.Parameters.Add("@logID", SqlDbType.Int);

            param.Direction = ParameterDirection.Output;



            // Execute the command.

            conn.Open();
            try
            {
                //print("start");
                cmd.ExecuteScalar();
                //print("end");
            }
            catch (SqlException err)
            {
                HANO.msg("",err.Message);
            }


            userId = int.Parse(param.Value.ToString());

            if (userId > 0)
            {
               HANO.msg("New employee ID is" + param.Value,"");
            }
            else if (userId == -1)
                MessageBox.Show("Username already exists.\nGo back and change it then try again", "Change the username.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (radTextBox3.Text == "First name")
                radTextBox3.Text = "";
        }

        private void radTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (radTextBox4.Text == "Last name")
                radTextBox4.Text = "";
        }

        private void radTextBox5_TextChanged(object sender, EventArgs e)
        {

            if (radTextBox5.Text == "Email address or mobile number")
                radTextBox5.Text = "";
        }

        private void radTextBox6_TextChanged(object sender, EventArgs e)
        {
            if (radTextBox6.Text == "Username")
                radTextBox6.Text = "";
        }

        private void radTextBox7_Click(object sender, EventArgs e)
        {
            if (radTextBox7.Text == "Password")
                radTextBox7.Text = "";
        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 f = new Form9();
           
            openInForm(f);
        }

        private void radMenuButtonItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form13 f = new Form13();
            openInForm(f);
        }

        private void radMenuButtonItem4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form15 f = new Form15();
            openInForm(f);
        }
    }
}
