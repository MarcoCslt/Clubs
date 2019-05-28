using ClubsManagement.Model;
using System.Collections.Generic;

namespace ClubsManagement.Controler
{
    public class ManagementAdherent
    {
        /**
         * Use of the singleton pattern in order to have no more than
         * one instance of ManagementAdherent and one list of adherents.
         **/
        private static ManagementAdherent Instance = null;
        private DBAdherent DBAdherent = new DBAdherent();
        public List<Adherent> Adherents { get; set; } = new List<Adherent>();

        private ManagementAdherent()
        {
            DBAdherent.ReadAllAdherents(Adherents);
        }

        public static ManagementAdherent GetManagementAdherent()
        {
            if (Instance == null)
            {
                Instance = new ManagementAdherent();
            }

            return Instance;
        }

        public void UpdateManagementAdherent()
        {
            DBAdherent.ReadAllAdherents(Adherents);
        }

        public Adherent GetAdherentById(int idOfAdherent)
        {
            foreach (var adherent in Adherents)
            {
                if (adherent.LicenceNumber == idOfAdherent)
                {
                    return adherent;
                }
            }
            return null;
        }

        public void DeleteAdherent(Adherent AdherentToDelete)
        {
            Adherents.Remove(AdherentToDelete);
        }

        public void AddAdherent(Adherent adherentToAdd)
        {
            Adherents.Add(adherentToAdd);
        }
    }
}
