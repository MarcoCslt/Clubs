using ClubsManagement.Model;
using System.Collections.Generic;

namespace ClubsManagement.Controler
{
    public class ManagementLeague
    {
        /**
         * Use of the singleton pattern in order to have no more than
         * one instance of ManagementLeague and one list of leagues.
         **/
        private static ManagementLeague Instance = null;
        public static List<League> Leagues { get; set; } = new List<League>();

        private ManagementLeague()
        {
            var DBLeague = new DBLeague();
            DBLeague.ReadAllLeagues(Leagues);
        }

        public static ManagementLeague GetManagementLeague()
        {
            if (Instance == null)
            {
                Instance = new ManagementLeague();
            }
            return Instance;
        }

        public League GetLeagueByName(string nameOfLeague)
        {
            foreach (var league in Leagues)
            {
                if (nameOfLeague.Equals(league.Name))
                {
                    return league;
                }
            }
            return null;
        }
    }
}
