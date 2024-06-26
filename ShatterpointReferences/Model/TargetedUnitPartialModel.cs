﻿using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace ShatterpointReferences.Model
{
    public class TargetedUnitPartialModel
    {
        public Unit SelectedUnit { get; set; }
        public List<Ability> CurrentTargetSynergies { get; set; } = new List<Ability>();
    }
}
