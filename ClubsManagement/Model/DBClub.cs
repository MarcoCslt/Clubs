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
                var query = "SELECT * FROM club NATURAL JOIN ligue ORDER BY id_club";
                var cmd = new MySqlCommand(query, Connection);

                using (var datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        var league = new League((int)datareader["lg_id"], (string)datareader["lg_nom"]);
                        var club = new Club((int)datareader["id_club"], (string)datareader["Titre_club"],
                                            (string)datareader["url_club"], (string)datareader["Adresse_club"],
                                            (string)datareader["Code_Postal_club"], (string)datareader["Ville_club"],
                                            (string)datareader["mail_club"], (string)datareader["telephone_club"], league);

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
                var query = "SELECT count(id_adherent) as number FROM adherent natural join club WHERE id_club = @id";
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
                var query = "INSERT INTO `club` VALUES (NULL, @titre, @url, @adresse, @cp, @ville, @mail, @tel, @league)";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@titre", club.Name);
                cmd.Parameters.AddWithValue("@url", club.Url);
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
                var query = "UPDATE `club` SET `Titre_club` = @titre, `url_club` = @url, `Adresse_club` = @adresse,"
                            + "`Code_Postal_club` = @cp, `Ville_club` = @ville, `mail_club` = @mail,"
                            + "`telephone_club` = @tel WHERE `club`.`id_club` = @idc";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@titre", club.Name);
                cmd.Parameters.AddWithValue("@url", club.Url);
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
