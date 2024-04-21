using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class GettingTargeted_Should_GalacticRep
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public GettingTargeted_Should_GalacticRep()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("General Anakin Skywalker"));
            selectedUnitsService.AddUnit(db.Get("CC-7567 Captain Rex"));
            selectedUnitsService.AddUnit(db.Get("CC501st Clone Troopers"));
            selectedUnitsService.AddUnit(db.Get("Ahsoka Tano, Jedi no more"));
            selectedUnitsService.AddUnit(db.Get("Bo-Katan Kryze"));
            selectedUnitsService.AddUnit(db.Get("Clan Kryze Mandalorians"));
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Ahsoka()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Ahsoka Tano, Jedi no more"));

            // Arrange
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_Anakin()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("General Anakin Skywalker"));

            // Arrange
            Assert.Equal(2, result.Count);
        }
    }
}