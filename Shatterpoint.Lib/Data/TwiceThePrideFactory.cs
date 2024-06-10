using Shatterpoint.Lib.Extensions;
using Shatterpoint.Lib.Model.Units;
using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Services
{
    /// <summary>
    /// Factory for Dark Vador
    /// </summary>
    public static class TwiceThePrideFactory
    {
        public static string warbandname = "Twice The Pride";
        public static List<string> era = [Era.CloneWars];

        public static Unit Dooku()
        {
            var unit = new Unit("Count Dooku, Separatist Leader", "Count Dooku", UnitType.Primary, UnitCardColor.Red, 7, 10, 3, 4)
            {
                MainCardUrl = "https://shatterpointdb.com/media/skjjanqg/star-wars-shatterpoint-count-dooku-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/nx0l502q/star-wars-shatterpoint-count-dooku-abilitiescard.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/zuhjk3xz/star-wars-shatterpoint-count-dooku-stance-1-card.png",
                StanceCardUrl2 = "https://shatterpointdb.com/media/lqbpnsk0/star-wars-shatterpoint-count-dooku-stance-2card.png",
                KeyWords = [KeyWords.ForceUser, KeyWords.SeparatistAlliance, KeyWords.Sith],
                WarBandName = warbandname,
                Era = era
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Leader of the separatist army",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this unit activation choose another allied Separatist Alliance character within *range*3. Each character in this unit and the chosen character may *dash*.",
                        Synergies = [new Synergy()
                        {
                            KeyWords = [KeyWords.SeparatistAlliance]
                        }],
                        Timing = [Timing.Start]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Surely you can do better",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When a character in this Unit defends, during the Modify Dice Rolls step, this Unit may spend 1-3 *forceicon* to use this ability. Change one *hit* result to a *failure* for each *forceicon* spent.",
                        Synergies = null,
                        Timing = [Timing.Targeted]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Twice the pride, double the fall",
                        Type = AbilityType.Reactive,
                        Cost = 1,
                        Text = "After a *melee* attack targetting an allied character within *range*2 is resolved, this Unit may use this ability. If the attack contained no *hit* results, one character in this Unit may *dash* and then make a 5 dice *melee* attack targetting the attacking character.",
                        Synergies = null,
                        Timing = [Timing.Targeted, Timing.AlliedTargeted]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Brave. But foolish",
                        Type = AbilityType.Identity,
                        Cost = 0,
                        Text = "Once a turn, when an allied Primary unit or allied Secondary unit is wounded by an enemy effect, after the effect is resolved, refresh *forceicon**forceicon*. Then, choose an allied Separatist Alliance Supporting Unit. One character in the chosen unit may *dash* or make a 5 dice attack.",
                        Synergies = [
                            new Synergy()
                            {
                                Type = UnitType.Primary
                            },
                            new Synergy()
                            {
                                Type = UnitType.Secondary
                            },
                            new Synergy()
                            {
                                Type = UnitType.Support,
                                KeyWords = [KeyWords.SeparatistAlliance],
                                NoCardRelated = true
                            }],
                        Timing = [Timing.Targeted, Timing.AlliedTargeted]
                    }
                ];
            return unit;
        }

        public static Unit JangoFett()
        {
            var unit = new Unit("Jango Fett, Bounty Hunter", "", UnitType.Secondary, UnitCardColor.Red, 4, 9, 2)
            {
                MainCardUrl = "https://shatterpointdb.com/media/cxuf1zfk/star-wars-shatterpoint-jango-fett-unit-card-2.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/0h1jydyw/star-wars-shatterpoint-jango-fett-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/ooin3tny/star-wars-shatterpoint-jango-fett-stance-card.png",
                StanceCardUrl2 = null,
                KeyWords = [KeyWords.BountyHunter, KeyWords.Mercenary, KeyWords.Scoundrel, KeyWords.SeparatistAlliance],
                WarBandName = warbandname,
                Era = [Era.CloneWars]
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Jet pack",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *jump*.",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Capture wire",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Choose a character in this unit and an enemy character within *range*3 of that character. Pull the chosen enemy character *range*2 toward the chosen allied character. Then the chosen enemy character gains *disarmed*.",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "No so fast",
                        Type = AbilityType.Reactive,
                        Cost = 1,
                        Text = "At the start of an enemy Unit activation, if one or more characters in that unit are within *range*3 of a character in this unit, this unit may use this ability. Roll 5 attack dice. The activating unit suffers  for each *crit* and *hit* result in the roll.",
                        Synergies = null,
                        Timing = [Timing.Opponent]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "My client is getting impatient",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "After this unit makes a focus action, one character in this unit may *jump*",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "I'm just looking to get paid",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When a character in this unit wounds an enemy primary unit or secondary unit, after the effect is resolved, refresh *forceicon**forceicon* and one character in this unit may *heal**heal*.",
                        Synergies = null,
                        Timing = [Timing.Active]
                    }
                ];
            return unit;
        }

        public static Unit MagnaGuard()
        {
            var unit = new Unit("MagnaGuard", "", UnitType.Support, UnitCardColor.Red, 3, 10, 2)
            {
                MainCardUrl = "https://shatterpointdb.com/media/xtxn0ays/star-wars-shatterpoint-magnaguard-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/0fmbhkw3/star-wars-shatterpoint-magnaguard-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/n1glwks5/star-wars-shatterpoint-magnaguard-stance-card.png",
                StanceCardUrl2 = null,
                KeyWords = [KeyWords.BattleDroid, KeyWords.Droid, KeyWords.SeparatistAlliance, KeyWords.Trooper],
                WarBandName = warbandname,
                Era = [Era.CloneWars]
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Protection Protocols",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After an allied Separatist Alliance Primary unit makes a move action, this unit can use this ability. Choose a character in the activating Primary Unit. One character from this unit can perform a *advance* towards the chosen character.",
                        Synergies = [new Synergy()
                        {
                            Type = UnitType.Primary,
                            KeyWords = [KeyWords.SeparatistAlliance]
                        }],
                        Timing = [Timing.AnotherActive]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Bodyguard",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Allied Primary characters within 2 and allied Secondary characters within *range*2 of a character in this unit have COVER [1]",
                        Synergies = [new Synergy()
                            {
                                Type = UnitType.Primary
                            },
                            new Synergy()
                            {
                                Type = UnitType.Secondary
                            }],
                        Timing = [Timing.AlliedTargeted]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Intercede",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "While this Unit is not Wounded, enemy characters Engaged with one or more characters in this Unit cannot target allied Primary characters or allied Secondary characters with attacks.",
                        Synergies = [new Synergy()
                        {
                            Type = UnitType.Primary
                        },
                        new Synergy()
                        {
                            Type = UnitType.Secondary
                        }],
                        Timing = [Timing.AlliedTargeted]
                    }
                ];
            return unit;
        }
    }
}

