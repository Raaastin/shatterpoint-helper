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
            var unit = new Unit("Kalani, Super Tactical Robot", "Kalani", UnitType.Secondary, UnitCardColor.Red)
            {
                MainCardUrl = "https://shatterpointdb.com/media/gtbfzv2n/star-wars-shatterpoint-kalani-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/2mykdrxq/star-wars-shatterpoint-kalani-abilities.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/rsnodu4s/kalani-stance-card.png",
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
            var unit = new Unit("B1 Battle Droids", "", UnitType.Support, UnitCardColor.Red)
            {
                MainCardUrl = "https://shatterpointdb.com/media/arpd4hfq/star-wars-shatterpoint-b1-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/xf5l5vmw/star-wars-shatterpoint-b1-abilities.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/bi4hxev0/b1-stance-card.png",
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
            var unit = new Unit("Asajj Ventress, Sith Assassin", "Asaji Ventress", UnitType.Primary, UnitCardColor.Red)
            {
                MainCardUrl = "https://shatterpointdb.com/media/vcsl0v33/star-wars-shatterpoint-asajj-ventress.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/gtbhclqv/star-wars-shatterpoint-asajj-ventress-abilities.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/4f3chjdq/star-wars-shatterpoint-asajj-ventress-stance-one.png",
                StanceCardUrl2 = "https://shatterpointdb.com/media/unhltw4d/star-wars-shatterpoint-asajj-ventress-stance-two.png",
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
            var unit = new Unit("Lord Maul", "Maul", UnitType.Primary, UnitCardColor.Red)
            {
                MainCardUrl = "https://shatterpointdb.com/media/klehavye/swp01_maul_unit_article-1.png?height=600&v=1d978862f118b50",
                AbilityCardUrl = "https://shatterpointdb.com/media/i3vdw20w/maulabilities.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/3jxhjwvb/maulstance2.png",
                StanceCardUrl2 = "https://shatterpointdb.com/media/kkgn3wv2/maulstance1.png",
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
            var unit = new Unit("Gar Saxon, Merciless Commander", "Gar Saxon", UnitType.Secondary, UnitCardColor.Red)
            {
                MainCardUrl = "https://shatterpointdb.com/media/sp4njwnf/star-wars-shatterpoint-gar-saxon-character-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/ffmjwwbz/star-wars-shatterpoint-gar-saxon-abilities.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/xu1pp1jl/star-wars-shatterpoint-gar-saxon-stance.png",
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
            var unit = new Unit("Mandalorian Super Commandos", "", UnitType.Support, UnitCardColor.Red)
            {
                MainCardUrl = "https://shatterpointdb.com/media/hdxbgbol/star-wars-shatterpoint-mandalorian-super-commando-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/fzcj52gl/star-wars-shatterpoint-mandalorian-super-commandos-abilities.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/umplqvvr/star-wars-mandalorian-super-commandos-stance.png",
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
            var unit = new Unit("General Anakin Skywalker", "Anakin Skywalker", UnitType.Primary, UnitCardColor.Blue)
            {
                MainCardUrl = "https://shatterpointdb.com/media/nn3k0her/starwarsshatterpointanakinskywalker.png?height=600&v=1d978866fce1d70",
                AbilityCardUrl = "https://shatterpointdb.com/media/kvroyyyq/starwarsshatterpointanakinskywalkerabilities.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/zf4bstny/starwarsshatterpointanakinskywalkerstanceone.png",
                StanceCardUrl2 = "https://shatterpointdb.com/media/htydlen3/starwarsshatterpointanakinskywalkerstancetwo.png",
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
                        Text = "After a *melee* attack targeting a character in this Unit is resolved, this Unit may use this ability. If the attack roll contained one or more *failure* results, the attacking Unit suffers *damage**damage*.",
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

        public static Unit CaptainRex()
        {
            var unit = new Unit("CC-7567 Captain Rex", "CC-7567", UnitType.Secondary, UnitCardColor.Blue)
            {
                MainCardUrl = "https://shatterpointdb.com/media/w3ieriga/shatterpointrexunit.png?height=600&v=1d9788610a5ea80",
                AbilityCardUrl = "https://shatterpointdb.com/media/ecyhahod/shatterpointrexabilities.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/cwol20ni/shatterpointrexstance.png",
                KeyWords = new List<string> { KeyWords._501ST, KeyWords.GalacticRepublic, KeyWords.CloneTrooper },

            };
            unit.Abilities = new List<Ability>()
            {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Get a move on, soldier",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, choose a character in this Unit or another allied Galactic Republic character. The chosen character may *dash* and may gain *hunker*.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                KeyWords = new List<string>()
                                {
                                    "Galactic Republic"
                                }
                            }
                        },
                        Timing = new() { Timing.Start }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Defensive maneuver",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *dash*. If any characters *dash*, this unit gains *hunker*.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "I'm always first, kid",
                        Type = AbilityType.Reactive,
                        Cost = 1,
                        Text = "If this Unit is not Wounded, after an allied Clone Trooper Supporting Unit within *range*3 of this Unit makes a combat action, this Unit may use this ability. One character in this Unit may *dash*. If it does, it may make a 5 dice *melee* or *ranged* attack targeting one of the same enemy characters within *range* and LOS.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                KeyWords = new List<string>()
                                {
                                    KeyWords.CloneTrooper
                                },
                                Name = null,
                                Type = UnitType.Support
                            }
                        },
                        Timing = new() { Timing.AnotherActive }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Bring it on, clankers",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "After an allied Clone Trooper unit within *range*3 of this Unit gains *hunker*, one character in that Unit may *heal*.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                KeyWords = new List<string>()
                                {
                                    KeyWords.CloneTrooper
                                },
                                Name = null,
                                Type = null
                            }
                        },
                        Timing = new() { Timing.Active, Timing.AnotherActive }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Brothers in arms",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "While this Unit has one or more *hunker*, characters in this Unit have Steadfast.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Targeted }
                    }
            };
            return unit;
        }

        public static Unit _501StCloneTroopers()
        {
            var unit = new Unit("CC501st Clone Troopers", "", UnitType.Support, UnitCardColor.Blue)
            {
                MainCardUrl = "https://shatterpointdb.com/media/olaptf5u/shatterpoint501unit.png?height=600&v=1d978861b7a7020",
                AbilityCardUrl = "https://shatterpointdb.com/media/rtnnk45u/shatterpoint501abilities.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/wv2bnq24/shatterpoint501stance.png",
                KeyWords = new List<string> { KeyWords._501ST, KeyWords.GalacticRepublic, KeyWords.CloneTrooper },

            };
            unit.Abilities = new List<Ability>()
            {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Defensive Maneuver",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *dash*. If any characters *dash*, this Unit gains *hunker*.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Coordinated fire: [strain]",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When a character in another allied Galactic Republic Unit makes an attack as part of a combat action, before dice are rolled, this Unit may use this ability. If the targeted character is within *range*5 of a character in this Unit, the target Unit gains *strained*.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                KeyWords = new List<string>()
                                {
                                    "Galactic Republic"
                                }
                            }
                        },
                        Timing = new() { Timing.AnotherActive }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Brother in arms",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "While this Unit has one or more *hunker*, characters in this Unit have Steadfast.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Targeted }
                    }

            };
            return unit;
        }

        public static Unit AhsokeJediNoMore()
        {
            var unit = new Unit("Ahsoka Tano, Jedi no more", "Ahsoka", UnitType.Primary, UnitCardColor.Blue)
            {
                MainCardUrl = "https://shatterpointdb.com/media/os1lmren/swp01_ahsoka_unit_article-1.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/lzzju4ow/swp01_ahsoka_unit_article-2.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/lbfpcqyb/swp01_ahsoka_stance_article-2.png",
                StanceCardUrl2 = "https://shatterpointdb.com/media/mwkpmor3/swp01_ahsoka_stance_article-1.png",
                KeyWords = new List<string> { KeyWords.ForceUser, KeyWords.GalacticRepublic },

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
                        Name = "What's the matter, too fast for you?",
                        Type = AbilityType.Reactive,
                        Cost = 2,
                        Text = "When a character in this Unit would suffer *damage* from a *melee* attack, this Unit may use this ability. This Unit suffers half the *damage* in the Damage Pool. The attacking Unit suffers the remaining *damage*",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Targeted }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Deflect",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After a *melee* attack targeting a character in this Unit is resolved, this Unit may use this ability. If the attack roll contained one or more *failure* results, the attacking Unit suffers *damage**damage*.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Targeted }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Fierce Protector",
                        Type = AbilityType.Identity,
                        Cost = 0,
                        Text = "When an enemy character Wounds another allied Unit, after the effect is resolved, one character in this Unit may *advance* toward the enemy character that caused the effect. Then, the character that moved may *heal**heal**heal* or, if that character is Engaged with the enemy character, it may make a 5 dice *melee* attack targeting that enemy character.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Opponent, Timing.AlliedTargeted }
                    },

            };
            return unit;
        }

        public static Unit BoKatanKryze()
        {
            var unit = new Unit("Bo-Katan Kryze", "Bo-Katan", UnitType.Secondary, UnitCardColor.Blue)
            {
                MainCardUrl = "https://shatterpointdb.com/media/uh5b3qvr/star-wars-shatterpoint-bo-katan-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/rjph4i5n/star-wars-shatterpoint-bo-katan-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/v2qpb3kj/star-wars-shatterpoint-bo-katan-stance-card.png",
                KeyWords = new List<string> { KeyWords.ClanKryze, KeyWords.Mandalorian, KeyWords.NiteOwls },

            };
            unit.Abilities = new List<Ability>()
            {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Pride of the Mandalore",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, choose another allied Mandalorian character. The chosen character may *jump*.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                KeyWords = new List<string>()
                                {
                                    KeyWords.Mandalorian
                                }
                            }
                        },
                        Timing = new() { Timing.Start }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Jet pack",
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
                        Name = "Mandalorians are stronger together",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After this Unit makes a move action, it may use this ability. If a character in this Unit is within *range*2 of another allied Mandalorian character, this Unit immediately makes a focus action.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                KeyWords = new List<string>()
                                {
                                    KeyWords.Mandalorian
                                }
                            }
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Mandalore will survive",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "After this Unit makes a focus action, one character in this Unit may *dash* and *heal**heal*.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Some of us serve a higher purpose",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Allied Madalorian characters within *range*3 of this Unit that are contesting one or more Active objectives have Protection and Steadfast.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                KeyWords = new List<string>()
                                {
                                    KeyWords.Mandalorian
                                }
                            }
                        },
                        Timing = new() { Timing.Targeted, Timing.Opponent}
                    }

            };
            return unit;
        }

        public static Unit ClanKryzeMandalorians()
        {
            var unit = new Unit("Clan Kryze Mandalorians", "", UnitType.Support, UnitCardColor.Blue)
            {
                MainCardUrl = "https://shatterpointdb.com/media/gptniics/star-wars-shatterpoint-kryze-mandos-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/1s0eunhx/star-wars-shatterpoint-kryze-mandos-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/ggfiaj3j/star-wars-shatterpoint-kryze-mandos-stance-card.png",
                KeyWords = new List<string> { KeyWords.ClanKryze, KeyWords.Mandalorian, KeyWords.DeathWatch, KeyWords.Trooper },

            };
            unit.Abilities = new List<Ability>()
            {
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Jet pack",
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
                        Name = "Mandalorians are stronger together",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After this Unit makes a move action, it may use this ability. If a character in this Unit is within *range*2 of another allied Mandalorian character, this Unit immediately makes a focus action.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                KeyWords = new List<string>()
                                {
                                    KeyWords.Mandalorian
                                }
                            }
                        },
                        Timing = new() { Timing.Active }
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Helmet Visor",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit have Sharpshooter [1].",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = new() { Timing.Active }
                    }
            };
            return unit;
        }
    }
}
