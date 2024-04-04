using ShatterpointReferences.Services;
using ShatterpointReferences.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class GettingTargeted_Should
    {
        public List<Unit> selectedUnits { get; set; } = new();
        public UnitDataBaseService db;

        public GettingTargeted_Should()
        {
            db = new();

            selectedUnits.Add(db.Get("Kalani, Super Tactical Robot"));
            selectedUnits.Add(db.Get("B1 Battle Droids"));
            selectedUnits.Add(db.Get("Asaji Ventress, Sith Assassin"));
            selectedUnits.Add(db.Get("Lord Maul"));
            selectedUnits.Add(db.Get("Gar Saxon, Merciless Commander"));
            selectedUnits.Add(db.Get("Mandalorian Super Commandos"));
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Kalani()
        {
            // Act
            var result = ActivateUnitService.GettingTargeted(db.Get("Kalani, Super Tactical Robot"), selectedUnits);

            // Arrange
            Assert.Empty(result);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_B1BattleDroid()
        {
            // Act
            var result = ActivateUnitService.GettingTargeted(db.Get("B1 Battle Droids"), selectedUnits);

            // Arrange
            Assert.Single(result);
            Assert.Equal("I Hate This Job", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Ventress()
        {
            // Act
            var result = ActivateUnitService.GettingTargeted(db.Get("Asaji Ventress, Sith Assassin"), selectedUnits);

            // Arrange
            Assert.Single(result);
            Assert.Equal("Riposte", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Maul()
        {
            // Act
            var result = ActivateUnitService.GettingTargeted(db.Get("Lord Maul"), selectedUnits);

            // Arrange
            Assert.Single(result);
            Assert.Equal("Revenge, I Myst Have Revenge", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_GarSaxon()
        {
            // Act
            var result = ActivateUnitService.GettingTargeted(db.Get("Gar Saxon, Merciless Commander"), selectedUnits);

            // Arrange
            Assert.Empty(result);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_MandalorianSuperCommandos()
        {
            // Act
            var result = ActivateUnitService.GettingTargeted(db.Get("Mandalorian Super Commandos"), selectedUnits);

            // Arrange
            Assert.Empty(result);
        }
    }
}