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
    public partial class PassengerSignUp : Form
    {
        public PassengerSignUp()
        {
            InitializeComponent();
        }

        private void passengerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void passengerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.passengerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void passengerBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.passengerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void PassengerSignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.Passenger' table. You can move, or remove it, as needed.
            passengerTableAdapter.Fill(flightReservationSystemDataSet.Passenger);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "insert into Passenger values('"+ comboBox1.Text + "','" + ageTextBox.Text + "','" + pnameTextBox.Text + "','" + p_idTextBox.Text + "','" + anameTextBox.Text + "','" + office_idTextBox.Text + "','" + addressTextBox.Text + "','"  + contactTextBox.Text + "','" + e_mailTextBox.Text + "')";
            int m=sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Submitted");
            }
            else
            {
                MessageBox.Show("Cannot Add Passenger");
            }
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void office_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
