using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Threading;
using System.Data.SqlClient;

namespace LebanonFastTrainsProject
{
    public partial class Form13 : RadForm
    {
        public Point point;
        public int stFrom,stTo;
        public bool ok = false;
        int stationID;
        private int trackID;

        public void openInForm<FormType>(FormType f) where FormType : Form
        {
            f.Tag = Tag;  //beddi el tag kermel hayda l InForm ye2der yeftah form jdid bi alb el FORM4.radTabel1
                          // mishen hek hala2 3melet el radTabel1.Modifiers = Public
            f.StartPosition = FormStartPosition.CenterParent;
            f.TopLevel = false;
            ((Form4)Tag).radPanel1.Controls.Add(f);
            f.Show();
        }
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 f = new Form9();
            openInForm(f);
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f = new Form5();

            openInForm(f);
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ok = false;
            Form14 f = new Form14();
            f.cas = "station";
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Tag = this;
            f.Show();
            
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (point ==null)
            {
                HANO.msg("Error", "Pick location first!");
                return;
            }
            SqlConnection conn = new SqlConnection(HANO.projConn);
            SqlCommand cmd = new SqlCommand("addStation", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = cmd.Parameters.Add("@name", SqlDbType.VarChar, 25);
            param.Value = radTextBox8.Text;

            param = cmd.Parameters.Add("@country", SqlDbType.VarChar, 50);
            param.Value = radTextBox9.Text;

            param = cmd.Parameters.Add("@city", SqlDbType.VarChar, 50);
            param.Value = radTextBox10.Text;

            param = cmd.Parameters.Add("@x", SqlDbType.Int);
            param.Value = point.X;

            param = cmd.Parameters.Add("@y", SqlDbType.Int);
            param.Value = point.Y;
            // Add the output parameter.

            param = cmd.Parameters.Add("@stationId", SqlDbType.Int);

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
                HANO.msg("", err.Message);
            }
            catch (NullReferenceException erno)
            {
                HANO.msg("", erno.Message);
            }

            try {
                stationID = int.Parse(param.Value.ToString());
            }
           catch(Exception)
            {
                HANO.msg("Ooops!", "You must fill all the info!");
            }


            if (stationID > 0)
            {
                HANO.msg("Station added successfully." ,"Station ID is: "+ param.Value);
           }
            else if (stationID == -1)
                HANO.msg("Already Exists!", "Newly created station was already existing.\nNo changes were made.");
            conn.Close();

        }

        private void radTextBox8_Click(object sender, EventArgs e)
        {
            if (radTextBox8.Text == "Station Name")
                radTextBox8.Text = "";
        }

        private void radTextBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radTextBox9_Click(object sender, EventArgs e)
        {
            if (radTextBox9.Text == "Country")
                radTextBox9.Text = "";
            
        }

        private void radTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox10_Click(object sender, EventArgs e)
        {
            if (radTextBox10.Text == "City")
                radTextBox10.Text = "";
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            if (stTo == 0 || stFrom==0)
            {
                HANO.msg("Error", "Pick stations first!");
                return;
            }
            SqlConnection conn = new SqlConnection(HANO.projConn);
            SqlCommand cmd = new SqlCommand("addTrack", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = cmd.Parameters.Add("@name", SqlDbType.VarChar, 25);
            param.Value = radTextBox1.Text;

            param = cmd.Parameters.Add("@stFrom", SqlDbType.Int);
            param.Value = stFrom;

            param = cmd.Parameters.Add("@stTo", SqlDbType.Int);
            param.Value = stTo;
            // Add the output parameter.

            param = cmd.Parameters.Add("@trId", SqlDbType.Int);

            param.Direction = ParameterDirection.Output;



            // Execute the command.

            conn.Open();
            try
            {
                cmd.ExecuteScalar();

            }
            catch (SqlException err)
            {
                HANO.msg("", err.Message);
            }
            catch (NullReferenceException erno)
            {
                HANO.msg("", erno.Message);
            }

            try
            {
                trackID = int.Parse(param.Value.ToString());
            }
            catch (Exception x)
            {
                HANO.msg("Ooops!", "Something went wrong!"+x.Message);
            }

            if (trackID > 0)
            {
                HANO.msg("Station added successfully.", "Track ID is: " + param.Value);
            }

            else if (trackID == -1)
                HANO.msg("Already Exists!", "Newly created station was already existing.\nNo changes were made.");
            conn.Close();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            HANO.SqlNonQueryExec("INSERT INTO train(name) VALUES('" + radTextBox3.Text + "')");
            HANO.msg("Train Added", "Id is hidden for security reasons.");
        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox3_Click(object sender, EventArgs e)
        {
            if (radTextBox10.Text == "Train Name")
                radTextBox10.Text = "";
        }

        private void radTextBox1_Click(object sender, EventArgs e)
        {
            if (radTextBox10.Text == "Track Name")
                radTextBox10.Text = "";
        }

        private void radMenuButtonItem4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form15 f = new Form15();
            openInForm(f);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            ok = false;
            Form14 f = new Form14();
            f.cas = "track";
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Tag = this;
            f.Show();
        }
    }
}
