using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Drawing.Printing;

namespace LebanonFastTrainsProject
{
    public partial class Form18 : RadForm
    {
        public int tripId;
        double price;
        double unitPrice = 0.5;
        private int ticket;

        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            


            DataRow dr = HANO.SqlQueryExec("SELECT * from totaltripsview where [Trip Number]="+tripId.ToString()).Rows[0];
            radLabel1.Text = "Trip #"+dr[0].ToString();
            radLabel10.Text = dr[1].ToString();
            radLabel13.Text = dr[8].ToString();
            radLabel17.Text = dr[2].ToString();
            radLabel18.Text = dr[3].ToString();
            radLabel15.Text = dr[4].ToString();
            radLabel16.Text = dr[5].ToString();
            radLabel19.Text = dr[6].ToString();
            radLabel20.Text = dr[7].ToString();
            radLabel14.Text = dr[9].ToString();

            //calc price
            DataRow drt = HANO.SqlQueryExec("SELECT * FROM TripCoordinates WHERE tripIDNumber = " + tripId.ToString()).Rows[0];
            double x = Convert.ToInt32(drt[1]), y = Convert.ToInt32(drt[2]), z = Convert.ToInt32(drt[3]), t = Convert.ToInt32(drt[4]);
            price = Math.Sqrt(Math.Pow((x - z), 2) + Math.Pow((y - t), 2));
            price = (float)System.Math.Round(price * unitPrice, 2);
            radLabel21.Text = (float)System.Math.Round(price * unitPrice, 2)  + " $";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(HANO.projConn);
            SqlCommand cmd = new SqlCommand("addTicket", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = cmd.Parameters.Add("@priceCoef", SqlDbType.Money);
            param.Value = price;

            param = cmd.Parameters.Add("@stnb", SqlDbType.Int);
            Random r = new Random();
            param.Value = r.Next(1,100);
            //MessageBox.Show(param.Value.ToString());

            param = cmd.Parameters.Add("@tripid", SqlDbType.Int);
            param.Value = tripId;
            //param.Value = radTimePicker1.Time;

            param = cmd.Parameters.Add("@clientid", SqlDbType.Int);
            param.Value = HANO.userID;

            // Add the output parameter.

            param = cmd.Parameters.Add("@ticketnb", SqlDbType.Int);

            param.Direction = ParameterDirection.Output;

       


            // Execute the command.

            conn.Open();
            try
            {
                cmd.ExecuteScalar();
            }
            catch (SqlException err)
            {
                HANO.msg("", err.Message);
            }
            catch (NullReferenceException erno)
            {
                HANO.msg("", erno.Message);
            }

            try
            {
                ticket = int.Parse(param.Value.ToString());
            }
            catch (Exception)
            {
                HANO.msg("You already bought this ticket...BAS ","Try to buy another ticket.");
            }


            if (ticket > 0)
            {
                HANO.msg("Ticket bought successfully.", "Your ticket number is: " + param.Value);
                if (HANO.mail != "")
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");

                        mail.From = new MailAddress("bourhan.dernayka@ul.edu.lb");
                        mail.To.Add(HANO.mail);
                        mail.Subject = "Lebanon Fast Trains";
                        mail.Body = "Your ticket reservation from "+radLabel16.Text+" to "+ radLabel20.Text+" has been done successfully.\n\nThe ticket price is : "+ (float)System.Math.Round(price * unitPrice, 2) + " $\nThe ticket number is : "+ param.Value+".";

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("bourhan.dernayka@ul.edu.lb", "Sq2$w!F1");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);
                        //MessageBox.Show("mail Send");
                    }
                    catch (Exception)
                    {
                        RadMessageBox.Show("invalid mail address found...");
                    }




                    HANO.msg("Reminder mail sent.", "A mail containing your ticket's details has been sent to your registered e-mail.");
                }
                else
                {
                    HANO.msg("Reminder mail not sent.", "We tried to contact you via e-mail to give you the trip details.\nPlease enter a mail address by managing your profile.");

                }

            }
            else if (ticket == -1)
                HANO.msg("You already bought this ticket...", "Try to buy a ticket for another trip.");
            conn.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form14 f = new Form14();
            f.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.tripId = tripId;
            f.cas = "viewTrip";
            f.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form17 f = new Form17();
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
        private System.Drawing.Printing.PrintDocument docToPrint;

        private void radButton3_Click(object sender, EventArgs e)
        {
            docToPrint = new System.Drawing.Printing.PrintDocument();
            // Allow the user to choose the page range he or she would
            // like to print.
            printDialog1.AllowSomePages = true;

            // Show the help button.
            printDialog1.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

       
        private void Form18_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
