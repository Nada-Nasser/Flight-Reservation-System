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
    public partial class DeleteFlight : Form
    {
        string ID;
        string Name;

        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";


        public DeleteFlight(string id)
        {
            ID = id;
            connetionString = @"Data Source = DESKTOP-R2QBSGS;
                                  Initial Catalog = Flight_Reservation;
                                  User ID = sa;
                                  Password =Password123";

            con = new SqlConnection(connetionString);

            con.Open();

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFlight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.flight_ReservationDataSet.FLIGHT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string FID = FIDTB.Text;

                DataAdapter = new SqlDataAdapter();
                sql = "";
                //DELETE FROM [dbo].[FLIGHT] WHERE [FLIGHT_NO] = '00'

                sql = "DELETE FROM [dbo].[FLIGHT] WHERE [FLIGHT_NO] = '" + FID + "'";

                cmd = new SqlCommand(sql, con);

                DataAdapter.InsertCommand = new SqlCommand(sql, con);

                DataAdapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("one Flight is Deleted");

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
    }
}
