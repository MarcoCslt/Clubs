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
            var server = "localhost";
            var port = "3306";
            var database = "m2lcsharp";
            var uid = "root";
            var password = "";

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
