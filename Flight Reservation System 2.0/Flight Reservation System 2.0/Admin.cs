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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void adminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.flightReservationSystemDataSet.Admin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("insert into Admin values(");

            if (!String.IsNullOrEmpty(anameTextBox.Text))
            {
                query.Append("'" + anameTextBox.Text + "'");
            }
            if (!String.IsNullOrEmpty(apassTextBox.Text))
            {
                query.Append(",'" + apassTextBox.Text + "')");
            }

            sqlCommand.CommandText = query.ToString();
            int m=sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Admin Added");
            }
            else
            {
                MessageBox.Show("Cannot Add Admin");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adminfunctions = new AdminFunctions();
            adminfunctions.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            StringBuilder query = new StringBuilder("update Admin set");

            if (!String.IsNullOrEmpty(anameTextBox.Text))
            {
                query.Append(" apass= '" + apassTextBox.Text + "'");
            }

            if (!String.IsNullOrEmpty(apassTextBox.Text))
            {
                query.Append(" where aname= '" + anameTextBox.Text + "'");
            }
            sqlCommand.CommandText = query.ToString();
            int m=sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Admin Updated");
            }
            else
            {
                MessageBox.Show("Cannot Update Admin");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.adminTableAdapter.Fill(this.flightReservationSystemDataSet.Admin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m;
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "delete from Admin where aname='" + anameTextBox.Text + "'";
            m = sqlCommand.ExecuteNonQuery();
            if (m > 0)
            {
                MessageBox.Show("Admin Deleted");
            }
            else
            {
                MessageBox.Show("Cannot Delete Admin");
            }
        }
    }
}
