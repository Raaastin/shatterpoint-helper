﻿using ShatterpointReferences.Units;
using ShatterpointReferences.Units.Abilities;

namespace ShatterpointReferences.Services
{
    public class RoasterServices
    {
        public List<Unit> UnitList { get; set; }

        public RoasterServices()
        {
        }

        public void InitStartedSet()
        {
            UnitList = new();

            UnitList.Add(StartSetFactory.Kalani());
            UnitList.Add(StartSetFactory.B1BAttleDroids());
            UnitList.Add(StartSetFactory.AsajiVentress());
            UnitList.Add(StartSetFactory.LordMaul());
            UnitList.Add(StartSetFactory.GarSaxon());
            UnitList.Add(StartSetFactory.MandalorianSuperCommandos());
        }

        public List<Ability> ActivateUnit(Unit unit)
        {
            var result = new List<Ability>();

            // Add start abilities
            result.AddRange(unit.Abilities.Where(x => x.Type == AbilityType.Automatic && x.Timing == Timing.Start));

            // Add current activation abilities
            result.AddRange(unit.Abilities.Where(x => x.Timing == Timing.Active));

            // Add abilities from other units that matches the synergies
            foreach (var ally in UnitList.Where(x => x.Name != unit.Name))
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