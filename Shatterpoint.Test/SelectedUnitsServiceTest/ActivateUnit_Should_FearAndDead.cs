using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class ActivateUnit_Should_FearAndDead
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public ActivateUnit_Should_FearAndDead()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("Darth Vader, the emperor's servant"), 0);
            selectedUnitsService.AddUnit(db.Get("Stormtrooper Sergeant"), 1);
            selectedUnitsService.AddUnit(db.Get("Stormtroopers"), 2);
        }

        [Fact]
        public void Vader()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Darth Vader, the emperor's servant"));
            Assert.Equal(4, result.Count);
            Assert.Contains("You don't know", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Hanger, Hate, Aggression", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Perhaps I can find", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("You cannot hide", result[3].Name, StringComparison.CurrentCultureIgnoreCase);


            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Darth Vader, the emperor's servant"));
            Assert.Single(result);
            Assert.Contains("You are unwise", result[0].Name, StringComparison.CurrentCultureIgnoreCase);

        }

        [Fact]
        public void StormtrooperSergeant()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Stormtrooper Sergeant"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Inexorable Advance", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Imperial Firepower", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinate Offensive", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("so precise", result[3].Name, StringComparison.CurrentCultureIgnoreCase);


            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Stormtrooper Sergeant"));
            Assert.Empty(result);
        }

        [Fact]
        public void Stormtroopers()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Stormtroopers"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Assault Tactics", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("For the Empire", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("so precise", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Assault", result[3].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Stormtroopers"));
            Assert.Empty(result);
        }
    }
}