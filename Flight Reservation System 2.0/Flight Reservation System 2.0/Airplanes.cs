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
    public partial class Airplanes : Form
    {
        public Airplanes()
        {
            InitializeComponent();
        }

        private void airplaneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airplaneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void Airplanes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.Airplane' table. You can move, or remove it, as needed.
            this.airplaneTableAdapter.Fill(this.flightReservationSystemDataSet.Airplane);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form AdminFunctions = new AdminFunctions();
            AdminFunctions.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.airplaneTableAdapter.Fill(this.flightReservationSystemDataSet.Airplane);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("insert into Airplane values (");

            if (!String.IsNullOrEmpty(seatsTextBox.Text))
            {
                query.Append("'" + seatsTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(reg_numTextBox.Text))
            {
                query.Append(",'" + reg_numTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(seatsTextBox.Text))
            {
                query.Append(",'" + airoplane_typeTextBox.Text + "')");
            }
            int m;
            sqlCommand.CommandText = query.ToString();
            m=sqlCommand.ExecuteNonQuery();
            if(m>0)
            {
                MessageBox.Show("Airplane Added");
            }
            else
            {
                MessageBox.Show("Cannot Add Airplane");
            }
        }

        private void seatsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int m;
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from Airplane where Reg_num='" + reg_numTextBox.Text + "'";
            m = sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Airplane Deleted");
            }
            else
            {
                MessageBox.Show("Cannot Delete Airplane");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("update airplane set");

            if (!String.IsNullOrEmpty(seatsTextBox.Text))
            {
                query.Append(" seats = '" + seatsTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(airoplane_typeTextBox.Text))
            {
                query.Append(", airoplane_type = '" + airoplane_typeTextBox.Text + "'");
            }

            if (!String.IsNullOrEmpty(reg_numTextBox.Text))
            {
                query.Append(" where reg_num = '" + reg_numTextBox.Text + "'");
            }
            sqlCommand.CommandText = query.ToString();
            int m=sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Airplane Updated");
            }
            else
            {
                MessageBox.Show("Cannot Update Airplane");
            }

        }
    }
}
