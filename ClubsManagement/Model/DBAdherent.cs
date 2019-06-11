using ClubsManagement.Controler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClubsManagement.Model
{
    public class DBAdherent : DBConnection
    {
        public void ReadAllAdherents(List<Adherent> adherents)
        {            
            var manageClub = ManagementClub.GetManagementClub();
            adherents.Clear();
            
            using (Connection)
            { 
                Connection.Open();
                var query = "SELECT * FROM adherent NATURAL JOIN club ORDER BY adh_id";
                var cmd = new MySqlCommand(query, Connection);

                using (var datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        foreach (var club in manageClub.Clubs)
                        {
                            if ((int)datareader["club_id"] == club.Id)
                            {
                                var adherent = new Adherent((int)datareader["adh_id"], (int)datareader["adh_licence"],
                                    (string)datareader["adh_nom"], (string)datareader["adh_prenom"],
                                    (string)datareader["adh_cp"], (string)datareader["adh_adresse"],
                                    (string)datareader["adh_ville"], (DateTime)datareader["adh_naissance"],
                                    Convert.ToInt32(datareader["adh_cotisation"]), club);
                                adherents.Add(adherent);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void AddAdherent(Adherent adherentToAdd)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "INSERT INTO `adherent` (`adh_nom`, `adh_prenom`,`adh_naissance`,"
                            + "`adh_adresse`, `adh_cp`, `adh_ville`,`adh_cotisation`, `club_id`) "
                            + "VALUES (@nom, @prenom, @date, @Adresse, @codepostal, @ville, @cotisation, @club);";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@nom",adherentToAdd.LastName);
                cmd.Parameters.AddWithValue("@prenom", adherentToAdd.FirstName);
                cmd.Parameters.AddWithValue("@date", adherentToAdd.BirthDate);
                cmd.Parameters.AddWithValue("@adresse", adherentToAdd.Address);
                cmd.Parameters.AddWithValue("@codepostal", adherentToAdd.ZipCode);
                cmd.Parameters.AddWithValue("@ville", adherentToAdd.City);
                cmd.Parameters.AddWithValue("@cotisation", adherentToAdd.Subscription);
                cmd.Parameters.AddWithValue("@club", adherentToAdd.Club.Id);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Calls a stocked procedure that gives a licence number to all adherents
        /// </summary>
        public void UpdateAdherent()
        {
            using (Connection)
            {
                Connection.Open();

                var query = "call miseAJourAdherents()";
                var cmd = new MySqlCommand(query, Connection);

                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyAdherent(Adherent adherentToModify)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "UPDATE `adherent` SET `adh_licence` = `adh_id`, `adh_nom` = @nom, "
                    + "`adh_prenom` = @prenom, `adh_naissance` = @date, `adh_adresse` = @adresse,"
                    + "`adh_cp` = @codepostal, `adh_ville` = @ville, `club_id` = @idClub "
                    + "WHERE `adherent`.`adh_id` = @id" ;
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@nom", adherentToModify.LastName);
                cmd.Parameters.AddWithValue("@prenom", adherentToModify.FirstName);
                cmd.Parameters.AddWithValue("@date", adherentToModify.BirthDate);
                cmd.Parameters.AddWithValue("@adresse", adherentToModify.Address);
                cmd.Parameters.AddWithValue("@codepostal", adherentToModify.ZipCode);
                cmd.Parameters.AddWithValue("@ville", adherentToModify.City);
                cmd.Parameters.AddWithValue("@idClub", adherentToModify.Club.Id);
                cmd.Parameters.AddWithValue("@id", adherentToModify.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAdherent(Adherent adherentToDelete)
        {
            using (Connection)
            {
                Connection.Open();
                var query = "DELETE FROM `adherent` WHERE `adherent`.`adh_id` = @id";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@id", adherentToDelete.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}