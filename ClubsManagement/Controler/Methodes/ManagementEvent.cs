using ClubsManagement.Model;
using System.Collections.Generic;

namespace ClubsManagement.Controler
{
    public class ManagementEvent
    {
        /**
         * Use of the singleton pattern in order to have no more than
         * one instance of ManagementEvent and one list of events.
         **/
        private static ManagementEvent Instance = null;
        public List<Event> Events { get; set; } = new List<Event>();

        private ManagementEvent()
        {
            DBEvent BD = new DBEvent();
            BD.ReadAllEvent(Events);
        }

        public static ManagementEvent GetManageEvent()
        {
            if (Instance == null)
            {
                Instance = new ManagementEvent();
            }
            return Instance;
        }

        public Event GetEventById(int idOfEvent)
        {
            foreach (var anEvent in Events)
            {
                if (anEvent.Id == idOfEvent)
                {
                    return anEvent;
                }
            }
            return null;
        }

        public void AddEvent(Event eventToAdd)
        {
            Events.Add(eventToAdd);
        }

        public void DeleteEvent(Event eventToDelete)
        {
            Events.Remove(eventToDelete);
        }
    }
}
