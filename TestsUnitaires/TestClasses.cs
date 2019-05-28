using ClubsManagement.Controler;
using System;
using Xunit;

namespace UnitTests
{
    public class TestClasses
    {
        [Fact]
        public void TestLeague()
        {
            League handballLeague = new League(12, "Handball");

            Assert.Equal(12, handballLeague.Id);
            Assert.Equal("Handball", handballLeague.Name);
        }

        [Fact]
        public void TestClub()
        {
            League volleyballLeague = new League(13, "Volleyball");
            Club club = new Club("AS Meudon", "asmeudon.com", "3, Bis Rue Georges Millandy", "92360", "Meudon La Foret",
                "asmeudon@test.com", "012345679", volleyballLeague);

            Assert.Equal("AS Meudon", club.Name);
            Assert.Equal("asmeudon.com", club.Url);
            Assert.Equal("3, Bis Rue Georges Millandy", club.Address);
            Assert.Equal("92360", club.ZipCode);
            Assert.Equal("Meudon La Foret", club.City);
            Assert.Equal("asmeudon@test.com", club.Mail);
            Assert.Equal("012345679", club.Telephone);
            Assert.Equal(volleyballLeague, club.League);
        }

        [Fact]
        public void TestAdherent()
        {
            DateTime date = new DateTime(1999, 12, 12);
            League tennisLeague = new League(20, "tennis");
            Club club = new Club("un club", "une url", "une adresse", "un CP", "une ville", "un mail", "012345679", tennisLeague);
            Adherent adhtest = new Adherent("Bertrand", "Jean", "92130", "6 square Louis Blé", "Issy-les-mx", date, 150, club);

            Assert.Equal("Bertrand", adhtest.LastName);
            Assert.Equal("Jean", adhtest.FirstName);
            Assert.Equal("92130", adhtest.ZipCode);
            Assert.Equal("6 square Louis Blé", adhtest.Address);
            Assert.Equal("Issy-les-mx", adhtest.City);
            Assert.Equal(date, adhtest.BirthDate);
            Assert.Equal(150, adhtest.Subscription);
            Assert.Equal(club, adhtest.Club);
        }
    }
}
