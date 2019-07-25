using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace LebanonFastTrainsProject
{
    public partial class Form22 : RadForm
    {
        //string fBody1 ="";
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            //PrintDocument pd = new PrintDocument();
            //PaperSize ps = new PaperSize("", 420, 540);
            //pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            
        }
        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void Form22_Paint(object sender, PaintEventArgs e)
        {
            //int SPACE = 100;
            //Graphics g = e.Graphics;
            //g.DrawRectangle(Pens.Black, 5, 5, 410, 530);
            //string title = @"C: \Users\dernh\Documents\Visual Studio 2015\Projects\LebanonFastTrainsProject\LebanonFastTrainsProject\mydata\icon.png";
            //g.DrawImage(Image.FromFile(title), 50, 70,75,75);
            //Font fBody = new Font("Lucida Console", 15, FontStyle.Bold);
            //SolidBrush sb = new SolidBrush(Color.Black);
            //g.DrawString("------------------------------", fBody, sb, 10, SPACE);
            //g.DrawString("Date :", fBody, sb, 10, 100);
            //g.DrawString(DateTime.Now.ToShortDateString(), fBody, sb, 90, SPACE);
            //g.DrawString("Time :", fBody, sb, 10, SPACE + 30);
            //g.DrawString(DateTime.Now.ToShortTimeString(), fBody, sb, 90, SPACE + 30);
            //Image imgBarcode = BarcodeLib.Barcode.DoEncode(BarcodeLib.TYPE.CODE128, no.ToString(), true, Color.Black, Color.White, 200, 60);

        }
    }
}
