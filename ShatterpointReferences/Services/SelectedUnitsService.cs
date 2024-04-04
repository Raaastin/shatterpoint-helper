using ShatterpointReferences.Units;
using ShatterpointReferences.Units.Abilities;

namespace ShatterpointReferences.Services
{
    public class ActivateUnitService
    {
        public static List<Ability> ActivateUnit(Unit unit, List<Unit> selectedUnit)
        {
            var result = new List<Ability>();

            // Add start abilities
            result.AddRange(unit.Abilities.Where(x => x.Type == AbilityType.Automatic && x.Timing == Timing.Start));

            // Add current activation abilities
            result.AddRange(unit.Abilities.Where(x => x.Timing == Timing.Active));

            // Add abilities from other units that matches the synergies
            foreach (var ally in selectedUnit.Where(x => x.Name != unit.Name))
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

        // Todo: add 
        public static List<Ability> GettingTargeted(Unit unit, List<Unit> selectedUnit)
        {
            var result = new List<Ability>();

            // Ability for when getting targeted
            result.AddRange(unit.Abilities.Where(x => x.Timing == Timing.Targeted));

            // Ability from other units for when getting targeted
            foreach (var ally in selectedUnit.Where(x => x.Name != unit.Name))
            {
                foreach (var ability in ally.Abilities.Where(x => x.Timing == Timing.Targeted))
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
    }
}
