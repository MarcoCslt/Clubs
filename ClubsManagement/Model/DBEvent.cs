using ClubsManagement.Controler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClubsManagement.Model
{
    public class DBEvent : DBConnection
    {
        public void ReadAllEvent(List<Event> events)
        {
            var manageClub = ManagementClub.GetManagementClub();

            using (Connection)
            {
                Connection.Open();
                var query = "SELECT * from evenement NATURAL JOIN club";
                var cmd = new MySqlCommand(query, Connection);

                using (var datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        foreach (var club in manageClub.Clubs)
                        {
                            if ((int)datareader["id_club"] == club.Id)
                            {
                                var anEvent = new Event((int)datareader["id_evenement"], (string)datareader["Titre_evenement"],
                                                          (DateTime)datareader["debut_evenement"], 
                                                          (DateTime)datareader["fin_evenement"], club);
                                events.Add(anEvent);
                            }
                        }
                    }
                }
            }
        }
        
        public void AddEvent(Event eventToAdd)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "INSERT INTO `evenement` (`id_evenement`, `Titre_evenement`, `debut_evenement`," 
                            + "`fin_evenement`, `id_club`) VALUES (NULL, @titre, @debut, @fin, @id_club)";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@titre", eventToAdd.Name);
                cmd.Parameters.AddWithValue("@debut", eventToAdd.Start);
                cmd.Parameters.AddWithValue("@fin", eventToAdd.End);
                cmd.Parameters.AddWithValue("@id_club", eventToAdd.Club.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyEvent(Event eventToModify)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "UPDATE `evenement` SET `Titre_evenement` = @titre, `debut_evenement` = @debut," 
                            + "`fin_evenement` = @fin WHERE `evenement`.`id_evenement` = @id";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@titre", eventToModify.Name);
                cmd.Parameters.AddWithValue("@debut", eventToModify.Start);
                cmd.Parameters.AddWithValue("@fin", eventToModify.End);
                cmd.Parameters.AddWithValue("@id", eventToModify.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEvent(Event eventToDelete)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "DELETE FROM `evenement` WHERE `evenement`.`id_evenement` = @id";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@id", eventToDelete.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
