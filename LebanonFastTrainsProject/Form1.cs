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
    enum Themes
    {
        AquaTheme = 1,
        DesertTheme = 2,
        BreezeTheme = 3,
        TelerikMetroBlueTheme = 4,
        HighContrastBlackTheme = 5,
        MaterialTealTheme = 6,
        Office2013DarkTheme = 7,
        Office2013LightTheme = 8,
        VisualStudio2012DarkTheme = 9,
        VisualStudio2012LightTheme = 10,
        Windows7Theme = 11,
        Windows8Theme = 12
    }

    
    public partial class Form1 : RadForm
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ThemeResolutionService.ApplicationThemeName = "Office2013Dark";//"MaterialTeal";
        }

        private void radMultiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radProgressBar1.Value1 < 100)
            {
                radProgressBar1.Value1 += 1;
                // radProgressBar1.Value2 += 5;
            }

            else {
                timer1.Enabled = false;
                radProgressBar1.Hide();

                this.Hide();
                Form2 f = new Form2();
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void radProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("This is a university project made by student Bourhan Dernayka, a third year electrical engineer as a database project for Dr Wassim El-Falou.\nThis project is still a prototype for a real time simulation and managment for a wide train circle all around the world.\nYou will find in this application many usefull options and a wide selection of designs.", "Welcome to your app! -------(ver 0.8.5)", MessageBoxButtons.OK, RadMessageIcon.Info, "Feel free to follow me on Twitter : @BourhanDernayka");
        }
    }
}
