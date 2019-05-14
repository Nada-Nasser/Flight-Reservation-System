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
    public partial class AdmenForm : Form
    {
        String ID;
        String Name;

        public AdmenForm(string Name , String Id)
        {
            InitializeComponent();
            ID = Id;
            Namelbl.Text = Name;
            IDlbl.Text = ID;
        }

        private void AdmenForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flight_ReservationDataSet.PASSENGER' table. You can move, or remove it, as needed.
            this.pASSENGERTableAdapter.Fill(this.flight_ReservationDataSet.PASSENGER);
        }

        private void UpdateDataBtn_Click(object sender, EventArgs e)
        {
            UpdateUserData form = new UpdateUserData(ID);
            form.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.Show();
        }

        private void AddCraftBtn_Click(object sender, EventArgs e)
        {
            AddCraft form = new AddCraft(ID);
            this.Hide();
            form.Show();
        }

        private void showTickets_Click(object sender, EventArgs e)
        {
            All_Tickets form = new All_Tickets(ID);
            this.Hide();
            form.Show();
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
             Add_new_Flight form = new Add_new_Flight(ID);
             this.Hide();
             form.Show();
        }

        private void UpdateFlightBtn_Click(object sender, EventArgs e)
        {
             Update_Flight form = new Update_Flight(ID);
             this.Hide();
             form.Show();
        }

        private void UpdateCraftBtn_Click(object sender, EventArgs e)
        {
            Update_Craft_Details form = new Update_Craft_Details(ID);
            this.Hide();
            form.Show();
        }

        private void AddAdmin_Click(object sender, EventArgs e)
        {
            /// Edit on The sign up form to be able to deal with this...
            signUpForm form = new signUpForm("Admin");
            //this.Hide();
            form.Show();
               
        }

        private void DeeleteFlight_Click(object sender, EventArgs e)
        {
            DeleteFlight form = new DeleteFlight(ID);
            this.Hide();
            form.Show();
        }

        private void Delete_Craft_Click(object sender, EventArgs e)
        {
            DeleteCraft form = new DeleteCraft(ID);
            this.Hide();
            form.Show();
        }

    }
}
