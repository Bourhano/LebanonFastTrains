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

namespace LebanonFastTrainsProject
{
    public partial class Form16 : RadForm
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            string str;
            try {
                str = HANO.SqlQueryExec("select top 1 [Departure City] from TotalTripsView where [Departure Time] > '" + hour + ":" + minute + "'").Rows[0][0].ToString();
                str += " to ";
                str += HANO.SqlQueryExec("select top 1 [Arrival City] from TotalTripsView where [Departure Time] > '" + hour + ":" + minute + "'").Rows[0][0].ToString();
                radLabel2.Text = str;
                radLabel3.Text = "at " + HANO.SqlQueryExec("select top 1 [Departure Time] from TotalTripsView where [Departure Time] > '" + hour + ":" + minute + "'").Rows[0][0].ToString();
            }
            catch (Exception)
            {
                radLabel2.Text = "Beirut To Jounieh";
                radLabel3.Text = "at 12:00 ";
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form17 f = new Form17();
            openInForm(f);
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

        private void radButton2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form14 f = new Form14();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            f.cas = "view";
            f.Show();
            //openInForm(f);
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form19 f = new Form19();
            openInForm(f);
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form20 f = new Form20();
            openInForm(f);
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form21 f = new Form21();
            openInForm(f);
        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
