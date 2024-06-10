using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class ActivateUnit_Should_AppetiteForDestruction
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public ActivateUnit_Should_AppetiteForDestruction()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("General Grievous"), 0);
            selectedUnitsService.AddUnit(db.Get("Kraken, Super Tactical Droid"), 1);
            selectedUnitsService.AddUnit(db.Get("B2 Battle Droids"), 2);
        }

        [Fact]
        public void Grievous()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("General Grievous"));
            Assert.Equal(5, result.Count);
            Assert.Contains("Onward", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Scuttle", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("I have been trained", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Appetite for destruction", result[3].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Another fine addition to my collection", result[4].Name, StringComparison.CurrentCultureIgnoreCase);


            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("General Grievous"));
            Assert.Empty(result);
            
        }

        [Fact]
        public void Kraken()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Kraken, Super Tactical Droid"));
            Assert.Equal(3, result.Count);
            Assert.Contains("Do not let them escape", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Complete analysis", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Tactical network", result[2].Name, StringComparison.CurrentCultureIgnoreCase);


            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Kraken, Super Tactical Droid"));
            Assert.Single(result);
            Assert.Contains("Conqueror's resolve", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void B2()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("B2 Battle Droids"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Relentless Advance", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Saturation fire", result[1].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("B2 Battle Droids"));
            Assert.Single(result);
            Assert.Contains("Enhanced Blast Armor", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}