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
        public void Contain_StartAbilities_ActiveAbilities_Synergies()
        {
            // Arrange
            service.InitStartedSet();

            // Act
            var result = service.ActivateUnit(service.UnitList.First(x => x.Name.Contains("Kalani")));

            // Arrange
            Assert.Equal("Roger, Roger", result[0].Name);
            Assert.Equal("Tactical Network", result[1].Name);
            Assert.Equal("Target, Concentrate All Firepower", result[2].Name);
            Assert.Equal("Combat A.I. Protocols", result[3].Name);
        }
    }
}