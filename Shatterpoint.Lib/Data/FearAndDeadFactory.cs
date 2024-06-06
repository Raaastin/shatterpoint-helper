using Shatterpoint.Lib.Extensions;
using Shatterpoint.Lib.Model.Units;
using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Services
{
    /// <summary>
    /// Factory for Dark Vador
    /// </summary>
    public static class FearAndDeadFactory
    {
        public static string warbandname = "Fear And Dead";
        public static Unit Vader()
        {
            var unit = new Unit("Darth Vader, the emperor's servant", "Darth Vader", UnitType.Primary, UnitCardColor.Black, 7, 12, 3, 3)
            {
                MainCardUrl = "todo",
                AbilityCardUrl = "todo",
                StanceCardUrl1 = "todo",
                StanceCardUrl2 = "todo",
                KeyWords = [KeyWords.ForceUser, KeyWords.GalacticEmpire, KeyWords.Sith],
                WarBandName = warbandname,
                Era = Era.GalacticCivilWar
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "You don't know the power of the Dark Side",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, it may remove *damage**damage* or one condition from itself, then refresh *forceicon*",
                        Synergies = null,
                        Timing = [Timing.Start]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Hanger, Hate, Aggression",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "One character in this Unit may *dash*. If it does that character adds 3 dice to its next attack roll during this activation. If that attack roll contained one or more *failure* results, this Unit gains *exposed* after the attack is resolved.",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "You are unwise to lower you defense",
                        Type = AbilityType.Reactive,
                        Cost = 1,
                        Text = "When a character in this Unit is targeted by a *melee* attack, this Unit may use this ability. After the attack is resolved, if the attack roll contained one or more *failure* results, the attacking Unit suffers *damage**damage**damage*",
                        Synergies = null,
                        Timing = [Timing.Targeted]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Perhaps i can find new ways to motivate them",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When a character in this Unit Wounds an enemy Unit, after the effect is resolved, another allied Galactic Empire character may *dash*",
                        Synergies = [
                            new Synergy()
                            {
                                KeyWords = [KeyWords.GalacticEmpire]
                            }],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "You cannot hide forever",
                        Type = AbilityType.Identity,
                        Cost = 0,
                        Text = "At the end of this Unit's activation, if no character in this Unit Wounded an enemy Unit during that activation and if this Unit's Order Card is not in the Order Deck or in reserve, shuffle its Order Card into you Order Deck",
                        Synergies = null,
                        Timing = [Timing.Active]
                    }
                ];
            return unit;
        }

    }
}

