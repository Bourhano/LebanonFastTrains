using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Form15 : RadForm
    {
        int tripID;
        public int stFromId, stToId;
        public object stFromName, stToName;
        private bool fromDayToDay= false;

        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        { 
            //MessageBox.Show(radTimePicker1.Value.Value.Hour.ToString()+":"+ radTimePicker1.Value.Value.Minute.ToString()+":"+ radTimePicker1.Value.Value.Second.ToString());
            DataTable dt = HANO.SqlQueryExecMod("SELECT name FROM train");
            dt.TableName = "trains";
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
            comboBox1.DataSource = dt;
           

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.cas = "tripFrom";
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Tag = this;
            f.Show();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            int duration = ((radTimePicker2.Value.Value - radTimePicker1.Value.Value).Hours*60 + (radTimePicker2.Value.Value - radTimePicker1.Value.Value).Minutes);
            fromDayToDay = radCheckBox1.Checked;
            if (duration < 0)
            {
                if (!fromDayToDay)
                {
                    HANO.msg("Times are wrongly set", "The departure time is set before the arrival time.\nFix to proceed.");
                    return;
                }

            }
            if(radTextBox1.Text=="" || radTextBox2.Text == "" || radTextBox3.Text=="")
            {
                HANO.msg("Pick up destinations.", "Destinations weren't set properly.\nFix to proceed.");
                return;
            }


            SqlConnection conn = new SqlConnection(HANO.projConn);
            SqlCommand cmd = new SqlCommand("addTrip", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = cmd.Parameters.Add("@duration", SqlDbType.Float);
            param.Value = duration;

            param = cmd.Parameters.Add("@trainId", SqlDbType.Int);
            DataTable dt = HANO.SqlQueryExec("SELECT trainID from train where name = '" + comboBox1.Text + "'");
           //MessageBox.Show(dt.Rows[0].ToString(),"");
            param.Value = int.Parse(dt.Rows[0][0].ToString());
            //MessageBox.Show(param.Value.ToString());

            param = cmd.Parameters.Add("@depTime", SqlDbType.Time,2);
            param.Value = ""+radTimePicker1.Value.Value.Hour.ToString() + ":" + radTimePicker1.Value.Value.Minute.ToString() + ":" + radTimePicker1.Value.Value.Second.ToString()+"";
            //param.Value = radTimePicker1.Time;

            param = cmd.Parameters.Add("@arrTime", SqlDbType.Time, 2);
            param.Value = "" + radTimePicker2.Value.Value.Hour.ToString() + ":" + radTimePicker2.Value.Value.Minute.ToString() + ":" + radTimePicker2.Value.Value.Second.ToString() + "";
            //param.Value = radTimePicker2.Value.Value;

            param = cmd.Parameters.Add("@depStationId", SqlDbType.Int);
            param.Value = stFromId;

            param = cmd.Parameters.Add("@arrStationId", SqlDbType.Int);
            param.Value = stToId;

            param = cmd.Parameters.Add("@staffnb", SqlDbType.Int);
            param.Value = radTextBox3.Text;

            // Add the output parameter.

            param = cmd.Parameters.Add("@tripId", SqlDbType.Int);

            param.Direction = ParameterDirection.Output;

            //mashi bass hek
           


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
                 tripID = int.Parse(param.Value.ToString());
            }
            catch (Exception)
            {
                HANO.msg("Ooops!", "You must fill all the info!");
            }


            if (tripID > 0)
            {
                HANO.msg("Trip added successfully.", "Trip ID is: " + param.Value);
            }
            else if (tripID == -1)
                HANO.msg("Already Exists!", "Newly added trip was already existing.\nNo changes were made.");
            conn.Close();
        }

        private void radMenuButtonItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form13 f = new Form13();
            openInForm(f);
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

        private void radTimePicker2_Click(object sender, EventArgs e)
        {

        }

        private void radMenuButtonItem4_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.cas = "tripTo";
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Tag = this;
            f.Show();
        }
        public void openInForm<FormType>(FormType f) where FormType : Form
        {
            f.Tag = Tag;  //beddi el tag kermel hayda l InForm ye2der yeftah form jdid bi alb el FORM4.radTabel1
                          // mishen hek hala2 3melet el radTabel1.Modifiers = Public
            f.StartPosition = FormStartPosition.CenterParent;
            f.TopLevel = false;
            ((Form4)Tag).radPanel1.Controls.Add(f);
            f.Show();
        }
    }
}
