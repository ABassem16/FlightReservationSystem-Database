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
    public partial class Passengers : Form
    {
        public Passengers()
        {
            InitializeComponent();
        }

        private void Passengers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.Passenger' table. You can move, or remove it, as needed.
            this.passengerTableAdapter.Fill(this.flightReservationSystemDataSet.Passenger);

        }

        private void passengerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form AdminFunctions = new AdminFunctions();
            AdminFunctions.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("insert into Passenger values( ");
            if (!String.IsNullOrEmpty(genderTextBox.Text))
            {
                query.Append("'" + genderTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(ageTextBox.Text))
            {
                query.Append(",'" + ageTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(pnameTextBox.Text))
            {
                query.Append(",'" + pnameTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(p_idTextBox.Text))
            {
                query.Append(",'" + p_idTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(anameTextBox.Text))
            {
                query.Append(",'" + anameTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(office_idTextBox.Text))
            {
                query.Append(",'" + office_idTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(addressTextBox.Text))
            {
                query.Append(",'" + addressTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(contactTextBox.Text))
            {
                query.Append(",'" + contactTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(e_mailTextBox.Text))
            {
                query.Append(",'" + e_mailTextBox.Text + "')");
            }
            sqlCommand.CommandText = query.ToString();
            int m=sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Passenger Added");
            }
            else
            {
                MessageBox.Show("Cannot Add Passenger");
            }
        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("update Passenger set");

            if (!String.IsNullOrEmpty(genderTextBox.Text))
            {
                query.Append(" gender ='" + genderTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(ageTextBox.Text))
            {
                query.Append(", age='" + ageTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(pnameTextBox.Text))
            {
                query.Append(", pname='" + pnameTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(anameTextBox.Text))
            {
                query.Append(", aname = '" + anameTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(office_idTextBox.Text))
            {
                query.Append(", office_id = '" + office_idTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(addressTextBox.Text))
            {
                query.Append(", address = '" + addressTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(contactTextBox.Text))
            {
                query.Append(", contact ='" + contactTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(e_mailTextBox.Text))
            {
                query.Append(", e_mail ='" + e_mailTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(p_idTextBox.Text))
            {
                query.Append("where p_id = '" + p_idTextBox.Text + "'");
            }
            sqlCommand.CommandText = query.ToString();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Passenger Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText="delete from Passenger where p_id='" + p_idTextBox.Text + "'";
            int m=sqlCommand.ExecuteNonQuery();
            if(m>0)
            {
                MessageBox.Show("Passenger Deleted");
            }
            else
            {
                MessageBox.Show("Cannot Delete Passenger");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.passengerTableAdapter.Fill(this.flightReservationSystemDataSet.Passenger);
        }
    }
}
