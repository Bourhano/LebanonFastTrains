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
    
    public partial class Form14 : RadForm
    {
        public string cas;
        public int tripId;
        DataTable dt, dtTrack;
        int pressed = 1;
        private int[] ex2;
        private int[] wy2,ex1, wy1;
        private int n;
        private int exn;


        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            dt = HANO.SqlQueryExec("SELECT * FROM station");
            
            
            foreach(DataRow dr in dt.Rows)
            {
                PictureBox p = new PictureBox();
                p.Image = new Bitmap(@"C:\Users\dernh\Documents\Visual Studio 2015\Projects\LebanonFastTrainsProject\LebanonFastTrainsProject\mydata\tren.png");
                p.Location = new Point(int.Parse(dr[2].ToString())-10, int.Parse(dr[3].ToString())-10);
               
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Size = new Size(20, 20);
                Controls.Add(p);
                p.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(pictureBox1_MouseDoubleClick);
                p.Tag = dr;
            }

            dtTrack = HANO.SqlQueryExec("SELECT * FROM track");

            n = dtTrack.Rows.Count;
            ex1 = new int[n];
            ex2 = new int[n];
            wy1 = new int[n];
            wy2 = new int[n];
            foreach (DataRow dr in dtTrack.Rows)
            {
                n--;
                string searchstring = dr[3].ToString();
                DataRow station1 = dt.Select("stationID = '" + searchstring + "'")[0];
                ex1[n] = int.Parse(station1[2].ToString());
                wy1[n] = int.Parse(station1[3].ToString());
                searchstring = dr[4].ToString();
                DataRow station2 = dt.Select("stationID = '" + searchstring + "'")[0];
                ex2[n] = int.Parse(station2[2].ToString());
                wy2[n] = int.Parse(station2[3].ToString());
                
            }
            exn =ex1.Length;
            
           
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (cas)
            {
                case "station":
                    ((Form13)Tag).point = e.Location;
                    ((Form13)Tag).ok = true;
                    this.Close();
                    break;
                case "track":
                    PictureBox p=new PictureBox();
                    
                    try {
                        p= (PictureBox)sender;
                    }
                    catch(InvalidCastException)
                    {
                        HANO.msg("Error selecting Station", "Please press on an available station!");
                    }
                    catch (NullReferenceException)
                    {
                        HANO.msg("Error selecting Station", "Please press on an available station!");

                    }

                    //ma 3am e2der el2ot iza kabas barra so:
                    
         

                    if (pressed == 1)
                    {
                        ((Form13)Tag).stFrom = (int)((DataRow)p.Tag)[0];
                        HANO.msg("Selected First Station", "This is the departure station");
                    }
                       
            
                    if (pressed == 0) {
                        ((Form13)Tag).stTo = (int)((DataRow)p.Tag)[0];
                        HANO.msg("Selected Second Station", "This is the arriving station\nDone Selecting.");
                        this.Close();
                    }
                    pressed--;
                    break;
                case "tripFrom":
                    p = new PictureBox();
                    try
                    {
                        p = (PictureBox)sender;
                    }
                    catch (InvalidCastException)
                    {
                        HANO.msg("Error selecting Station", "Please press on an available station!");
                    }
                    catch (NullReferenceException)
                    {
                        HANO.msg("Error selecting Station", "Please press on an available station!");
                    }

                    //MessageBox.Show("clicked" + ((DataRow)p.Tag)[1].ToString()+ (int)((DataRow)p.Tag)[0]);

                    ((Form15)Tag).stFromId = (int)((DataRow)p.Tag)[0];
                    ((RadTextBox)(((Form15)Tag).radTextBox1)).Text = ((DataRow)p.Tag)[1].ToString();
                    
                    HANO.msg("Selected departure Station", "This is the departure station");
                    this.Close();
                    break;

                case "tripTo":
                    p = new PictureBox();
                    try
                    {
                        p = (PictureBox)sender;
                    }
                    catch (InvalidCastException)
                    {
                        HANO.msg("Error selecting Station", "Please press on an available station!");
                    }
                    catch (NullReferenceException)
                    {
                        HANO.msg("Error selecting Station", "Please press on an available station!");
                    }

                   // MessageBox.Show("clicked" + ((DataRow)p.Tag)[1].ToString() + (int)((DataRow)p.Tag)[0]);

                    ((Form15)Tag).stToId = (int)((DataRow)p.Tag)[0];
                    Form15 f = (Form15)Tag;
                    f.radTextBox2.Text = ((DataRow)p.Tag)[1].ToString();
                    
                    HANO.msg("Selected Arrival Station", "This is the arrival station");
                    this.Close();
                    break;
                case "view":
                    
                    break;
                case "viewTrip":
                    
                    break;
            }
            
        }

        private void Form14_Paint(object sender, PaintEventArgs e)
        {

           // OnPaint(null);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //DrawLineInt(e);
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

           Pen blackPen = new Pen(Color.Black);
           //blackPen.Width = 10;
         

            for (int i = 0; i < exn; i++)
            {
                int x= ex1[i], y=wy1[i], z= ex2[i], t=wy2[i];
                g.DrawLine(blackPen, x, y, z, t);
               
            }
            if (cas == "viewTrip")
            {
               DataRow dr= HANO.SqlQueryExec("SELECT * FROM TripCoordinates WHERE tripIDNumber = " + tripId.ToString()).Rows[0];
                int x = Convert.ToInt32(dr[1]), y = Convert.ToInt32(dr[2]), z = Convert.ToInt32(dr[3]), t = Convert.ToInt32(dr[4]);
                g.DrawLine(new Pen(Color.Red,5), x, y, z, t);
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
