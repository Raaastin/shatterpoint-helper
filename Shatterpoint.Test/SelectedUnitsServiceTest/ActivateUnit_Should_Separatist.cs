using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class ActivateUnit_Should_Separatist
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public ActivateUnit_Should_Separatist()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("Kalani, Super Tactical Robot"), 0);
            selectedUnitsService.AddUnit(db.Get("B1 Battle Droids"), 1);
            selectedUnitsService.AddUnit(db.Get("Asajj Ventress, Sith Assassin"), 2);
            selectedUnitsService.AddUnit(db.Get("Lord Maul"), 3);
            selectedUnitsService.AddUnit(db.Get("Gar Saxon, Merciless Commander"), 4);
            selectedUnitsService.AddUnit(db.Get("Mandalorian Super Commandos"), 5);
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_WithKalani()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Kalani, Super Tactical Robot"));

            // Arrange
            Assert.Equal(6, result.Count);
            Assert.Equal("Roger, Roger", result[0].Name);
            Assert.Equal("Complete Analysis", result[1].Name);
            Assert.Equal("Tactical Network", result[2].Name);
            Assert.Equal("Target, Concentrate All Firepower", result[3].Name);
            Assert.Equal("Slip Away", result[4].Name);
            Assert.Equal("Combat A.I. Protocols", result[5].Name);
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_WithBattleDroids()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("B1 Battle Droids"));

            // Arrange
            Assert.Equal(4, result.Count);
            Assert.Equal("Well, I Guess I'm in Charge Now", result[0].Name);
            Assert.Equal("Combat A.I. Protocols", result[1].Name);
            Assert.Equal("Slip Away", result[2].Name);
            Assert.Equal("Target, Concentrate All Firepower", result[3].Name);
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_WithVentress()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Asajj Ventress, Sith Assassin"));

            // Arrange
            Assert.Equal(3, result.Count);
            Assert.Equal("Dathomirian Dexterity", result[0].Name);
            Assert.Equal("Force Push", result[1].Name);
            Assert.Equal("Sith Assassin", result[2].Name);
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_LordMaul()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Lord Maul"));

            // Arrange
            Assert.Equal(4, result.Count);
            Assert.Equal("Force Speed", result[0].Name);
            Assert.Equal("There is No Place to Run", result[1].Name);
            Assert.Equal("Sustained By Rage", result[2].Name);
            Assert.Equal("Slip Away", result[3].Name);
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_GarSaxon()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Gar Saxon, Merciless Commander"));

            // Arrange
            Assert.Equal(5, result.Count);
            Assert.Equal("Pride of the Mandalor", result[0].Name);
            Assert.Equal("Jet Pack", result[1].Name);
            Assert.Equal("Mandalorians are Stronger Together", result[2].Name);
            Assert.Equal("I've Got You In My Sights", result[3].Name);
            Assert.Equal("Pack Hunter", result[4].Name);
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_MandalorianSuperCommandos()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Mandalorian Super Commandos"));

            // Arrange
            Assert.Equal(3, result.Count);
            Assert.Equal("Jet Pack", result[0].Name);
            Assert.Equal("Mandalorians are Stronger Together", result[1].Name);
            Assert.Equal("Victory or Death!", result[2].Name);
        }
    }
}