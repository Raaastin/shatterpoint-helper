using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class ActivateUnit_Should_Should_WeAreBrave
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public ActivateUnit_Should_Should_WeAreBrave()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("Queen Padmé Amidala"), 0);
            selectedUnitsService.AddUnit(db.Get("Sabé, Royal Bodyguard"), 1);
            selectedUnitsService.AddUnit(db.Get("Naboo Royal Handmaidens"), 2);
        }

        [Fact]
        public void Padmé()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Queen Padmé Amidala"));
            Assert.Equal(5, result.Count);
            Assert.Contains("Royal Command", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Crack Shot", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Servant of the People", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Fire", result[3].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Assault", result[4].Name, StringComparison.CurrentCultureIgnoreCase);


            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Queen Padmé Amidala"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Bodyguard", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Intercede", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            
        }

        [Fact]
        public void Sabé()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Sabé, Royal Bodyguard"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Loyal Protectors", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Expose Flank", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Fire", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Fire", result[3].Name, StringComparison.CurrentCultureIgnoreCase);


            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Sabé, Royal Bodyguard"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Bodyguard", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Intercede", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void NabooHandmaiden()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Naboo Royal Handmaidens"));
            Assert.Equal(5, result.Count);
            Assert.Contains("Expose Flank", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Fire", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Fire", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated Assault", result[3].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Servant of the People", result[4].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Naboo Royal Handmaidens"));
            Assert.Single(result);
            Assert.Contains("Bodyguard", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}