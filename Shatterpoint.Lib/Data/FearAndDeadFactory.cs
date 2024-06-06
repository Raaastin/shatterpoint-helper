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
        public static string warbandname = "Fear And Dead Men";

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

        public static Unit StormTrooperSergeant()
        {
            var unit = new Unit("Stormtrooper Sergeant", "", UnitType.Secondary, UnitCardColor.Black, 3, 9, 2)
            {
                MainCardUrl = "todo",
                AbilityCardUrl = "todo",
                StanceCardUrl1 = "todo",
                StanceCardUrl2 = "todo",
                KeyWords = [KeyWords.GalacticEmpire, KeyWords.Stormtrooper],
                WarBandName = warbandname,
                Era = Era.GalacticCivilWar
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Inexorable Advance",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, you may choose an allied Galactic Empire Supporting Unit. Each character in the chosen Unit may *advance*. Then if any characters *advance*, the chosen Unit suffers *damage*",
                        Synergies = [new Synergy()
                        {
                            Type = UnitType.Support,
                            KeyWords = [KeyWords.GalacticEmpire]
                        }],
                        Timing = [Timing.Start]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Imperial Firepower",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Choose an enemy character within *range*4 of two or more allied Galactic Empire characters. The chosen character gains *pinned* or *disarmed*",
                        Synergies = [new Synergy()
                        {
                            KeyWords = [KeyWords.GalacticEmpire]
                        }],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Coordinated Offensive",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When a character in this Unit or another allied Stormtrooper character makes an attack as part of a combat action, before dice are rolled, this Unit may use this ability. Add 1 die to the attack roll for each allied Stormtrooper unit, other that the attacking unit, that is within *range* 5 and LOS of the target.",
                        Synergies = [new Synergy()
                        {
                            KeyWords = [KeyWords.Stormtrooper]
                        }],
                        Timing = [Timing.Active, Timing.AnotherActive]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Only Imperial Stormtroopers are so precise",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit have Sharpshooter[1]",
                        Synergies = [
                            new Synergy()
                            {
                                KeyWords = [KeyWords.GalacticEmpire]
                            }],
                        Timing = [Timing.Active]
                    }
                ];
            return unit;
        }

        public static Unit StormTrooper()
        {
            var unit = new Unit("Stormtroopers", "", UnitType.Support, UnitCardColor.Black, 4, 9, 2)
            {
                MainCardUrl = "todo",
                AbilityCardUrl = "todo",
                StanceCardUrl1 = "todo",
                StanceCardUrl2 = "todo",
                KeyWords = [KeyWords.GalacticEmpire, KeyWords.Stormtrooper, KeyWords.Trooper],
                WarBandName = warbandname,
                Era = Era.GalacticCivilWar
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Assault Tactics",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this unit may *dash*. Then this Unit may suffer *damage* to immediately perform a focus action.",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "For the Empire!",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Action: Choose an enemy character Engaged with one or more characters in this Unit and one of the allied characters it is Engaged with. Push the chosen character *range*2 Away from the chosen allied character. Then this Unit Gains *exposed*.",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Only Imperial Stormtroopers are so precise",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit have Sharpshooter[1]",
                        Synergies = [
                            new Synergy()
                            {
                                KeyWords = [KeyWords.GalacticEmpire]
                            }],
                        Timing = [Timing.Active]
                    }
                ];
            return unit;
        }
    }
}

