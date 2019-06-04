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
    public partial class AdminSignIn : Form
    {
        public AdminSignIn()
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
            string query;
            SqlConnection sqlConnection = new SqlConnection("Data Source=ABASSEM;Initial Catalog=FlightReservationSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            query = sqlCommand.CommandText = "select * from admin where aname='"+textBox2.Text+"' and apass='"+textBox1.Text+"' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query,sqlConnection);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                Form AdminFunctions = new AdminFunctions();
                AdminFunctions.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
