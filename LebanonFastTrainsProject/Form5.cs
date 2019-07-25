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

    public partial class Form5 : RadForm
    {
        Form lastCreated;
        public void openInForm<FormType>(FormType f) where FormType : Form
        {

            if (lastCreated != null)
                lastCreated.Close();

            lastCreated = f;

            f.Tag = Tag;  //beddi el tag kermel hayda l InForm ye2der yeftah form jdid bi alb el FORM4.radTabel1
                          // mishen hek hala2 3melet el radTabel1.Modifiers = Public
            f.StartPosition = FormStartPosition.CenterParent;
            f.TopLevel = false;
            ((Form4)Tag).radPanel1.Controls.Add(f);
            f.Show();
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            HANO.userType = "admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f = new Form6();
            
            openInForm(f);
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 f = new Form7();
            f.Tag = Tag;
            openInForm(f);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 f = new Form8();
            f.Tag = Tag;
            openInForm(f);
        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void radMenuButtonItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void radMenuButtonItem5_Click(object sender, EventArgs e)
        {

        }

        private void radMenuButtonItem6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 f = new Form9();
            f.Tag = Tag;
            openInForm(f);
        }

        private void radMenuButtonItem7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form13 f = new Form13();
            openInForm(f);
        }

        private void radMenuButtonItem8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form15 f = new Form15();
            openInForm(f);
        }
    }
}
