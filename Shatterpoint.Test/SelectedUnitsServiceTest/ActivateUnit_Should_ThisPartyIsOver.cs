using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class ActivateUnit_Should_ThisPartyIsOver
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public ActivateUnit_Should_ThisPartyIsOver()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("Jedi Master Mace Windu"), 0);
            selectedUnitsService.AddUnit(db.Get("CT-411 Commander Ponds"), 1);
            selectedUnitsService.AddUnit(db.Get("ARF Clone Troopers"), 2);
        }

        [Fact]
        public void MaceWindu()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Jedi Master Mace Windu"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Rush to action", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Shatterpoint", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Tempered Agression", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinate fire", result[3].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Jedi Master Mace Windu"));
            Assert.Single(result);
            Assert.Contains("This party's over", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void Ponds()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("CT-411 Commander Ponds"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Charge", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Forward Scout", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Incoming", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinate fire", result[3].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("CT-411 Commander Ponds"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Incoming", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("This party's over", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void ArfTrooper()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("ARF Clone Troopers"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Defensive Maneuver", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Incoming", result[1].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("ARF Clone Troopers"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Brothers in arms", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Lay low", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("This party's over", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Incoming", result[3].Name, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}