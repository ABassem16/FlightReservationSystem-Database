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
    public partial class AdminSignUp : Form
    {
        public AdminSignUp()
        {
            InitializeComponent();
        }

        private void BackSigninA_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void EnterSigninA_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            string query = "insert into admin values('" + textBox1.Text + "','" + textBox2.Text + "')";
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Admin Added");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void adminBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void AdminSignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.flightReservationSystemDataSet.Admin);

        }

        private void anameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
