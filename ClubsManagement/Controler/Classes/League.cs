namespace ClubsManagement.Controler
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public League(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}