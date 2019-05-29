using ClubsManagement.Controler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClubsManagement.Model
{
    public class DBClub : DBConnection
    {
        public void ReadAllClub(List<Club> clubs)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "SELECT * FROM club NATURAL JOIN ligue ORDER BY club_id";
                var cmd = new MySqlCommand(query, Connection);

                using (var datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        var league = new League((int)datareader["lg_id"], (string)datareader["lg_nom"]);
                        var club = new Club((int)datareader["club_id"], (string)datareader["club_nom"],
                                            (string)datareader["club_adresse"], (string)datareader["club_cp"],
                                            (string)datareader["club_ville"], (string)datareader["club_email"], 
                                            (string)datareader["club_tel"], league);

                        clubs.Add(club);
                    }
                }
            }
        }

        public int CountAdherent(Club club)
        {
            int numberOfAdherent = 0;

            using (Connection)
            {
                Connection.Open();
                var query = "SELECT count(adh_id) as number FROM adherent NATURAL JOIN club WHERE club_id = @id";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@id", club.Id);

                using (var datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        numberOfAdherent = Convert.ToInt32(datareader["number"]);
                    }
                }
            }
            return numberOfAdherent;
        }

        public int CountEvent(Club club)
        {
            int numberOfEvent = 0;

            using (Connection)
            {
                Connection.Open();
                var query = "call compterevent(@id)";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@id", club.Id);

                using (var datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        numberOfEvent = Convert.ToInt32(datareader["count"]);
                    }
                }
            }
            return numberOfEvent;
        }

        public void AddClub(Club club)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "INSERT INTO `club` VALUES (NULL, @titre, @adresse, @cp, @ville, @mail, @tel, @league)";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@titre", club.Name);
                cmd.Parameters.AddWithValue("@adresse", club.Address);
                cmd.Parameters.AddWithValue("@cp", club.ZipCode);
                cmd.Parameters.AddWithValue("@ville", club.City);
                cmd.Parameters.AddWithValue("@mail", club.Mail);
                cmd.Parameters.AddWithValue("@tel", club.Telephone);
                cmd.Parameters.AddWithValue("@league", club.League.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyClub(Club club)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "UPDATE `club` SET `club_nom` = @titre, `club_adresse` = @adresse,"
                            + "`club_cp` = @cp, `club_ville` = @ville, `club_email` = @mail,"
                            + "`club_tel` = @tel WHERE `club`.`club_id` = @idc";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@titre", club.Name);
                cmd.Parameters.AddWithValue("@adresse", club.Address);
                cmd.Parameters.AddWithValue("@cp", club.ZipCode);
                cmd.Parameters.AddWithValue("@ville", club.City);
                cmd.Parameters.AddWithValue("@mail", club.Mail);
                cmd.Parameters.AddWithValue("@tel", club.Telephone);
                cmd.Parameters.AddWithValue("@idc", club.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
