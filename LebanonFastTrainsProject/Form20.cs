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
    public partial class Form20 : RadForm
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            radGridView1.SelectionMode = GridViewSelectionMode.FullRowSelect;
            radGridView1.MultiSelect = false;
            radGridView1.AllowAddNewRow = false;
            radGridView1.AllowDeleteRow = false;
            radGridView1.AllowEditRow = false;
            radToggleSwitch1.Value = false;
            radToggleSwitch2.Value = false;
            radToggleSwitch3.Value = false;
        }

        private void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
      
        }

        private void radCheckBox3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
           
        }
        string where = "WHERE ",and = "and ",cond1="",cond2="",cond3="";
        private string query;

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form16 f = new Form16();
            openInForm(f);
        }

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            // var lineSelected = radGridView1.SelectedCells[0].RowIndex;
            var lineSelected = e.RowIndex;
            var rowSelected = radGridView1.Rows[lineSelected];
            string tripSelected = Convert.ToString(rowSelected.Cells[0].Value);
            //RadMessageBox.ShowInTaskbar = true;
            //RadMessageBox.Show(tripSelected, "selected!!");

            Form18 f = new Form18();
            
            f.tripId = Convert.ToInt32(tripSelected);
            f.FormBorderStyle = FormBorderStyle.Sizable;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            

            // openInForm(f);   // GET THIS BACK WHEN DONE!!!
        }

        private void radToggleSwitch1_ValueChanged(object sender, EventArgs e)
        {
            if (radToggleSwitch1.Value)
            {
                radTextBox1.Enabled = true;
                radTextBox2.Enabled = true;
            }
        }

        private void radToggleSwitch2_ValueChanged(object sender, EventArgs e)
        {
            if (radToggleSwitch2.Value) { 
                radTextBox4.Enabled = true;
            }
        }

        private void radToggleSwitch3_ValueChanged(object sender, EventArgs e)
        {
            if (radToggleSwitch3.Value)
            {
                radTextBox5.Enabled = true;
            }
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

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (radToggleSwitch1.Value)
            {
                radTextBox1.Enabled = true;
                radTextBox2.Enabled = true;

            }
        }
        string and1 = "and ";
        private void radButton1_Click(object sender, EventArgs e)
        {
            int adad = 0;
            if (radToggleSwitch1.Value)
            {
                adad++;
                where = "where ";
                cond1 = "[Departure City]= '" + radTextBox1.Text + "' and [Arrival City] = '" + radTextBox2.Text + "' ";
            }
            else cond1 = "";
            if (radToggleSwitch2.Value)
            {
                adad++;
                where = "where ";
                cond2 = "[Departure Time]= '" + radTextBox4.Text + "' ";
            }
            else cond2 = "";
            if (radToggleSwitch3.Value)
            {
                adad++;
                where = "where ";
                cond3 = "[Pricee] <= " + radTextBox5.Text+ " ";
            }
            else cond3 = "";

            if (!radToggleSwitch1.Value && !radToggleSwitch2.Value && !radToggleSwitch3.Value) {
                where = "";
                and = "";
                and1 = "";
                cond1 = "";
                cond2 = "";
                cond3 = "";
            }
            if (adad == 1)
            {
                and = "";
                and1 = "";
            }
           if (adad == 2)
            {
                if (radToggleSwitch1.Value)
                {
                    and = "and ";
                    and1 = "";
                }
                else
                {
                    and = "";
                    and1 = "and ";
                }
            }
            try
            {
                query = "SELECT DISTINCT [Trip Number],[Trip Duration],[Departure City],[Departure Time],[Arrival City],[Arrival Time], Pricee FROM TotalPricedTripsView ";
               // MessageBox.Show(query + where + cond1 + and + cond2 + and1 + cond3);
                radGridView1.DataSource = HANO.SqlQueryExec(query + where + cond1 + and + cond2 + and1 + cond3);
                
            }
            catch (Exception er)
            {
                RadMessageBox.Show(er.Message);
            }

        }
    }
}
