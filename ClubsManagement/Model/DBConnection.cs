using MySql.Data.MySqlClient;
using System;

namespace ClubsManagement.Model
{
    public class DBConnection
    {
        private readonly string ConnectionString;
        public MySqlConnection Connection { get; set; }

        public DBConnection()
        {
            var server = "10.54.0.150";
            var port = "3306";
            var database = "CLUB_vincent";
            var uid = "vincent";
            var password = "bobo";

            ConnectionString = "Server=" + server + ";" + "Port=" + port + ";" + "Database=" + database + ";"
                                + "Uid=" + uid + ";" + "Pwd=" + password + ";";

            try
            {
                Connection = new MySqlConnection(ConnectionString);
            }
            catch
            {
                Console.WriteLine("Connection with database failed");
            }
        }
    }
}
