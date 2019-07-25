﻿using System;
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
    public partial class Form11 : RadForm
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
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f = new Form5();
            openInForm(f);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            int affected = 0, rowsAffected = -1;
            if (radCheckBox1.Checked)
            {
                bool validNumber = true;
                foreach (char c in radTextBox1.Text)
                {
                    validNumber = (c >= '0' && c <= '9');
                    if (!validNumber) break;
                }
                if (validNumber)
                {
                    affected = HANO.SqlNonQueryExec("DELETE FROM passenger WHERE passengerID = " + radTextBox1.Text);
                    if (affected > 0) MessageBox.Show("Deleted passenger from " + affected + " places successfully.");
                    if (affected == 0) MessageBox.Show("Passenger not found");
                }
                else MessageBox.Show("This is not a number...", "Error!");

            }
            else if (radCheckBox2.Checked)
            {
                DataTable dt = HANO.SqlQueryExec("SELECT personID FROM person WHERE First_Name='" + radTextBox2.Text + "' and Last_Name='" + radTextBox3.Text + "'");
                rowsAffected = dt.Rows.Count;
                switch (rowsAffected)
                {
                    case 0:
                        MessageBox.Show("No matching passengers found!");
                        break;
                    case 1:
                        HANO.SqlNonQueryExec("DELETE FROM passenger WHERE passenger.personID '" + dt.Rows[0][0].ToString() + "'");
                        MessageBox.Show("Removed the passenger successfully.", "Success");
                        break;
                    default:
                        RadDesktopAlert ra = new RadDesktopAlert();
                        ra.CaptionText = "Error Executing!";
                        ra.ContentText = "More than one passenger were found with the given first and last names!";
                        ra.Show();
                        break;
                }
            }
            else
            {
                RadDesktopAlert ra = new RadDesktopAlert();
                ra.CaptionText = "Select at least one method!";
                ra.ContentText = "You must select between the ID method or the First/Last Name method.";
                ra.Show();
            }
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            radCheckBox2.Checked = !radCheckBox1.Checked;
        }

        private void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            radCheckBox1.Checked = !radCheckBox2.Checked;
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void radTextBox2_Click(object sender, EventArgs e)
        {
            if (radTextBox2.Text == "First Name")
                radTextBox2.Text = "";
        }

        private void radTextBox3_Click(object sender, EventArgs e)
        {
            if (radTextBox3.Text == "Last Name")
                radTextBox3.Text = "";
        }

        private void radTextBox1_Click(object sender, EventArgs e)
        {
            if (radTextBox1.Text == "Number")
                radTextBox1.Text = "";
        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 f = new Form9();
            f.Tag = Tag;
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
