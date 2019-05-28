using ClubsManagement.Controler;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ClubsManagement.Model
{
    public class DBLeague : DBConnection
    {
        public void ReadAllLeagues(List<League> leagues)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "select * from ligue";
                var cmd = new MySqlCommand(query, Connection);

                using (var datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        var league = new League((int)datareader["lg_id"], (string)datareader["lg_nom"]);
                        leagues.Add(league);
                    }
                }
            }
        }
    }
}
