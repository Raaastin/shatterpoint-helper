using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace ShatterpointReference.Test.SelectedUnitsServiceTest
{
    public class ActivateUnit_Should_Should_GalacticRep
    {
        public SelectedUnitsService selectedUnitsService { get; set; }
        public UnitDataBaseService db;

        public ActivateUnit_Should_Should_GalacticRep()
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
        public void Ahsoka()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Ahsoka Tano, Jedi no more"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Force Speed", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated fire", result[1].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Ahsoka Tano, Jedi no more"));
            Assert.Equal(2, result.Count);
            Assert.Contains("what's the matter", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("deflect", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void Anakin()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("General Anakin Skywalker"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Force Jump", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("I'm going to end thi", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("This is where the fun begins", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated fire", result[3].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("General Anakin Skywalker"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Deflect", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Fierce Protector", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void Rex()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("CC-7567 Captain Rex"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Get a move on", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Defensive Maneuver", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Bring it on", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Coordinated fire", result[3].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("CC-7567 Captain Rex"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Brothers in arms", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Fierce Protector", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void CC501()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("CC501st Clone Troopers"));
            Assert.Equal(3, result.Count);
            Assert.Contains("defensive maneuver", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("i'm always first, kid", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Bring it on, clankers", result[2].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("CC501st Clone Troopers"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Brother in arms", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Fierce Protector", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void Bokatan()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Bo-Katan Kryze"));
            Assert.Equal(4, result.Count);
            Assert.Contains("Pride of the Mandalore", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Jet Pack", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Mandalorians are stronger together", result[2].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Mandalore will survive", result[3].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Bo-Katan Kryze"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Some of us serve a higher purpose", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Fierce protector", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void ClanKryzeMandalorian()
        {
            // Act
            var result = selectedUnitsService.GetAbilitiesForTheActiveUnit(db.Get("Clan Kryze Mandalorians"));
            Assert.Equal(3, result.Count);
            Assert.Contains("Jet Pack", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Mandalorians are stronger together", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Helmet visor", result[2].Name, StringComparison.CurrentCultureIgnoreCase);

            // Act 2
            result = selectedUnitsService.GetAbilitiesForTheTargetedUnit(db.Get("Clan Kryze Mandalorians"));
            Assert.Equal(2, result.Count);
            Assert.Contains("Fierce protector", result[0].Name, StringComparison.CurrentCultureIgnoreCase);
            Assert.Contains("Some of us serve a higher purpose", result[1].Name, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}