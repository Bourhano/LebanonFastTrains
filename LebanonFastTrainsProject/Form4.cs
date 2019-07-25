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
   
    public partial class Form4 : RadForm
    {

        //Form lastCreated;
        public Form4()
        {
            InitializeComponent();
        }
        Form toAdd;
        private void Form4_Load(object sender, EventArgs e)
        {
            radLabel2.Text = HANO.userFName + " " + HANO.userLName;
            WindowState = FormWindowState.Maximized;
           // HANO.msg(Width.ToString() + Height,"");
           
            
            radLabel1.Text = HANO.userType;
            radLabel3.Text = HANO.country;
            radLabel4.Text = HANO.city;
            radLabel5.Text = HANO.street;

            switch (HANO.userType)
            {
                case "admin":
                    toAdd = new Form5();

                    break;

                case "passenger":
                    toAdd = new Form16();

                    break;

                case "employee":
                    toAdd = new Form5();

                    break;
                

            }
            
            openInForm(toAdd);
        }

        public void openInForm<FormType>(FormType f) where FormType : Form
        {
            
            //if (lastCreated != null)
            //    lastCreated.Close();
            //lastCreated = f;

            f.Tag = this;  //beddi el object taba3 Form4 (mkhabeye bl tag) kermel hayda l InForm ye2der yeftah form jdid bi alb el FORM4.radTabel1
                            // mishen hek hala2 3melet el radTabel1.Modifiers = Public
            f.StartPosition = FormStartPosition.CenterParent;
            f.TopLevel = false;
            radPanel1.Controls.Add(f);
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            
            f.Tag = this;
            f.Show();
        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
