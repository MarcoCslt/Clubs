using System;

namespace ClubsManagement.Controler
{
    public class Adherent
    {
        public int Id { get; set; }
        public int LicenceNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public int Subscription { get; set; }
        public Club Club { get; set; }

        /// <summary>
        /// Constructor for an adherent that doesn't exist in the DataBase
        /// </summary>
        public Adherent(string LastName, string FirstName, string ZipCode, string Address, string City, 
            DateTime BirthDate, int Subscription, Club Club)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.ZipCode = ZipCode;
            this.Address = Address;
            this.City = City;
            this.BirthDate = BirthDate;
            this.Subscription = Subscription;
            this.Club = Club;
        }

        /// <summary>
        /// Constructor for an adherent that exists in the DataBase
        /// </summary>
        public Adherent(int Id, int LicenceNumber, string LastName, string FirstName, string ZipCode, string Address,
            string City, DateTime BirthDate, int Subscription, Club Club) 
            : this(LastName, FirstName, ZipCode, Address, City, BirthDate, Subscription, Club)
        {
            this.Id = Id;
            this.LicenceNumber = LicenceNumber;
        }
    }
}
