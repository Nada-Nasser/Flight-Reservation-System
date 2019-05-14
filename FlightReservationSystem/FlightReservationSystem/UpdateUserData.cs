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
    public partial class UpdateUserData : Form
    {
        string ID;
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";

        public UpdateUserData(String id)
        {
            try
            {
                connetionString = @"Data Source = DESKTOP-R2QBSGS;
                                  Initial Catalog = Flight_Reservation;
                                  User ID = sa;
                                  Password =Password123";

                con = new SqlConnection(connetionString);

                con.Open();

                ID = id;

                InitializeComponent();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
       }

        private void Done_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = NameTxtBox.Text;
                string Email = IDTxtBox.Text;

                sql = "";
                /*
                 * UPDATE [dbo].[PASSENGER] SET [NAME] = 'Laila',  [EMAIL] = 'LailaAA111@gmail.com'
                 * WHERE [PASSENGER_ID] = 'AA111
                 */
                sql = "UPDATE [dbo].[PASSENGER] SET [NAME] = '" + Name + "',  [EMAIL] = '" + Email + "' WHERE [PASSENGER_ID] = '" + ID + "'";
                cmd = new SqlCommand(sql, con);

                DataAdapter = new SqlDataAdapter();
                DataAdapter.InsertCommand = new SqlCommand(sql, con);

                DataAdapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("your data is updated");

                AdmenForm form = new AdmenForm(Name, ID);
                this.Hide();
                form.Show();

                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            return;
        }

        private void NameTxtBox_TextChanged(object sender, EventArgs e)
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
