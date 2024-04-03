using ShatterpointReferences.Units;
using ShatterpointReferences.Units.Abilities;

namespace ShatterpointReferences.Services
{
    public class SelectedUnitsService
    {
        public List<Unit> SelectedUnits { get; set; }
        private readonly UnitDataBaseService _unitDataBaseService;

        public SelectedUnitsService(UnitDataBaseService unitDataBaseService)
        {
            _unitDataBaseService = unitDataBaseService;
        }

        public void SelectUnit(string name)
        {
            if (SelectedUnits.Any(x => x.Name == name))
                return;

            var unit = SelectedUnits.FirstOrDefault(x => x.Name == name);
            if (unit is null)
                return;

            SelectedUnits.Add(unit);
        }

        public List<Ability> ActivateUnit(Unit unit)
        {
            var result = new List<Ability>();

            // Add start abilities
            result.AddRange(unit.Abilities.Where(x => x.Type == AbilityType.Automatic && x.Timing == Timing.Start));

            // Add current activation abilities
            result.AddRange(unit.Abilities.Where(x => x.Timing == Timing.Active));

            // Add abilities from other units that matches the synergies
            foreach (var ally in SelectedUnits.Where(x => x.Name != unit.Name))
            {
                foreach (var ability in ally.Abilities.Where(x => x.Type == AbilityType.Reactive))
                {
                    if (ability.Synergies.Any(x =>
                        (x.Name is not null && x.Name == unit.Name) || // case: synergy with this character
                        (x.KeyWords.Any() && x.KeyWords.Intersect(unit.KeyWords).Any() && (x.Type is null || x.Type == unit.Type)) // Synergy by Keyword
                    ))
                    {
                        result.Add(ability);
                    }
                }
            }

            return result;
        }

        public List<Ability> GettingTargeted(Unit unit)
        {
            var result = new List<Ability>();

            result.AddRange(unit.Abilities.Where(x => x.Timing == Timing.Targeted));

            return result;
        }
    }
}
