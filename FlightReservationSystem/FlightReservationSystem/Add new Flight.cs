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

namespace FlightReservationSystem
{
    public partial class Add_new_Flight : Form
    {
        string ID;
        string Name;

        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";

        public Add_new_Flight(string Id)
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

        private void Add_new_Flight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.FLY' table. You can move, or remove it, as needed.
            this.fLYTableAdapter.Fill(this.flight_ReservationDataSet.FLY);
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.flight_ReservationDataSet.FLIGHT);

        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string Date = DateTimeTB.Text;
                string Destination = DestTB.Text;
                string PiltID = PilotIDTB.Text;
                string nStops = nStopsTB.Text;
                string Duration = DurationTB.Text;
                string Source = SourceTB.Text;
                string FlightID = FlightIDTB.Text;
                string nSeats = nSeatsTB.Text;

                DataAdapter = new SqlDataAdapter();
                sql = "";

                sql = "INSERT INTO [dbo].[FLIGHT] VALUES( '" + Date + "' , '" + Destination + "' , '" + PiltID + "' , " + nStops + ", " + Duration + " , '" + Source + "' , '" + FlightID + "' , " + nSeats + ")";

                cmd = new SqlCommand(sql, con);

                DataAdapter.InsertCommand = new SqlCommand(sql, con);

                DataAdapter.InsertCommand.ExecuteNonQuery();

                DataAdapter.Dispose();
                cmd.Dispose();

                //***************************************
                
                sql = "SELECT [NAME] FROM [dbo].[PASSENGER] WHERE [PASSENGER_ID] like '" + ID + "'";

                cmd = new SqlCommand(sql, con);

                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    output = "";
                    output += DataReader.GetValue(0);
                }

                Name = output;
                
                AdmenForm form = new AdmenForm(Name, ID);
                this.Hide();
                form.Show();

                DataReader.Close();
                cmd.Dispose();
                con.Close();
                
                return;

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            MessageBox.Show("You wrote invalid data");
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //***************************************

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
    }
}
