using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class GettingTargeted_Should
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public GettingTargeted_Should()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("Kalani, Super Tactical Robot"));
            selectedUnitsService.AddUnit(db.Get("B1 Battle Droids"));
            selectedUnitsService.AddUnit(db.Get("Asaji Ventress, Sith Assassin"));
            selectedUnitsService.AddUnit(db.Get("Lord Maul"));
            selectedUnitsService.AddUnit(db.Get("Gar Saxon, Merciless Commander"));
            selectedUnitsService.AddUnit(db.Get("Mandalorian Super Commandos"));
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Kalani()
        {
            // Act
            var result = selectedUnitsService.GettingTargeted(db.Get("Kalani, Super Tactical Robot"));

            // Arrange
            Assert.Empty(result);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_B1BattleDroid()
        {
            // Act
            var result = selectedUnitsService.GettingTargeted(db.Get("B1 Battle Droids"));

            // Arrange
            Assert.Single(result);
            Assert.Equal("I Hate This Job", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Ventress()
        {
            // Act
            var result = selectedUnitsService.GettingTargeted(db.Get("Asaji Ventress, Sith Assassin"));

            // Arrange
            Assert.Single(result);
            Assert.Equal("Riposte", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Maul()
        {
            // Act
            var result = selectedUnitsService.GettingTargeted(db.Get("Lord Maul"));

            // Arrange
            Assert.Single(result);
            Assert.Equal("Revenge, I Myst Have Revenge", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_GarSaxon()
        {
            // Act
            var result = selectedUnitsService.GettingTargeted(db.Get("Gar Saxon, Merciless Commander"));

            // Arrange
            Assert.Empty(result);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_MandalorianSuperCommandos()
        {
            // Act
            var result = selectedUnitsService.GettingTargeted(db.Get("Mandalorian Super Commandos"));

            // Arrange
            Assert.Empty(result);
        }
    }
}