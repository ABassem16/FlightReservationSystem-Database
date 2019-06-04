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
    public partial class BookingOffices : Form
    {
        public BookingOffices()
        {
            InitializeComponent();
        }

        private void booking_officeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booking_officeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void BookingOffices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.Booking_office' table. You can move, or remove it, as needed.
            this.booking_officeTableAdapter.Fill(this.flightReservationSystemDataSet.Booking_office);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form AdminFunctions = new AdminFunctions();
            AdminFunctions.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.booking_officeTableAdapter.Fill(this.flightReservationSystemDataSet.Booking_office);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("update Booking_Office set");

            if (!String.IsNullOrEmpty(office_nameTextBox.Text))
            {
                query.Append(" office_name = '" + office_nameTextBox.Text + "'");
            }
            
            if (!String.IsNullOrEmpty(office_idTextBox.Text))
            {
                query.Append(" where office_id = '" + office_idTextBox.Text + "'");
            }
            sqlCommand.CommandText = query.ToString();
            int m=sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Booking Office Updated");
            }
            else
            {
                MessageBox.Show("Cannot Update");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int m;
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from Booking_Office where office_id='" + office_idTextBox.Text + "'";
            m = sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Booking Office Deleted");
            }
            else
            {
                MessageBox.Show("Cannot Delete Booking Office");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("insert into Booking_Office values(");

            if (!String.IsNullOrEmpty(office_idTextBox.Text))
            {
                query.Append("'" + office_idTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(office_nameTextBox.Text))
            {
                query.Append(",'" + office_nameTextBox.Text + "')");
            }
            
            sqlCommand.CommandText = query.ToString();
            int m=sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Booking Office Added");
            }
            else
            {
                MessageBox.Show("Cannot Add Booking Office");
            }
        }
    }
}
