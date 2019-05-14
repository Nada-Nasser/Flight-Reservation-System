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
    public partial class Update_Flight : Form
    {
        string ID;
        string Name;
        bool isFound;
        string FlightID;

        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";

        public Update_Flight(string Id)
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

        private void Update_Flight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.flight_ReservationDataSet.FLIGHT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // do nothing
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(!isFound)
                {
                    MessageBox.Show("You didn't write a valid Flight number to update the Flight");
                    return;
                }
                ///Read new Fligth Data :
                string Date = DateTimeTB.Text;
                string Destination = DestTB.Text;
                string PiltID = PilotIDTB.Text;
                string nStops = nStopsTB.Text;
                string Duration = DurationTB.Text;
                string Source = SourceTB.Text;
                string nSeats = nSeatsTB.Text;

                /*
                 * 1- Search for the Flight using the ID
                 * 2- Update it using SQL query
                 * */
                ///*****************************************************
                ///Update the Flight data using Queries:-
                DataAdapter = new SqlDataAdapter();
                sql = "";
                /*
                 * UPDATE [dbo].[FLIGHT]
                    SET [DATE_AND_TIME] = '' , [DESTINATION_CITY] = '', [N_STOPS] = 00
                    , [DURATION] = 00  , [DEPARTURE_CITY] = '' , [N_AVAILABLESEATS] = 00
                    WHERE [FLIGHT_NO] = ''
                 * */
                sql = "UPDATE [dbo].[FLIGHT]";
                sql += " SET [DATE_AND_TIME] = '" + Date + "' ,[DESTINATION_CITY] = '" + Destination + "', [N_STOPS] = " + nStops;
                sql += " , [DURATION] =" + Duration + ", [DEPARTURE_CITY] = '" + Source + "' , [N_AVAILABLESEATS] = " + nSeats;
                sql += " WHERE [FLIGHT_NO] = '" + FlightID + "'";
                cmd = new SqlCommand(sql, con);

                DataAdapter.InsertCommand = new SqlCommand(sql, con);

                DataAdapter.InsertCommand.ExecuteNonQuery();

                DataAdapter.Dispose();
                cmd.Dispose();

                //***************************************
                // just get the Admin name to get back to its home page
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

// ************************************************************************************ 
        private void Select_Click(object sender, EventArgs e)
        {
            try
            {
                FlightID = inIDTB.Text;

                //1- Search for the Flight using the ID
                // SELECT [FLIGHT_NO] FROM [dbo].[FLIGHT] WHERE [FLIGHT_NO] = 'FN110'
                sql = "SELECT [FLIGHT_NO] FROM [dbo].[FLIGHT] WHERE [FLIGHT_NO] = '" + FlightID + "'";

                cmd = new SqlCommand(sql, con);

                DataReader = cmd.ExecuteReader();

                if (DataReader.Read())
                {
                    output = "";
                    output += DataReader.GetValue(0);
                    if (output == FlightID)
                    {
                        isFound = true;
                    }
                    else
                    {
                        isFound = false;
                        MessageBox.Show("NO Flight has this number");
                        DataReader.Close();
                        cmd.Dispose();
                        return;
                    }
                }

                DataReader.Close();
                cmd.Dispose();

                // Valid Flight number
                //****************************************************
                // change in TextBooks from read only  to Read/write
                inIDTB.ReadOnly = true;
                inIDTB.Text = FlightID;
                FlightIDTB.Text = FlightID;
                DateTimeTB.ReadOnly = false;
                DestTB.ReadOnly = false;
                PilotIDTB.ReadOnly = false;
                nSeatsTB.ReadOnly = false;
                DurationTB.ReadOnly = false;
                SourceTB.ReadOnly = false;
                nStopsTB.ReadOnly = false;
                nSeatsTB.ReadOnly = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
