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

namespace LebanonFastTrainsProject
{
    public partial class Form17 : RadForm
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            //radGridView1.Size = Size;
            //radGridView1.Dock = DockStyle.Fill;
            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            radGridView1.SelectionMode = GridViewSelectionMode.FullRowSelect;
            radGridView1.MultiSelect = false;
            radGridView1.AllowAddNewRow = false;
            radGridView1.AllowDeleteRow = false;
            radGridView1.AllowEditRow = false;
            
            radGridView1.DataSource = HANO.SqlQueryExec("SELECT DISTINCT [Trip Number],[Departure City],[Departure Time],[Arrival City],[Arrival Time] FROM TotalTripsView order by [Departure Time]");
            //PLEASE COLOR THE ARRIVAL AND DEPARTURE COLOMNS


        }

        private void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            // var lineSelected = radGridView1.SelectedCells[0].RowIndex;
            var lineSelected = e.RowIndex;
            var rowSelected = radGridView1.Rows[lineSelected];
            string tripSelected = Convert.ToString(rowSelected.Cells[0].Value);
            //RadMessageBox.ShowInTaskbar = true;
            //RadMessageBox.Show(tripSelected,"selected!!");
           
            Form18 f = new Form18();
            Hide();
            f.tripId = Convert.ToInt32(tripSelected);
            openInForm(f);   // GET THIS BACK WHEN DONE!!!
            
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form16 f = new Form16();
            openInForm(f);
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
