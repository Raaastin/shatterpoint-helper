using ShatterpointReferences.Services;
using ShatterpointReferences.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class ActivateUnit_Should
    {
        public List<Unit> selecteUnits { get; set; } = new();
        public UnitDataBaseService db;

        public ActivateUnit_Should()
        {
            db = new();

            selecteUnits.Add(db.Get("Kalani, Super Tactical Robot"));
            selecteUnits.Add(db.Get("B1 Battle Droids"));
            selecteUnits.Add(db.Get("Asaji Ventress, Sith Assassin"));
            selecteUnits.Add(db.Get("Lord Maul"));
            selecteUnits.Add(db.Get("Gar Saxon, Merciless Commander"));
            selecteUnits.Add(db.Get("Mandalorian Super Commandos"));
        }

        [Fact]
        public void Contain_StartAbilities_ActiveAbilities_Synergies_WithKalani()
        {
            // Act
            var result = ActivateUnitService.ActivateUnit(db.Get("Kalani, Super Tactical Robot"), selecteUnits);

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
            // Act
            var result = ActivateUnitService.ActivateUnit(db.Get("B1 Battle Droids"), selecteUnits);

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
            // Act
            var result = ActivateUnitService.ActivateUnit(db.Get("Asaji Ventress, Sith Assassin"), selecteUnits);

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
            var result = ActivateUnitService.ActivateUnit(db.Get("Lord Maul"), selecteUnits);

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
            var result = ActivateUnitService.ActivateUnit(db.Get("Gar Saxon, Merciless Commander"), selecteUnits);

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
            var result = ActivateUnitService.ActivateUnit(db.Get("Mandalorian Super Commandos"), selecteUnits);

            // Arrange
            Assert.Equal(3, result.Count);
            Assert.Equal("Jet Pack", result[0].Name);
            Assert.Equal("Mandalorians are Stronger Together", result[1].Name);
            Assert.Equal("Victory or Death!", result[2].Name);
        }
    }
}