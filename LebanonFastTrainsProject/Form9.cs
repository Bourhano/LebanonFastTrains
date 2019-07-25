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
    public partial class Form9 : RadForm
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

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 f = new Form10();

            openInForm(f);
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f = new Form5();

            openInForm(f);
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 f = new Form11();

            openInForm(f);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form12 f = new Form12();
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
