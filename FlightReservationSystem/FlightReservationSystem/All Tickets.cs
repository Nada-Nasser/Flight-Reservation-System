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
    public partial class All_Tickets : Form
    {
        String ID;
        String Name;
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        
        string sql, output = "";

        public All_Tickets(string Id)
        {
            connetionString = @"Data Source = DESKTOP-R2QBSGS;
                                  Initial Catalog = Flight_Reservation;
                                  User ID = sa;
                                  Password =Password123";

            con = new SqlConnection(connetionString);

            con.Open();
            //***************************************
            ID = Id;
            
            InitializeComponent();
        }

        private void All_Tickets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.TICKET' table. You can move, or remove it, as needed.
            this.tICKETTableAdapter.Fill(this.flight_ReservationDataSet.TICKET);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.tICKETTableAdapter.Update(this.flight_ReservationDataSet.TICKET);

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
        }
    }
}
