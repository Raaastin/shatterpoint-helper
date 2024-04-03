using ShatterpointReferences.Services;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class GettingTargeted_Should
    {
        public SelectedUnitsService service;
        public UnitDataBaseService db;

        public GettingTargeted_Should()
        {
            db = new();
            service = new(db);

            service.SelectUnit("Kalani, Super Tactical Robot");
            service.SelectUnit("B1 Battle Droids");
            service.SelectUnit("Asaji Ventress, Sith Assassin");
            service.SelectUnit("Lord Maul");
            service.SelectUnit("Gar Saxon, Merciless Commander");
            service.SelectUnit("Mandalorian Super Commandos");
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Kalani()
        {
            // Act
            var result = service.GettingTargeted(service.SelectedUnits.First(x => x.Name.Contains("Kalani")));

            // Arrange
            Assert.Empty(result);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_B1BattleDroid()
        {
            // Act
            var result = service.GettingTargeted(service.SelectedUnits.First(x => x.Name.Contains("B1 Battle Droid")));

            // Arrange
            Assert.Single(result);
            Assert.Equal("I Hate This Job", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Ventress()
        {
            // Act
            var result = service.GettingTargeted(service.SelectedUnits.First(x => x.Name.Contains("Ventress")));

            // Arrange
            Assert.Single(result);
            Assert.Equal("Riposte", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Maul()
        {
            // Act
            var result = service.GettingTargeted(service.SelectedUnits.First(x => x.Name.Contains("Maul")));

            // Arrange
            Assert.Single(result);
            Assert.Equal("Revenge, I Myst Have Revenge", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_GarSaxon()
        {
            // Act
            var result = service.GettingTargeted(service.SelectedUnits.First(x => x.Name.Contains("Gar Saxon")));

            // Arrange
            Assert.Empty(result);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_MandalorianSuperCommandos()
        {
            // Act
            var result = service.GettingTargeted(service.SelectedUnits.First(x => x.Name.Contains("Mandalorian Super Commandos")));

            // Arrange
            Assert.Empty(result);
        }
    }
}