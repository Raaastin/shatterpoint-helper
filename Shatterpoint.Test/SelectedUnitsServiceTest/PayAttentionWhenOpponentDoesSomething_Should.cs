using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class PayAttentionWhenOpponentDoesSomething_Should
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public PayAttentionWhenOpponentDoesSomething_Should()
        {
            db = new();
            selectedUnitsService = new();

            selectedUnitsService.AddUnit(db.Get("Kalani, Super Tactical Robot"), 0);
            selectedUnitsService.AddUnit(db.Get("B1 Battle Droids"), 1);
            selectedUnitsService.AddUnit(db.Get("Asajj Ventress, Sith Assassin"), 2);
            selectedUnitsService.AddUnit(db.Get("Lord Maul"), 3);
            selectedUnitsService.AddUnit(db.Get("Gar Saxon, Merciless Commander"), 4);
            selectedUnitsService.AddUnit(db.Get("Mandalorian Super Commandos"), 5);
        }

        [Fact]
        public void Contains_ReactiveOrDefensive_abilities_B1BattleDroid()
        {
            // Act
            var result = selectedUnitsService.PayAttention();

            // Arrange
            Assert.Single(result);
            Assert.Equal("No Mercy", result[0].Name);
        }
    }
}