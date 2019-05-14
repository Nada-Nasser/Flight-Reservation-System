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
    public partial class Update_Craft_Details : Form
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

        public Update_Craft_Details(string Id)
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

        private void Update_Craft_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.AIRCOMPANY' table. You can move, or remove it, as needed.
            this.aIRCOMPANYTableAdapter.Fill(this.flight_ReservationDataSet.AIRCOMPANY);
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.flight_ReservationDataSet.AIRCRAFT);

        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                planeID = inPlaneIDTB.Text;

                //1- Search for the aircraft using the ID
                // SELECT [PLANE_ID] FROM [dbo].[AIRCRAFT] WHERE [PLANE_ID] = '00'
                sql = "SELECT [PLANE_ID] FROM [dbo].[AIRCRAFT] WHERE [PLANE_ID] = '" + planeID + "'";

                cmd = new SqlCommand(sql, con);

                DataReader = cmd.ExecuteReader();

                if (DataReader.Read())
                {
                    output = "";
                    output += DataReader.GetValue(0);
                    if (output == planeID)
                    {
                        isFound = true;
                    }
                    else
                    {
                        isFound = false;
                        MessageBox.Show("NO Craft has this ID");
                        DataReader.Close();
                        cmd.Dispose();
                        return;
                    }
                }

                DataReader.Close();
                cmd.Dispose();

                // Valid Craft ID
                //****************************************************
                // change in TextBooks from read only  to Read/write
                inPlaneIDTB.ReadOnly = true;
                inPlaneIDTB.Text = planeID;
                IDTxtBox.Text = planeID;
                ModelTxtBox.ReadOnly = false;
                CNameTxtBox.ReadOnly = false;
                nPassTxtBox.ReadOnly = false;
                MYearTxtBox.ReadOnly = false;

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DO NOTHING
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isFound)
                {
                    MessageBox.Show("You didn't write a valid Flight number to update the Flight");
                    return;
                }
                ///Read new craft Data :
                string Model = ModelTxtBox.Text;
                string companyName = CNameTxtBox.Text;
                string nPassengers = nPassTxtBox.Text;
                string ModelYear = MYearTxtBox.Text;

                /*
                 * 1- Search for the craft using the ID
                 * 2- Update it using SQL query
                 * */
                ///*****************************************************
                ///Update the Flight data using Queries:-

                DataAdapter = new SqlDataAdapter();
                sql = "";
                /*
                 * Update [dbo].[AIRCRAFT]
                    SET [MODEL] = '00' , [COMPANY_NAME] = 'Airbus SE' , [N_PASSENGERS] = 00 ,[MODEL_YEAR] = 00
                    WHERE [PLANE_ID] = '00'
                 * */
                sql = "Update [dbo].[AIRCRAFT]";
                sql += "SET [MODEL] = '" + Model + "' , [COMPANY_NAME] = '" + companyName + "' , [N_PASSENGERS] = "  + nPassengers
                    +  " ,[MODEL_YEAR] = " + ModelYear;
                sql += " WHERE [PLANE_ID] = '" + planeID + "'";
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

    }
}
