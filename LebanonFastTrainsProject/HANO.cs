using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace LebanonFastTrainsProject
{
    class HANO
    {
        public static string projConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\dernh\\Documents\\Visual Studio 2015\\Projects\\LebanonFastTrainsProject\\LebanonFastTrainsProject\\mydata\\LebanonFastTrainsOfficialDataBase.mdf\";Integrated Security = True; Connect Timeout = 30;";
        public static string userType= "passenger"; //CHANGE THIS TO PASSENGER
        public static string userFName = "Bourhan" ,userLName="Dernayka";
        public static string country = "Lebanon", city = "Mont Michel", street = "haykaliye";
        public static string mail = "hanodern@gmail.com";
        public static string number = "71015536";
        public static int userID ;//kenet =1039

       
        /// <summary>
        /// returns the DataSet of a query executed on the given connection string
        /// </summary>
        /// <param name="query"> Contains the query to be executed </param>
        /// <returns>a table of the results to be used as a data source</returns>
        public static DataTable SqlQueryExec(string query)
        {
            SqlConnection con = new SqlConnection(projConn);

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();

            sda.Fill(ds);

            con.Close();
            return ds.Tables[0];
        }
        public static DataTable SqlQueryExecMod(string query)
        {
            SqlConnection con = new SqlConnection(projConn);

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable ds = new DataTable();

            sda.Fill(ds);

            con.Close();
            return ds;
        }

        public static string SqlQueryScalarLogIn(string cmd)
        {
            string result = "";
            if (cmd == "") cmd = " ";
            SqlConnection SConn = new SqlConnection(projConn);
            SqlCommand SCmd = new SqlCommand("", SConn);
            SCmd.CommandText = cmd;
            SCmd.CommandType = CommandType.Text;
           
            SConn.Open();

            //execute
            try
            {
                result = SCmd.ExecuteScalar().ToString();
            }
            catch (SqlException c)
            {
                RadMessageBox.Show("Oops... I warned you...\nError is:" + c.Message, "Error: Wrong Format", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            catch (NullReferenceException) {
                RadMessageBox.Show("Error logging in!\n"+ "Wrong Username or Password.\tYou have 2 tries left.\nIf you are a new user, you can create a new account now for free!", "User Not Registered" );
            }
            SConn.Close();
            return result;
        }

        public static int SqlNonQueryExec(string cmd)
        {
            int a=0;
            if (cmd == "") cmd = " ";
            SqlConnection con = new SqlConnection(projConn);
            con.Open();
            SqlCommand SCmd = new SqlCommand(cmd, con);
            SCmd.CommandText = cmd;
            SCmd.CommandType = CommandType.Text;

            
            //execute
            try
            {
               a= SCmd.ExecuteNonQuery();
            }
            catch (SqlException c)
            {
                MessageBox.Show(c+"\nOops... I warned you...", "Error: Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, false);
            }


            con.Close();
            return a;
        }

        public static int SqlNonQueryExec2(string cmd)
        {
            int a = 0;
            if (cmd == "") cmd = " ";
            SqlConnection con = new SqlConnection(projConn);
            con.Open();
            SqlCommand SCmd = new SqlCommand(cmd, con);
            SCmd.CommandText = cmd;
            SCmd.CommandType = CommandType.Text;


            //execute
            try
            {
                a = SCmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                RadMessageBox.Show("Cannot delete this employee, he has active trips... Remove him from trips first. ","Protected active employee", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }


            con.Close();
            return a;
        }
        public static void msg(string s1,string s2)
        {
            RadDesktopAlert ra = new RadDesktopAlert();
            ra.CaptionText = s1;
            ra.ContentText = s2;
            ra.Show();
        }
    }
}
