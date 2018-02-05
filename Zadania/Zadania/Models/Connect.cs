using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Models
{
    class Connect
    {
        private static string connectionString = "SERVER=localhost;DATABASE=zadania;UID=root;PASSWORD=;";
        private MySqlConnection connection = new MySqlConnection(connectionString); //Connect to our local database => Get Access

        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }
    }
}
