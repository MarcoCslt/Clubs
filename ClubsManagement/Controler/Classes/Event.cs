using System;

namespace ClubsManagement.Controler
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Club Club { get; set; }

        /// <summary>
        /// Constructor for an event that doesn't exist in the DataBase
        /// </summary>
        public Event(string Name, DateTime Start, DateTime End, Club Club)
        {
            this.Name = Name;
            this.Start = Start;
            this.End = End;
            this.Club = Club;
        }

        /// <summary>
        /// Constructor for an event that exists in the DataBase
        /// </summary>
        public Event(int Id, string Name, DateTime Start, DateTime End, Club Club) : this(Name, Start, End, Club)
        {
            this.Id = Id;
        }
    }
}
