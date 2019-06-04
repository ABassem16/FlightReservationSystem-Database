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

namespace Flight_Reservation_System_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
        }

        private void Sign_in_Admin_Click(object sender, EventArgs e)
        {
            Form AdminSignIn = new AdminSignIn();
            AdminSignIn.Show();
            Hide();
        }

        private void SignUpAdmin_Click(object sender, EventArgs e)
        {
            Form AdminSignUp = new AdminSignUp();
            AdminSignUp.Show();
            Hide();
        }

        private void SignupCust_Click(object sender, EventArgs e)
        {
            Form PassengerSignUp = new PassengerSignUp();
            PassengerSignUp.Show();
            Hide();
        }
    }
}
