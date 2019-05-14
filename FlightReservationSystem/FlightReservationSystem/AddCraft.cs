using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//INSERT INTO [dbo].[AIRCRAFT] VALUES ( ' Growle' , 'EA-18G' ,'The Boeing',5000, 2001)

namespace FlightReservationSystem
{
    public partial class AddCraft : Form
    {
        string ID;
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";

        public AddCraft(string Id)
        {
            try
            {
                connetionString = @"Data Source = DESKTOP-R2QBSGS;
                                  Initial Catalog = Flight_Reservation;
                                  User ID = sa;
                                  Password =Password123";

                con = new SqlConnection(connetionString);

                con.Open();
                ID = Id;

                InitializeComponent();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

            
       }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Model = ModelTxtBox.Text;
                string newID = IDTxtBox.Text;
                string Cname = CNameTxtBox.Text;
                string nPass = nPassTxtBox.Text;
                string Year = MYearTxtBox.Text;

                DataAdapter = new SqlDataAdapter();
                sql = "";
                //INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'AC' , 'AC110' ,'The Boeing',450, 2015)
                sql = "INSERT INTO [dbo].[AIRCRAFT] VALUES ( '" + Model + "' , '" + newID + "' ,'" + Cname + "'," + nPass + " , " + Year + ")";

                cmd = new SqlCommand(sql, con);

                DataAdapter.InsertCommand = new SqlCommand(sql, con);

                DataAdapter.InsertCommand.ExecuteNonQuery();
                ///******************************************************
                sql = "SELECT [NAME] FROM [dbo].[PASSENGER] WHERE [PASSENGER_ID] like '" + ID + "'";

                cmd = new SqlCommand(sql, con);

                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    output = "";
                    output += DataReader.GetValue(0);
                }

                Name = output;
                
                ///*******************************************************
                AdmenForm form = new AdmenForm(Name, ID);
                this.Hide();
                form.Show();

                cmd.Dispose();
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void AddCraft_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.AIRCOMPANY' table. You can move, or remove it, as needed.
            this.aIRCOMPANYTableAdapter.Fill(this.flight_ReservationDataSet.AIRCOMPANY);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT [NAME] FROM [dbo].[PASSENGER] WHERE [PASSENGER_ID] like '" + ID + "'";

                cmd = new SqlCommand(sql, con);

                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    output = "";
                    output += DataReader.GetValue(0);
                }

                Name = output;

                DataReader.Close();
                cmd.Dispose();
                con.Close();

                AdmenForm form = new AdmenForm(Name, ID);
                this.Hide();
                form.Show();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
