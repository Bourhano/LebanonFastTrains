using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using LebanonFastTrainsProject;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Net.Mail;

namespace LebanonFastTrainsProject
{
    
    public partial class Form2 : RadForm
    {
        void print(object s) { RadMessageBox.Show(s.ToString());}
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radTextBox2.PasswordChar = '*';
            pictureBox5.Hide();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Aqua";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Tag = this;
            f.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            radPanel2.Location = radPanel1.Location;
            radPanel1.Hide();
            radLabel2.Hide();
            radPanel2.Show();
            pictureBox5.Show();
           
            
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            HANO.userType = HANO.SqlQueryScalarLogIn("SELECT type FROM login WHERE username='" + radTextBox1.Text + "' and password='" + radTextBox2.Text + "'");
            if (HANO.userType == "") return;
            HANO.userID = int.Parse(HANO.SqlQueryExec("SELECT userID FROM login WHERE username='" + radTextBox1.Text + "'").Rows[0][0].ToString());
            DataTable dt = HANO.SqlQueryExec("SELECT First_Name,Last_Name,locationID,email,Phone_Number FROM person WHERE loginID = '" + HANO.userID + "'");
            try
            {
                HANO.userFName = dt.Rows[0][0].ToString();
                HANO.userLName = dt.Rows[0][1].ToString();

                HANO.mail = dt.Rows[0][3].ToString();
                HANO.number = dt.Rows[0][4].ToString();

                loc = dt.Rows[0][2].ToString();
            }
            catch(Exception err)
            {
                print(err.Message);
            }

            dt = HANO.SqlQueryExec("SELECT country,city,street FROM location WHERE locationID = " + loc+ "");
            try
            {
                HANO.country = dt.Rows[0][0].ToString();
                HANO.city = dt.Rows[0][1].ToString();
                HANO.street = dt.Rows[0][2].ToString();
                
            }
            catch (Exception err)
            {
                print(err.Message);
            }
            switch (HANO.userType) 
            {
                case "admin":
                    HANO.msg("Welcome Back, "+HANO.userFName+"!","You are logged in as an ADMIN");
                    //(new Form2()).Show();
                    break;

                case "passenger":
                    HANO.msg("Welcome Back, " + HANO.userFName + "!", "You are logged in as a Passenger");
                    //(new Form6()).Show();
                    break;

                case "employee":
                    HANO.msg("Welcome Back, " + HANO.userFName + "!", "You are logged in as an Employee");
                    //(new Form5()).Show();
                    break;
                default:
                    {
                        HANO.msg("Error logging in!","Wrong Username or Password.\nTry again.\nIf you are a new user, you can create a new account now for free!");
                        return;
                    }
                   
                    
            }
            this.Close();
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radPanel3.Hide();
            radPanel1.Show();
            radLabel2.Show();
        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox3_Click(object sender, EventArgs e)
        {
            if(radTextBox3.Text == "First name")
                radTextBox3.Text = "";
        }

        private void radTextBox4_Click(object sender, EventArgs e)
        {
            if (radTextBox4.Text == "Last name")
                radTextBox4.Text = "";
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            radPanel1.Hide();
            radLabel2.Hide();
            radPanel3.Size = Size;
            radPanel3.Location = new Point(0, 0);
            radPanel3.Visible = true;
            radPanel3.Show();
        }

        private void radTextBox5_Click(object sender, EventArgs e)
        {
            if (radTextBox5.Text == "Email address or mobile number")
                radTextBox5.Text = "";
        }

        private void radTextBox6_Click(object sender, EventArgs e)
        {
            if (radTextBox6.Text == "Username")
                radTextBox6.Text = "";
        }

        private void radTextBox7_Click(object sender, EventArgs e)
        {
            if (radTextBox7.Text == "Password")
                radTextBox7.Text = "";
        }

        private void radTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
        bool ok;
        private string loc;

        private void radButton5_Click(object sender, EventArgs e)
        {

            bool validMail= ( radTextBox5.Text != null && new EmailAddressAttribute().IsValid(radTextBox5.Text));
            bool validNumber=true;
            foreach (char c in radTextBox5.Text)
            {
                validNumber = (c >= '0' && c <= '9');
                if (!validNumber) break;
            }
            ok = validMail;

            if (!validNumber && !validMail)
            {
                print("Please enter a valid email address / mobile number");
                return;
            }

            radPanel3.Hide();
            radPanel4.Size = Size;
            radPanel4.Location = new Point(0, 0);
            radPanel4.Visible = true;
            radPanel4.Show();

        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radPanel4.Hide();
            radPanel3.Show();
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            radPanel4.Size = Size;
            radPanel3.Size = Size;
        }

        private void radButton6_Click_1(object sender, EventArgs e)
        {
            int userId;
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


            param = cmd.Parameters.Add("@gender", SqlDbType.VarChar,7);  
            param.Value = (radCheckBox1.Checked?"Male":"Female");

            param = cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 50);
            param.Value = ok?radTextBox5.Text :"";

            param = cmd.Parameters.Add("@number", SqlDbType.BigInt);
            param.Value = ok ? 0: (Convert.ToUInt32(radTextBox5.Text)) ;

            param = cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
            param.Value = radTextBox6.Text;

            param = cmd.Parameters.Add("@pass", SqlDbType.VarChar, 30);
            param.Value = radTextBox7.Text;

            param = cmd.Parameters.Add("@type", SqlDbType.VarChar, 10);
            param.Value = "passenger";

            param = cmd.Parameters.Add("@country", SqlDbType.VarChar, 50);
            param.Value =  radTextBox8.Text;

            param = cmd.Parameters.Add("@city", SqlDbType.VarChar, 50);
            param.Value =  radTextBox9.Text;

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
           catch(SqlException err)
            {
                print(err.Message);
            }
            

            userId = int.Parse(param.Value.ToString());

            if (userId > 0)
            {
                //print("Your user ID is" + param.Value);
                HANO.userID = userId;
                HANO.userFName = radTextBox3.Text;
                HANO.userLName = radTextBox4.Text;
                HANO.userType = "passenger";
                HANO.country = radTextBox8.Text;
                HANO.city = radTextBox9.Text;
                HANO.street = radTextBox10.Text;
                HANO.mail = ok ? radTextBox5.Text : "";
                HANO.number = ok ? "" : radTextBox5.Text;
                Close();
                Form4 f4 = new Form4();
                f4.StartPosition = FormStartPosition.CenterScreen;
                f4.Show();
            }
            else if (userId == -1) RadMessageBox.Show("Username already exists.\nGo back and change it then try again","Change your username.",MessageBoxButtons.OK,RadMessageIcon.Exclamation);

            conn.Close();
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {

        }

        private void radCheckBox1_Click(object sender, EventArgs e)
        {
            radCheckBox2.Checked = radCheckBox1.Checked;
        }

        private void radCheckBox2_Click(object sender, EventArgs e)
        {
            radCheckBox1.Checked = radCheckBox2.Checked;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            radPanel1.Show();
            radLabel2.Show();
            radPanel2.Hide();
            pictureBox5.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
