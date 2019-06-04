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
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        private void flightBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flightBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void flightBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.flightBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void Flights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.Flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.flightReservationSystemDataSet.Flight);

        }

        private void fromTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form AdminFunctions = new AdminFunctions();
            AdminFunctions.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.flightTableAdapter.Fill(this.flightReservationSystemDataSet.Flight);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("update Flight set");

            if (!String.IsNullOrEmpty(fromTextBox.Text))
            {
                query.Append(" [from] = '" + fromTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(toTextBox.Text))
            {
                query.Append(", [to] = '" + toTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(dep_dateTextBox.Text))
            {
                query.Append(" , dep_date = '" + dep_dateTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(arrive_dateTextBox.Text))
            {
                query.Append(" , arrive_date = '" + arrive_dateTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(classTextBox.Text))
            {
                query.Append(", class = '" + classTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(arrive_timeTextBox.Text))
            {
                query.Append(", arrive_time = '" + arrive_timeTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(dep_timeTextBox.Text))
            {
                query.Append(", dep_time = '" + dep_timeTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(airlinesTextBox.Text))
            {
                query.Append(", airlines = '" + airlinesTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(flight_idTextBox.Text))
            {
                query.Append(" where flight_id = '" + flight_idTextBox.Text + "'");
            }
            sqlCommand.CommandText = query.ToString();
            int m=sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Flight Updated");
            }
            else
            {
                MessageBox.Show("Cannot Update Flight");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("insert into Flight values( ");
            if (!String.IsNullOrEmpty(fromTextBox.Text))
            {
                query.Append("'" + fromTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(toTextBox.Text))
            {
                query.Append(",'" + toTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(dep_dateTextBox.Text))
            {
                query.Append(",'" + dep_dateTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(arrive_dateTextBox.Text))
            {
                query.Append(",'" + arrive_dateTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(flight_idTextBox.Text))
            {
                query.Append(",'" + flight_idTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(classTextBox.Text))
            {
                query.Append(",'" + classTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(arrive_timeTextBox.Text))
            {
                query.Append(",'" + arrive_timeTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(dep_timeTextBox.Text))
            {
                query.Append(",'" + dep_timeTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(airlinesTextBox.Text))
            {
                query.Append(",'" + airlinesTextBox.Text + "')");
            }
            sqlCommand.CommandText = query.ToString();
            int m=sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Flight Added");
            }
            else
            {
                MessageBox.Show("Cannot Add Flight");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int m;
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from Flight where Flight_id='" + flight_idTextBox.Text + "'";
            m=sqlCommand.ExecuteNonQuery();
            if(m>0)
            {
                MessageBox.Show("Flight Deleted");
            }
            else
            {
                MessageBox.Show("Cannot Delete Flight");
            }
        }
    }
}
