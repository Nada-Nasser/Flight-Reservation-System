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
    public partial class signUpForm : Form
    {
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";
        string Type;

        public signUpForm(string type)
        {
            Type = type;
            connetionString = @"Data Source = DESKTOP-R2QBSGS;
                                  Initial Catalog = Flight_Reservation;
                                  User ID = sa;
                                  Password =Password123";

            con = new SqlConnection(connetionString);

            con.Open();

            InitializeComponent();
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = NameTxtBox.Text;
                string ID = IDTxtBox.Text;
                string Email = EmailTxtBox.Text;
                

                //INSERT INTO [dbo].[PASSENGER] VALUES ('AA113' ,'AmiraAA113@yahoo.com' , 'Amira' , 'Admen') 

                DataAdapter = new SqlDataAdapter();
                sql = "";
                sql = "INSERT INTO [dbo].[PASSENGER] VALUES ('" + ID + "' , '" + Email + "' , '" + Name + "' , '" + Type + "')";

                cmd = new SqlCommand(sql, con);

                DataAdapter.InsertCommand = new SqlCommand(sql, con);

                DataAdapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("You can back and sign in now..");
                
                this.Close();
                LoginForm form = new LoginForm();
                form.Show();

                cmd.Dispose();
                                
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                LoginForm form = new LoginForm();
                form.Show();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
