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
    public partial class Form12 : RadForm
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

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            DataTable dt = HANO.SqlQueryExec("SELECT * FROM TotalPassengersView");
           

            //dg.AllowSorting = true;
            //dg.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            //dg.AlternatingBackColor = Color.AliceBlue;
            //dg.BackColor = Color.Pink;
            //dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.Size = Size;
            dg.Dock = DockStyle.Fill;
            dg.DataSource = dt;

            dg.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            dg.SelectionMode = GridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = false;
            dg.AllowAddNewRow = false;
            dg.AllowDeleteRow = false;
            dg.AllowEditRow = false;


            dg.Columns[2].BestFit();
            dg.Columns[5].BestFit();
            dg.Columns[9].BestFit();
            dg.Columns[10].BestFit();
            dg.Columns[11].BestFit();

            //dg.BorderStyle = BorderStyle.Fixed3D;
            //dg.CaptionVisible = false;
            //dg.Dock = DockStyle.Fill;
            //dg.MinimumSize = Size;


            Controls.Add(dg);
            dg.Show();
        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 f = new Form9();
            f.Tag = Tag;
            openInForm(f);
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f = new Form5();
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
