namespace ClubsManagement.Controler
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
        public League League { get; set; }

        /// <summary>
        /// Constructor for a club that doesn't exist in the DataBase
        /// </summary>
        public Club(string Name, string Address, string ZipCode, string City,
            string Mail, string Telephone, League League)
        {
            this.Name = Name;
            this.Address = Address;
            this.ZipCode = ZipCode;
            this.City = City;
            this.Mail = Mail;
            this.Telephone = Telephone;
            this.League = League;
        }

        /// <summary>
        /// Constructor for a club that exists in the DataBase
        /// </summary>
        public Club(int Id, string Name, string Address, string ZipCode, string City,
            string Mail, string Telephone, League League) 
            : this(Name, Address, ZipCode, City, Mail, Telephone, League)
        {
            this.Id = Id;
        }
    }
}
