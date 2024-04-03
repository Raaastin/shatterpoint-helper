using ShatterpointReferences.Units;
using ShatterpointReferences.Units.Abilities;

namespace ShatterpointReferences.Services
{
    public static class StartSetFactory
    {

        public static Unit Kalani()
        {
            return new Unit()
            {
                Name = "Kalani, Super Tactical Robot",
                UniqueName = "Kalani",
                Type = UnitType.Secondary,
                KeyWords = new List<string> { KeyWords.BattleDroid, KeyWords.Droid, KeyWords.SeparatistAlliance },
                Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Name = "Roger, Roger",
                        Type = AbilityType.Automatic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, each allied Battle Droid Supporting character withing 4 of a character in this Unit may dash",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = UnitType.Support,
                                KeyWords = new List<string> { KeyWords.BattleDroid }
                            }
                        },
                        Timing = Timing.Start
                    },
                    new Ability()
                    {
                        Name = "Tactical Network",
                        Type = AbilityType.Active,
                        Cost = 0,
                        Text = "Chose another allied Battle Droid character within 4. The chosen Character may dash, then may gain Crouch, remove one condition from itself, or make a 5 dice attack",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = new List<string> { KeyWords.BattleDroid }
                            }
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "Target, Concentrate All Firepower",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When an allied Battle Droid character makes an attack, if the targeted character is withing 4 of one or more other allied Battle Droid characters, the attacking character adds 1 die to its attack roll.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = new List<string> { KeyWords.BattleDroid }
                            }
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "Complete Analysis",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When you spend 1F to place this Unit's Order Card in reserve, spend 1 less F",
                        Synergies = new List<Synergy>(),
                        Timing = Timing.Start
                    }
                }
            };
        }

        public static Unit B1BAttleDroids()
        {
            return new Unit()
            {
                Name = "B1 Battle Droids",
                UniqueName = "",
                Type = UnitType.Support,
                KeyWords = new List<string> { KeyWords.BattleDroid, KeyWords.Droid, KeyWords.SeparatistAlliance, KeyWords.Trooper },
                Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Name = "Combat A.I. Protocols",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After an allied Battle Droid Unit makes a combat action, choose one of the targeted characters that is within 4 of all character in this Unit if able. the chosen character gains Constrain or Exposed.",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = new List<string> { KeyWords.BattleDroid }
                            }
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "Well, I Guess I'm in Charge Now",
                        Type = AbilityType.Automatic,
                        Cost = 0,
                        Text = "When this Unit's Order Card would be placed in reserve, it's controlling player may place it on the bottom of their Order Deck instead",
                        Synergies = new List<Synergy>(),
                        Timing = Timing.Start
                    },
                    new Ability()
                    {
                        Name = "I Hate This Job",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "While a character in this Unit is contesting one or more Active objectives, it has protection",
                        Synergies = new List<Synergy>(),
                        Timing = Timing.Targeted
                    }
                }
            };
        }

        public static Unit AsajiVentress()
        {
            return new Unit()
            {
                Name = "Asaji Ventress, Sith Assassin",
                UniqueName = "Asaji Ventress",
                Type = UnitType.Primary,
                KeyWords = new List<string> { KeyWords.SeparatistAlliance },
                Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Name = "Dathomirian Dexterity",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may Jump. This Unit may use this ability two times during its activation",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "Force Push",
                        Type = AbilityType.Active,
                        Cost = 2,
                        Text = "Choose a character in this Unit and an enemy character within 3 of that character. Push the choosen enemy character 3 away from the choosen allied character",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "Riposte",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After a melee attack targetting a character in this Unit is resolved, this Unit may use this ability. If the attack roll contained one or more Fail results, the attacking Unit suffers 2D",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Targeted
                    },
                    new Ability()
                    {
                        Name = "Slip Away",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When another Dathomirian or Separatist Alliance character targets an enemy character that is Engaged with one of more characters in this Unit with an attackn this Unit may use this ability. One character in this Unit that is Engaged with the target character may immediately repos. If it does, this unit gains Crouch",
                        Synergies = new List<Synergy>()
                        {
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = new List<string>() { KeyWords.SeparatistAlliance, KeyWords.Dathomirian }
                            }
                        },
                        Timing = Timing.AnotherActive
                    },
                    new Ability()
                    {
                        Name = "Sith Assassin",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When a character in this Unit Wounds an enemy Unit, after the effect is resolved, that carachter may heal 3. If it Wounded a Primary Unit or Secondary Unit, it may also more or jump. If it Wounder a primary Unit, refresh 2F.",
                        Synergies = new List<Synergy>()
                        {

                        },
                        Timing = Timing.Active
                    }
                }
            };
        }

        public static Unit LordMaul()
        {
            return new Unit()
            {
                Name = "Lord Maul",
                UniqueName = "Maul",
                Type = UnitType.Primary,
                KeyWords = new List<string> { KeyWords.Dathomirian, KeyWords.ForceUser, KeyWords.Scoundrel, KeyWords.ShadowCollective },
                Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Name = "Force Speed",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may move.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "There is No Place to Run",
                        Type = AbilityType.Active,
                        Cost = 2,
                        Text = "Choose a character in this Unit and an enemy character within 3 of that character. Pull the chosen enemy character 2 Toward the chosen allied character. Then the chosen enemy character gains Exposed",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "Revent, I Myst Have Revent",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When this Unit is Wounded by a melee attack, after the attack is resolved, one character in this Unit may immediately dash and make a 5 dive melee attack targeting the character that Wounded it.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Targeted
                    },
                    new Ability()
                    {
                        Name = "Sustained By Rage",
                        Type = AbilityType.Automatic,
                        Cost = 0,
                        Text = "While this Unit is not Wounded, when it would spend F to use an ability, it may suffer D equal to the cost of the ability instead. For every 3D this Unit has, characters in this Unit add 1 die to their melee Attack rolls. For each injured token, this Unit has, characters in this Unit add 3 dice to their melee attack rolls.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Active
                    }
                }
            };
        }

        public static Unit GarSaxon()
        {
            return new Unit()
            {
                Name = "Gar Saxon, Merciless Commander",
                UniqueName = "Gar Saxon",
                Type = UnitType.Secondary,
                KeyWords = new List<string> { KeyWords.Mandalorian, KeyWords.ShadowCollective, KeyWords.SuperCommando},
                Abilities = new List<Ability>()
                {
                    new Ability()
                    {
                        Name = "Pride of the Mandalor",
                        Type = AbilityType.Automatic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, choose another allied Mandalorian character. THe chosen character may jump.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Start
                    },
                    new Ability()
                    {
                        Name = "Jet Pack",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may jump.",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "Mandalorians are Stronger Together",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "After this Unit makes a move action, it may use this ability. If a character in this Unit is withing 2 of another allied Mandalorian character, this Unit immediately makes a focus action",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "I've Got You In My Sights",
                        Type = AbilityType.Permanent,
                        Cost = 0,
                        Text = "Characters in this Unit have Sharpshooter(2). When a character in this Unit makes a ranged attack, the target does not benefit from Cover. After this Unit Makes a focus action, it gains Crouch",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Active
                    },
                    new Ability()
                    {
                        Name = "Pack Hunter",
                        Type = AbilityType.Permanent,
                        Cost = 0,
                        Text = "When a character in this Unit makes a melee attack targeting an enemy character that is Engaged with another allied Mandalorian character, it adds 2 dice to the attack roll",
                        Synergies = new List<Synergy>()
                        {
                        },
                        Timing = Timing.Active
                    }
                }
            };
        }
    }
}
