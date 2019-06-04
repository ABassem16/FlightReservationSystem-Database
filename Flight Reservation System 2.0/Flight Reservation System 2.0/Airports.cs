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
    public partial class Airports : Form
    {
        public Airports()
        {
            InitializeComponent();
        }

        private void airportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void Airports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.flightReservationSystemDataSet.Admin);
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.Airport' table. You can move, or remove it, as needed.
            this.airportTableAdapter.Fill(this.flightReservationSystemDataSet.Airport);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form AdminFunctions = new AdminFunctions();
            AdminFunctions.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("insert into Airport values( ");
            if (!String.IsNullOrEmpty(nameTextBox.Text))
            {
                query.Append("'" + nameTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(codeTextBox.Text))
            {
                query.Append(",'" + codeTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(cityTextBox.Text))
            {
                query.Append(",'" + cityTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(countryTextBox.Text))
            {
                query.Append(",'" + countryTextBox.Text + "')");
            }
            sqlCommand.CommandText = query.ToString();
           int m=sqlCommand.ExecuteNonQuery();
            if(m>0)
            {
                MessageBox.Show("Airport Added");
            }
            else
            {
                MessageBox.Show("Cannot Add Airport");
            }
            MessageBox.Show("Airport Added");
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            airportTableAdapter.Fill(flightReservationSystemDataSet.Airport);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int m;
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from Airport where code='" + codeTextBox.Text + "'";
            m = sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Airport Deleted");
            }
            else
            {
                MessageBox.Show("Cannot Delete Airport");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("update Airport set");
      
            if (!String.IsNullOrEmpty(nameTextBox.Text))
            {
                query.Append(" name = '" + nameTextBox.Text + "',");
            }
            if (!String.IsNullOrEmpty(cityTextBox.Text))
            {
                query.Append(" city = '" + cityTextBox.Text + "',");
            }
            if (!String.IsNullOrEmpty(countryTextBox.Text))
            {
                query.Append(" country = '" + countryTextBox.Text + "'");
            }

            if (!String.IsNullOrEmpty(codeTextBox.Text))
            {
                query.Append(" where code = '" + codeTextBox.Text + "'");
            }
            sqlCommand.CommandText = query.ToString();
           int m= sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Airport Updated");
            }
            else
            {
                MessageBox.Show("Cannot Update Airport");
            }
        }

    }
    
}
