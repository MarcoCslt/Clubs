using ClubsManagement.Model;
using System.Collections.Generic;

namespace ClubsManagement.Controler
{
    public class ManagementClub
    {
        /**
         * Use of the singleton pattern in order to have no more than
         * one instance of ManagementClub and one list of clubs.
         **/
        private static ManagementClub Instance = null;
        public List<Club> Clubs { get; set; } = new List<Club>();

        private ManagementClub()
        {
            var DBClub = new DBClub();
            DBClub.ReadAllClub(Clubs);
        }

        public static ManagementClub GetManagementClub()
        {
            if (Instance == null)
            {
                Instance = new ManagementClub();
            }
            return Instance;
        }

        public void AddClub(Club unClub)
        {
            Clubs.Add(unClub);
        }

        public Club GetClubByName(string nameOfClub)
        {
            foreach (var club in Clubs)
            {
                if (nameOfClub.Equals(club.Name))
                {
                    return club;
                }
            }
            return null;
        }

        public Club GetClubById(int idOfClub)
        {
            foreach (var club in Clubs)
            {
                if (club.Id == idOfClub)
                {
                    return club;
                }
            }
            return null;
        }
    }
}
