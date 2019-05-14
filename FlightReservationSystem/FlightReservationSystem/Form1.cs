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
    public partial class LoginForm : Form
    {
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        string sql, output = "";

        public LoginForm()
        {
            connetionString = @"Data Source = DESKTOP-R2QBSGS;
                                  Initial Catalog = Flight_Reservation;
                                  User ID = sa;
                                  Password =Password123";

            con = new SqlConnection(connetionString);

            con.Open();

            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = NameTxtBox.Text;
                string ID = IDTxtBox.Text;

                //SELECT [TYPE] FROM [dbo].[PASSENGER] WHERE [PASSENGER_ID] = 'AA110' AND [NAME] like 'Aymen'


                sql = "SELECT [TYPE] FROM [dbo].[PASSENGER] WHERE [PASSENGER_ID] = '" + ID + "' AND [NAME] like '" + Name + "'";

                cmd = new SqlCommand(sql, con);
                DataReader = cmd.ExecuteReader();

                output = "";
                while (DataReader.Read())
                {
                    output += DataReader.GetValue(0);
                    if (output == "Admen")
                    {
                        // Here i should open a form that contain the operation that admin can perform.
                        
                        AdmenForm form = new AdmenForm(Name , ID);
                        this.Hide();
                        form.Show();
                        
                        DataReader.Close();
                        cmd.Dispose();

                        return;
                    }

                    output = "";
                }
                // Here i should open a form that contain the operation that USER can perform.
                /*
                * UserForm form = new UserForm();
                * this.Hide();
                * form.Show();
                */
                MessageBox.Show("USER FORM :D");
                DataReader.Close();
                cmd.Dispose();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            // Open the sign up form to take new user data 
            
             signUpForm form = new signUpForm("User");
             this.Hide();
             form.Show();
            
        }

        
    }
}
