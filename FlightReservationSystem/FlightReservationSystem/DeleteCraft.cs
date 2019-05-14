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
    public partial class DeleteCraft : Form
    {
        string ID;
        string Name;
        bool isFound;
        string planeID;

        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";


        public DeleteCraft(string Id)
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

        private void DeleteCraft_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.flight_ReservationDataSet.AIRCRAFT);

        }

        private void Back_Click(object sender, EventArgs e)
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string PID = PIDTB.Text;

                DataAdapter = new SqlDataAdapter();
                sql = "";
                //DELETE FROM [dbo].[AIRCRAFT] WHERE [PLANE_ID] = '00'

                sql = "DELETE FROM [dbo].[AIRCRAFT] WHERE [PLANE_ID] = '" + PID + "'";

                cmd = new SqlCommand(sql, con);

                DataAdapter.InsertCommand = new SqlCommand(sql, con);

                DataAdapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("one Craft is Deleted");

                DataAdapter.Dispose();
                cmd.Dispose();

                ///**************************************************************************
                sql = "";
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


    }
}
