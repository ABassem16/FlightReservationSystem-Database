using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Reservation_System_2._0
{
    public partial class AdminFunctions : Form
    {
        public AdminFunctions()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Flights = new Flights();
            Flights.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Passengers = new Passengers();
            Passengers.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Airplanes = new Airplanes();
            Airplanes.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form BookingOffices = new BookingOffices();
            BookingOffices.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Airports = new Airports();
            Airports.Show();
            Hide();
        }

        private void AdminFunctions_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form Admin = new Admin();
            Admin.Show();
            Hide();
        }
    }
}
