using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Services
{
    /// <summary>
    /// Factory for Starter Box
    /// </summary>
    public static class StarterBoxFactory
    {

        public static Unit Kalani()
        {
            var unit = new Unit()
            {
                Name = "Kalani, Super Tactical Robot",
                //PictureUrl = "kalani-pp.png",
                PictureUrl = "https://shatterpointdb.com/media/rsnodu4s/kalani-stance-card.png",
                UniqueName = "Kalani",
                Type = UnitType.Secondary,
                KeyWords = new List<string> { KeyWords.BattleDroid, KeyWords.Droid, KeyWords.SeparatistAlliance },
            };

            unit.Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Roger, Roger",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, each allied Battle Droid Supporting character within *range*4 of a character in this Unit may *dash*",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = UnitType.Support,
                                KeyWords = new List<string> { KeyWords.BattleDroid }
                            }
                        },
                        Timing = new (){ Timing.Start }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Tactical Network",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Chose another allied Battle Droid character within *range*4. The chosen Character may *dash*, then may gain *hunker*, remove one condition from itself, or make a 5 dice attack",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = new List<string> { KeyWords.BattleDroid }
                            }
                        },
                        Timing = new () { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Target, Concentrate All Firepower",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When an allied Battle Droid character makes an attack, if the targeted character is within *range*4 of one or more other allied Battle Droid characters, the attacking character adds 1 die to its attack roll.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = new List<string> { KeyWords.BattleDroid }
                            }
                        },
                        Timing = new () { Timing.Active, Timing.AnotherActive }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Complete Analysis",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When you spend 1F to place this Unit's Order Card in reserve, spend 1 less F",
                        Synergies = new List<Synergy>(),
                        Timing = new (){ Timing.Start }
                    }
                };
            return unit;
        }

        public static Unit B1BAttleDroids()
        {
            var unit = new Unit()
            {
                Name = "B1 Battle Droids",
                PictureUrl = "https://shatterpointdb.com/media/bi4hxev0/b1-stance-card.png",
                UniqueName = "",
                Type = UnitType.Support,
                KeyWords = new List<string> { KeyWords.BattleDroid, KeyWords.Droid, KeyWords.SeparatistAlliance, KeyWords.Trooper },

            };

            unit.Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Weilder =unit,
                        Name = "Combat A.I. Protocols",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "After an allied Battle Droid Unit makes a combat action, choose one of the targeted characters that is within *range*4 of all character in this Unit if able. the chosen character gains *strained* or *exposed*.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = new List<string> { KeyWords.BattleDroid }
                            }
                        },
                        Timing = new() { Timing.Active, Timing.AnotherActive }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Well, I Guess I'm in Charge Now",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When this Unit's Order Card would be placed in reserve, it's controlling player may place it on the bottom of their Order Deck instead",
                        Synergies = new List<Synergy>(),
                        Timing = new() { Timing.Start }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "I Hate This Job",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "While a character in this Unit is contesting one or more Active objectives, it has protection",
                        Synergies = new List<Synergy>(),
                        Timing = new() { Timing.Targeted }
                    }
                };

            return unit;


        }

        public static Unit AsajiVentress()
        {
            var unit = new Unit()
            {
                Name = "Asajj Ventress, Sith Assassin",
                PictureUrl = "https://shatterpointdb.com/media/unhltw4d/star-wars-shatterpoint-asajj-ventress-stance-two.png",
                UniqueName = "Asaji Ventress",
                Type = UnitType.Primary,
                KeyWords = new List<string> { KeyWords.SeparatistAlliance },

            };
            unit.Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Dathomirian Dexterity",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *jump*. This Unit may use this ability two times during its activation",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Force Push",
                        Type = AbilityType.Active,
                        Cost = 2,
                        Text = "Choose a character in this Unit and an enemy character within *range*3 of that character. Push the choosen enemy character *range*3 away from the choosen allied character",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Riposte",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After a *melee* attack targetting a character in this Unit is resolved, this Unit may use this ability. If the attack roll contained one or more Fail results, the attacking Unit suffers 2D",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Targeted }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Slip Away",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When another Dathomirian or Separatist Alliance character targets an enemy character that is Engaged with one of more characters in this Unit with an attack, this Unit may use this ability. One character in this Unit that is Engaged with the target character may immediately repos. If it does, this unit gains *hunker*",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = new List<string>() { KeyWords.SeparatistAlliance, KeyWords.Dathomirian }
                            }
                        },
                        Timing = new() { Timing.AnotherActive }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Sith Assassin",
                        Type = AbilityType.Identity,
                        Cost = 0,
                        Text = "When a character in this Unit Wounds an enemy Unit, after the effect is resolved, that carachter may *heal**heal**heal*. If it Wounded a Primary Unit or Secondary Unit, it may also *advance* or *jump*. If it Wounder a primary Unit, refresh 2F.",
                        Synergies = new List<Synergy>()
                        {

                        },
                        Timing = new() { Timing.Active }
                    }
                };

            return unit;
        }

        public static Unit LordMaul()
        {
            var unit = new Unit()
            {
                Name = "Lord Maul",
                PictureUrl = "https://shatterpointdb.com/media/3jxhjwvb/maulstance2.png",
                UniqueName = "Maul",
                Type = UnitType.Primary,
                KeyWords = new List<string> { KeyWords.Dathomirian, KeyWords.ForceUser, KeyWords.Scoundrel, KeyWords.ShadowCollective },

            };

            unit.Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Force Speed",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *advance*.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "There is No Place to Run",
                        Type = AbilityType.Active,
                        Cost = 2,
                        Text = "Choose a character in this Unit and an enemy character within *range*3 of that character. Pull the chosen enemy character *range*2 Toward the chosen allied character. Then the chosen enemy character gains Exposed",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Revenge, I Myst Have Revenge",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When this Unit is Wounded by a *melee* attack, after the attack is resolved, one character in this Unit may immediately *dash* and make a 5 dive *melee* attack targeting the character that Wounded it.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Targeted }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Sustained By Rage",
                        Type = AbilityType.Identity,
                        Cost = 0,
                        Text = "While this Unit is not Wounded, when it would spend F to use an ability, it may suffer *damage* equal to the cost of the ability instead. For every 3 *damage* this Unit has, characters in this Unit add 1 die to their *melee* Attack rolls. For each injured token this Unit has, characters in this Unit add 3 dice to their *melee* attack rolls.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    }
                };

            return unit;
        }

        public static Unit GarSaxon()
        {
            var unit = new Unit()
            {
                Name = "Gar Saxon, Merciless Commander",
                PictureUrl = "https://shatterpointdb.com/media/xu1pp1jl/star-wars-shatterpoint-gar-saxon-stance.png",
                UniqueName = "Gar Saxon",
                Type = UnitType.Secondary,
                KeyWords = new List<string> { KeyWords.Mandalorian, KeyWords.ShadowCollective, KeyWords.SuperCommando },

            };
            unit.Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Pride of the Mandalor",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, choose another allied Mandalorian character. The chosen character may *jump*.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Start }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Jet Pack",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *jump*.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Mandalorians are Stronger Together",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After this Unit makes a move action, it may use this ability. If a character in this Unit is within *range*2 of another allied Mandalorian character, this Unit immediately makes a focus action",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "I've Got You In My Sights",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit have Sharpshooter(2). When a character in this Unit makes a *ranged* attack, the target does not benefit from Cover. After this Unit Makes a focus action, it gains *hunker*",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Pack Hunter",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When a character in this Unit makes a *melee* attack targeting an enemy character that is Engaged with another allied Mandalorian character, it adds 2 dice to the attack roll",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    }
                };

            return unit;
        }

        public static Unit MandalorianSuperCommandos()
        {
            var unit = new Unit()
            {
                Name = "Mandalorian Super Commandos",
                PictureUrl = "https://shatterpointdb.com/media/umplqvvr/star-wars-mandalorian-super-commandos-stance.png",
                UniqueName = "",
                Type = UnitType.Support,
                KeyWords = new List<string> { KeyWords.Mandalorian, KeyWords.ShadowCollective, KeyWords.SuperCommando, KeyWords.Trooper },

            };

            unit.Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Jet Pack",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *jump*.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Mandalorians are Stronger Together",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After this Unit makes a move action, it may use this ability. If a character in this Unit is within *range*2 of another allied Mandalorian character, this unit immediately makes a focus action",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "No Mercy",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When an enemy character that is Engaged with one or more characters in this Unit *advance* or *dash*, after the move is resolved, the moving character's unit suffers *damage**damage* if the moving character is no longer engaged with one or more characters in this Unit.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Opponent }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Victory or Death!",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit have Impact(1)",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    }
                };

            return unit;
        }

        public static Unit Anakin()
        {
            var unit = new Unit()
            {
                Name = "General Anakin Skywalker",
                PictureUrl = "https://shatterpointdb.com/media/htydlen3/starwarsshatterpointanakinskywalkerstancetwo.png",
                UniqueName = "Anakin Skywalker",
                Type = UnitType.Primary,
                KeyWords = new List<string> { KeyWords._501ST, KeyWords.ForceUser, KeyWords.GalacticRepublic, KeyWords.Jedi },

            };
            unit.Abilities = new List<Ability>()
            {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Force Jump",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this unit may *jump*",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "I'm going to end this",
                        Type = AbilityType.Reactive,
                        Cost = 2,
                        Text = "After this Unit makes a combat action, it may use this ability. One character in this unit may make an attack targeting one of the same enemy characters within range and LOS",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Deflect",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After a *ranged* attack targeting a character in this Unit is resolved, this Unit may use this ability. If the attack roll contained one or more *failure* results, the attacking Unit suffers *damage**damage*.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Targeted }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "This is where the fun begins",
                        Type = AbilityType.Identity,
                        Cost = 0,
                        Text = "When a character in this Unit Wounds an enemy Primary Unit or enemy Secondary Unit, after this effect is resolved, move the Struggle token one space toward your Momentum tokens. Then, if the Wounded Unit is a Primary Unit, each allied Galactic Republic character may *heal*.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                KeyWords = new List<string>()
                                {
                                    KeyWords.GalacticRepublic
                                },
                                Name = null,
                                Type = null
                            }
                        },
                        Timing = new() { Timing.Active }
                    }
            };
            return unit;
        }
    }
}
