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
                var query = "SELECT * FROM adherent NATURAL JOIN club ORDER BY id_adherent";
                var cmd = new MySqlCommand(query, Connection);

                using (var datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        foreach (var club in manageClub.Clubs)
                        {
                            if ((int)datareader["id_club"] == club.Id)
                            {
                                var adherent = new Adherent((int)datareader["id_adherent"], (int)datareader["numero_licence"],
                                    (string)datareader["Nom_adherent"], (string)datareader["Prenom_adherent"],
                                    (string)datareader["Code_Postal_adherent"], (string)datareader["Adresse_adherent"],
                                    (string)datareader["Ville_adherent"], (DateTime)datareader["Date_naissance_adherent"],
                                    (int)datareader["cotisation_adherent"], club);
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
                var query = "INSERT INTO `adherent` (`Nom_adherent`, `Prenom_adherent`,`Date_naissance_adherent`,"
                            + "`Adresse_adherent`, `Code_Postal_adherent`, `Ville_adherent`,`cotisation_adherent`, `id_club`) "
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
                var query = "UPDATE `adherent` SET `numero_licence` = `id_adherent`, `Nom_adherent` = @nom, "
                    + "`Prenom_adherent` = @prenom, `Date_naissance_adherent` = @date, `Adresse_adherent` = @adresse,"
                    + "`Code_Postal_adherent` = @codepostal, `Ville_adherent` = @ville, `id_club` = @idClub "
                    + "WHERE `adherent`.`id_adherent` = @id" ;
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
                var query = "DELETE FROM `adherent` WHERE `adherent`.`id_adherent` = @id";
                var cmd = new MySqlCommand(query, Connection);

                cmd.Parameters.AddWithValue("@id", adherentToDelete.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}