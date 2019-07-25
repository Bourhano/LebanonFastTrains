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
    public partial class Form21 : RadForm
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            DataRow dr = HANO.SqlQueryExec("SELECT * from TotalPassengersViewWithPass where [Online User Number]=" + HANO.userID.ToString()).Rows[0];
            radTextBox1.Text = dr[2].ToString();
            radTextBox2.Text = dr[3].ToString();
            radTextBox3.Text = dr[7].ToString();
            radTextBox4.Text = dr[8].ToString();
            radTextBox5.Text = dr[9].ToString();
            radTextBox8.Text = dr[4].ToString();
            
            radDateTimePicker1.Value = Convert.ToDateTime(dr[6].ToString());
            radTextBox6.Text = dr[11].ToString();
            radTextBox7.Text = dr[12].ToString();
            radTextBox9.Text = dr[13].ToString();
            radTextBox10.Text = dr[14].ToString();
            radTextBox11.Text = dr[15].ToString();
            //MessageBox.Show(radDateTimePicker1.Value.Month.ToString());

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form16 f = new Form16();
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

        private void radButton1_Click(object sender, EventArgs e)
        {
            string ok = RadMessageBox.Show("Edits were made.\n\nDo you want to save changes?", "WARNING!", MessageBoxButtons.YesNo).ToString();
            if (ok == "Yes")
            {
               // MessageBox.Show("startimg");
                HANO.SqlNonQueryExec("UPDATE TotalPassengersViewWithPass SET First_Name = '" + radTextBox1.Text + "', Last_Name = '" + radTextBox2.Text + "', [Preffered Name] = '" + radTextBox8.Text + "'"+", [Birth Date] = '" + radDateTimePicker1.Value.Month+ "/"+radDateTimePicker1.Value.Day+"/"+ radDateTimePicker1.Value.Year + "' , [E-mail] = '"+radTextBox6.Text + "' , [Phone Number] = "+radTextBox7.Text +" where [Online User Number] = " + HANO.userID);
               // MessageBox.Show("done 1");
                HANO.SqlNonQueryExec("UPDATE TotalPassengersViewWithPass SET Country = '" + radTextBox3.Text + "', City = '" + radTextBox4.Text + "', Street = '" + radTextBox5.Text + "' where [Online User Number] = " + HANO.userID);
                
                HANO.SqlNonQueryExec("UPDATE TotalPassengersViewWithPass SET username = '" + radTextBox9.Text + "', password = '" + radTextBox10.Text + "' where [Online User Number] = " + HANO.userID);
               
                RadMessageBox.Show("Data Updated Successfully", "Saved!", MessageBoxButtons.OK);

            }
            else
            {
                RadMessageBox.Show("Changes have been discarded." , "Not saved!", MessageBoxButtons.OK);
            }

        }
    }
}
