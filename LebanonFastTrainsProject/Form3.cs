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
    public partial class Form3 : RadForm
    {
        string activeTheme;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radToggleSwitch1.Value = false;
            comboBox1.Text =lastTheme= ThemeResolutionService.ApplicationThemeName;
            if (comboBox1.Text=="") comboBox1.Text = "MyTheme";
            // HANO.msg(lastTheme,"");
            comboBox2.Text = "English";
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            
            if (!radToggleSwitch1.Value)
            {
                activeTheme = comboBox1.Text;
                if (activeTheme == "MyTheme") activeTheme = "";
                lastTheme = activeTheme;
                
                ThemeResolutionService.ApplicationThemeName = activeTheme;

            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            HANO.userType = "passenger";
            Form2 f = new Form2();
            f.StartPosition = FormStartPosition.CenterScreen;
            ((Form)this.Tag).Close(); //kermel ysakker el form yalli khala2ou
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radToggleButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {

        }
       static string lastTheme ;
        private void radToggleSwitch1_ValueChanged(object sender, EventArgs e)
        {
            if(radToggleSwitch1.Value)
            {
                lastTheme = ThemeResolutionService.ApplicationThemeName;
                
                ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";
                
            }
            else
            {
                ThemeResolutionService.ApplicationThemeName = lastTheme;
            }

        }
    }
}
