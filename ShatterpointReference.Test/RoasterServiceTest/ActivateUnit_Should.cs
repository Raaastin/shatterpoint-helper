using ShatterpointReferences.Services;

namespace ShatterpointReference.Test.RoasterServiceTest
{
    public class ActivateUnit_Should
    {
        public RoasterServices service;

        public ActivateUnit_Should()
        {
            service = new();
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_WithKalani()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.ActivateUnit(service.UnitList.First(x => x.Name.Contains("Kalani")));

            // Arrange
            Assert.Equal(5, result.Count);
            Assert.Equal("Roger, Roger", result[0].Name);
            Assert.Equal("Tactical Network", result[1].Name);
            Assert.Equal("Target, Concentrate All Firepower", result[2].Name);
            Assert.Equal("Combat A.I. Protocols", result[3].Name);
            Assert.Equal("Slip Away", result[4].Name);
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_WithBattleDroids()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.ActivateUnit(service.UnitList.First(x => x.Name.Contains("B1 Battle Droids")));

            // Arrange
            Assert.Equal(4, result.Count);
            Assert.Equal("Well, I Guess I'm in Charge Now", result[0].Name);
            Assert.Equal("Combat A.I. Protocols", result[1].Name);
            Assert.Equal("Target, Concentrate All Firepower", result[2].Name);
            Assert.Equal("Slip Away", result[3].Name);
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_WithVentress()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.ActivateUnit(service.UnitList.First(x => x.Name.Contains("Ventress")));

            // Arrange
            Assert.Equal(3, result.Count);
            Assert.Equal("Dathomirian Dexterity", result[0].Name);
            Assert.Equal("Force Push", result[1].Name);
            Assert.Equal("Sith Assassin", result[2].Name);
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_LordMaul()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.ActivateUnit(service.UnitList.First(x => x.Name.Contains("Lord Maul")));

            // Arrange
            Assert.Equal(4, result.Count);
            Assert.Equal("Force Speed", result[0].Name);
            Assert.Equal("There is No Place to Run", result[1].Name);
            Assert.Equal("Sustained By Rage", result[2].Name);
            Assert.Equal("Slip Away", result[3].Name);
        }
    }
}