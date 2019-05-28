using ClubsManagement.Controler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class TestClasses
    {
        [TestMethod]
        public void TestLeague()
        {
            League handballLeague = new League(12, "Handball");

            Assert.AreEqual(12, handballLeague.Id);
            Assert.AreEqual("Handball", handballLeague.Name);
        }

        [TestMethod]
        public void TestClub()
        {
            League volleyballLeague = new League(13, "Volleyball");
            Club club = new Club("AS Meudon", "asmeudon.com", "3, Bis Rue Georges Millandy", "92360", "Meudon La Foret",
                "asmeudon@test.com", "012345679", volleyballLeague);

            Assert.AreEqual("AS Meudon", club.Name);
            Assert.AreEqual("asmeudon.com", club.Url);
            Assert.AreEqual("3, Bis Rue Georges Millandy", club.Address);
            Assert.AreEqual("92360", club.ZipCode);
            Assert.AreEqual("Meudon La Foret", club.City);
            Assert.AreEqual("asmeudon@test.com", club.Mail);
            Assert.AreEqual("012345679", club.Telephone);
            Assert.AreEqual(volleyballLeague, club.League);
        }

        [TestMethod]
        public void TestAdherent()
        {
            DateTime date = new DateTime(1999, 12, 12);
            League tennisLeague = new League(20, "tennis");
            Club club = new Club("un club", "une url", "une adresse", "un CP", "une ville", "un mail", "012345679", tennisLeague);
            Adherent adhtest = new Adherent("Bertrand", "Jean", "92130", "6 square Louis Blé", "Issy-les-mx", date, 150, club);

            Assert.AreEqual("Bertrand", adhtest.LastName);
            Assert.AreEqual("Jean", adhtest.FirstName);
            Assert.AreEqual("92130", adhtest.ZipCode);
            Assert.AreEqual("6 square Louis Blé", adhtest.Address);
            Assert.AreEqual("Issy-les-mx", adhtest.City);
            Assert.AreEqual(date, adhtest.BirthDate);
            Assert.AreEqual(150, adhtest.Subscription);
            Assert.AreEqual(club, adhtest.Club);
        }
    }
}
