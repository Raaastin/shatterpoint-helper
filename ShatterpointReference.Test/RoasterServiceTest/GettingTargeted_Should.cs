using ShatterpointReferences.Services;

namespace ShatterpointReference.Test.RoasterServiceTest
{
    public class GettingTargeted_Should
    {
        public RoasterServices service;

        public GettingTargeted_Should()
        {
            service = new();
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Kalani()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.GettingTargeted(service.UnitList.First(x => x.Name.Contains("Kalani")));

            // Arrange
            Assert.Empty(result);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_B1BattleDroid()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.GettingTargeted(service.UnitList.First(x => x.Name.Contains("B1 Battle Droid")));

            // Arrange
            Assert.Single(result);
            Assert.Equal("I Hate This Job", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Ventress()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.GettingTargeted(service.UnitList.First(x => x.Name.Contains("Ventress")));

            // Arrange
            Assert.Single(result);
            Assert.Equal("Riposte", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Maul()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.GettingTargeted(service.UnitList.First(x => x.Name.Contains("Maul")));

            // Arrange
            Assert.Single(result);
            Assert.Equal("Revenge, I Myst Have Revenge", result[0].Name);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_GarSaxon()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.GettingTargeted(service.UnitList.First(x => x.Name.Contains("Gar Saxon")));

            // Arrange
            Assert.Empty(result);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_MandalorianSuperCommandos()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.GettingTargeted(service.UnitList.First(x => x.Name.Contains("Mandalorian Super Commandos")));

            // Arrange
            Assert.Empty(result);
        }
    }
}