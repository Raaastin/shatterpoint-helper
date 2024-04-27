using Shatterpoint.Lib.Extensions;
using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Services
{
    /// <summary>
    /// Factory for Starter Box
    /// </summary>
    public static class AppetiteForDestructionFactory
    {
        public static Unit Grievous()
        {
            var unit = new Unit("General Grievous", "General Grievous", UnitType.Primary, UnitCardColor.Red)
            {
                MainCardUrl = "https://shatterpointdb.com/media/fx4lex3u/star-wars-shatterpoint-grievous-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/5rda1caq/star-wars-shatterpoint-grievous-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/l2npxem1/star-wars-shatterpoint-grievous-stance-one-card.png",
                StanceCardUrl2 = "https://shatterpointdb.com/media/aifflby1/star-wars-shatterpoint-grievous-stance-two-card.png",
                KeyWords = [KeyWords.Droid, KeyWords.SeparatistAlliance],
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Onward",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, choose another allied Battle Droid character within *range*4. The chosen character may *dash*.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = [KeyWords.BattleDroid]
                            }
                        ],
                        Timing = [Timing.Start]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Scuttle",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Characters in this Unit have Scale until the end of the Turn. One character in this Unit may *dash*.",
                        Synergies = [],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "I have been trained in your Jedi Arts",
                        Type = AbilityType.Reactive,
                        Cost = 2,
                        Text = "After a *melee* attack made by a character in this Unit is resolved, this Unit may use this ability. Each enemy Unit that has one or more characters engaged with the attacker, except the defending Unit, suffers *damage**damage*.",
                        Synergies = [],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Appetite for Destruction",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "After this Unit makes a combat action, choose an allied Battle Droid supporting character within *range*3. The chosen character may *dash*. Then, that character may make a 5 dice attack targeting one of the same enemy characters within *range* and LOS.",
                        Synergies = [
                            new Synergy(){
                                Type = UnitType.Support,
                                KeyWords = [KeyWords.BattleDroid]
                            }],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Another fine addition to my collection",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When a character in this Unit Wounds an enemy Unit, after the effect is resolved, that character may *heal**heal*. Then, if the Wounded Unit was a Force User, refresh 2F.",
                        Synergies = [],
                        Timing = [Timing.Active]
                    }
                ];
            return unit;
        }

        public static Unit Kraken()
        {
            var unit = new Unit("Kraken, Super Tactical Droid", "Kraken", UnitType.Secondary, UnitCardColor.Red)
            {
                MainCardUrl = "https://shatterpointdb.com/media/30hehhkx/star-wars-shatterpoint-kraken-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/2knlge30/star-wars-shatterpoint-kraken-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/x01daqv1/star-wars-shatterpoint-kraken-stance-card.png",
                KeyWords = [KeyWords.BattleDroid, KeyWords.Droid, KeyWords.SeparatistAlliance],
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Do Not Let Them Escape",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's Activation, you may choose this Unit or an allied Battle Droid Supporting Unit. Each character in the chosen unit may *dash*.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = [KeyWords.BattleDroid]
                            }
                        ],
                        Timing = [Timing.Start]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Tactical Network",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Choose another allied Battle Droid character within *range*4. The chosen character may *dash*, then may gain *hunker*, remove one condition from itself, or make a 5 dice attack.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = [KeyWords.BattleDroid]
                            }
                        ],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Complete Analysis",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When you spend 1F to place this Unit's Order Card in reserve, spend one less F.",
                        Synergies = [],
                        Timing = [Timing.Start]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Conqueror's Resolve",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "While a character in this Unit is contesting one or more Active objectives, it has Protection and Steadfast.",
                        Synergies = [],
                        Timing = [Timing.Targeted]
                    }
                ];
            return unit;
        }

        public static Unit B2BAttleDroids()
        {
            var unit = new Unit("B2 Battle Droids", "", UnitType.Support, UnitCardColor.Red)
            {
                MainCardUrl = "https://shatterpointdb.com/media/dttcpher/star-wars-shatterpoint-b2-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/0xfnvtbi/star-wars-shatterpoint-b2-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/zrwakce5/star-wars-shatterpoint-b2-stance-card.png",
                KeyWords = [KeyWords.B2, KeyWords.BattleDroid, KeyWords.Droid, KeyWords.SeparatistAlliance, KeyWords.Trooper],
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Relentless Advance",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *dash*",
                        Synergies = [],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Saturation Fire",
                        Type = AbilityType.Reactive,
                        Cost = 1,
                        Text = "When a character in this Unit targets an enemy character that is contesting one or more Active objectives with an attack, this Unit may use this ability. Add 2 dice to the attack roll",
                        Synergies = [],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Enhanced Blast Armor",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit have Protection.",
                        Synergies = [],
                        Timing = [Timing.Targeted]
                    }
                ];
            return unit;
        }
    }
}

