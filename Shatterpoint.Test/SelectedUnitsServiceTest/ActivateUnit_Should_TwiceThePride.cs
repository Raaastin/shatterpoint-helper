using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class ActivateUnit_Should_TwiceThePride
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public ActivateUnit_Should_TwiceThePride()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("Count Dooku, Separatist Leader"), 0);
            selectedUnitsService.AddUnit(db.Get("Jango Fett, Bounty Hunter"), 1);
            selectedUnitsService.AddUnit(db.Get("MagnaGuard"), 2);
        }

        [Fact]
        public void Dooku()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Count Dooku, Separatist Leader"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Leader of the separatist", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Protection Protocols", result[1].Name, StringComparison.CurrentCultureIgnoreCase);


            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Count Dooku, Separatist Leader"));
            Assert.Equal(5, result.Count);
            Assert.Contains("Surely you can do better", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Twice the pride, double the fall", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Brave. But foolish", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Bodyguard", result[3].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Intercede", result[4].Name, StringComparison.CurrentCultureIgnoreCase);

        }

        [Fact]
        public void Jango()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Jango Fett, Bounty Hunter"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Jet Pack", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Capture wire", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("my client is getting impatient", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("I'm just looking to get paid", result[3].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Jango Fett, Bounty Hunter"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Twice the pride, double the fall", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Brave. But foolish", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Bodyguard", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Intercede", result[3].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void MagnaGuard()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("MagnaGuard"));
            Assert.Empty(result);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("MagnaGuard"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Twice the pride, double the fall", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Brave. But foolish", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}