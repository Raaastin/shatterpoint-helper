using Shatterpoint.Lib.Model;
using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Services
{
    public class SelectedUnitsService
    {
        public List<Unit> SelectedUnits { get; set; }

        public ActiveUnitModel ActiveUnit { get; set; }

        public List<Ability> PayAttentionAbilities { get; set; }

        public SelectedUnitsService()
        {
            SelectedUnits = new();
        }

        public void ClearSelectedUnits()
        {
            SelectedUnits.Clear();
            ActiveUnit = null;
        }

        public void AddUnit(Unit unit)
        {
            SelectedUnits.Add(unit);
        }

        /// <summary>
        /// Get all the available abilities of a unit during it's activation
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="selectedUnit"></param>
        /// <returns></returns>
        public List<Ability> ActivateUnit(Unit unit)
        {
            var result = new List<Ability>();

            // Add this unit's abilities (then order)
            result.AddRange(unit.Abilities.Where(x => x.Timing.Contains(Timing.Start) || x.Timing.Contains(Timing.Active)));
            result = result.OrderBy(x => x.Timing.FirstOrDefault()).ThenBy(x => x.Type).ToList();

            // Add abilities from other units: Reactive, Inate (then order
            var synergyAbilities = new List<Ability>();
            foreach (var ally in SelectedUnits.Where(x => x is not null && x.Name != unit.Name))
            {
                foreach (var ability in ally.Abilities.Where(x =>
                    (x.Timing.Contains(Timing.AnotherActive)) &&
                    (x.Type == AbilityType.Reactive || x.Type == AbilityType.Inate || x.Type == AbilityType.Identity)))
                {
                    if (ability.Synergies.Any(x =>
                        (x.Name is not null && x.Name == unit.Name) || // case: synergy with this character
                        (x.KeyWords.Any() && x.KeyWords.Intersect(unit.KeyWords).Any() && (x.Type is null || x.Type == unit.Type)) // Synergy by Keyword
                    ))
                    {
                        synergyAbilities.Add(ability);
                    }
                }
            }
            synergyAbilities = synergyAbilities.OrderBy(x => x.Type).ThenBy(x => x.Timing.FirstOrDefault()).ToList();

            result.AddRange(synergyAbilities);

            return result;
        }

        /// <summary>
        /// Get abilities that are relevant when the selected unit is targeted by an attack
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public List<Ability> GettingTargeted(Unit unit)
        {
            var result = new List<Ability>();

            // Ability for when getting targeted
            result.AddRange(unit.Abilities.Where(x => x.Timing.Contains(Timing.Targeted)));

            // Ability from other units for when getting targeted
            foreach (var ally in SelectedUnits.Where(x => x is not null && x.Name != unit.Name))
            {
                foreach (var ability in ally.Abilities.Where(x => x.Timing.Contains(Timing.Targeted)))
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

        /// <summary>
        /// Get all relevant abilities when any opponent unit does something
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public List<Ability> PayAttention()
        {
            var result = new List<Ability>();

            foreach (var ally in SelectedUnits)
            {
                foreach (var ability in ally.Abilities.Where(x => x.Timing.Contains(Timing.Opponent)))
                {
                    result.Add(ability);
                }
            }

            return result;
        }
    }
}
