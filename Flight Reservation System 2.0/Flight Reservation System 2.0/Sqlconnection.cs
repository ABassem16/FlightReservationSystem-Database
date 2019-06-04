using System;
using System.Data.SqlClient;

namespace Flight_Reservation_System_2._0
{
    internal class Sqlconnection
    {
        private string v;

        public Sqlconnection(string v)
        {
            this.v = v;
        }

        public static implicit operator Sqlconnection(SqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}