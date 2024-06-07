using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class ActivateUnit_Should_YouHaveSomethingIWant
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public ActivateUnit_Should_YouHaveSomethingIWant()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("Moff Gideon"), 0);
            selectedUnitsService.AddUnit(db.Get("Death Trooper Escort"), 1);
            selectedUnitsService.AddUnit(db.Get("Dark Troopers"), 2);
        }

        [Fact]
        public void Moff()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Moff Gideon"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Smug", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Long Live the Empire", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("You have something I want", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Fire", result[3].Name, StringComparison.CurrentCultureIgnoreCase);


            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Moff Gideon"));
            Assert.Empty(result);

        }

        [Fact]
        public void DeathTrooper()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Death Trooper Escort"));
            Assert.Equal(5, result.Count);
            Assert.Contains("Imperial Efficiency", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("tactical advance", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Rigorous Training", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Fire", result[3].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("You have something I want", result[4].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Death Trooper Escort"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Disciplined", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Rigorous Training", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void DarkTrooper()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Dark Troopers"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Jump boots", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("You have something I want", result[1].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Dark Troopers"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Immovable", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Unrelenting", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}