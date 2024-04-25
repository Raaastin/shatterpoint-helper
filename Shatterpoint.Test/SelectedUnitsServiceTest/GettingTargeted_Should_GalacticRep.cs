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

            selectedUnitsService.AddUnit(db.Get("General Anakin Skywalker"), 0);
            selectedUnitsService.AddUnit(db.Get("CC-7567 Captain Rex"), 1);
            selectedUnitsService.AddUnit(db.Get("CC501st Clone Troopers"), 2);
            selectedUnitsService.AddUnit(db.Get("Ahsoka Tano, Jedi no more"), 3);
            selectedUnitsService.AddUnit(db.Get("Bo-Katan Kryze"), 4);
            selectedUnitsService.AddUnit(db.Get("Clan Kryze Mandalorians"), 5);
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