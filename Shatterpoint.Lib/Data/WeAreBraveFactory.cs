using Shatterpoint.Lib.Extensions;
using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Services
{
    /// <summary>
    /// Factory for Amidala
    /// </summary>
    public static class WeAreBraveFactory
    {
        public static string warbandname = "We Are Brave";
        public static Unit QueenPadmé()
        {
            var unit = new Unit("Queen Padmé Amidala", "Padmé Amidala", UnitType.Primary, UnitCardColor.Blue, 8, 9, 3, 3)
            {
                MainCardUrl = "https://shatterpointdb.com/media/g2hnmz1n/shatterpoint-padme-amidala-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/w0akessn/shatterpoint-padme-amidala-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/0lvnicoy/shatterpoint-padme-amidala-stance-onecard.png",
                StanceCardUrl2 = "https://shatterpointdb.com/media/cv0k4bme/shatterpoint-padme-amidala-stance-two-card.png",
                KeyWords = [KeyWords.GalacticRepublic],
                WarBandName = warbandname
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Royal Command",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Choose an allied Galactic Republic Unit. Each character in the chosen Unit may *advance*.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = [KeyWords.GalacticRepublic]
                            }
                        ],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Coordinated Fire: *damage**damage*".ToRawHtmlDescription(),
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When a character in an allied Handmaiden Unit makes an attack as part of a combat action, before dice are rolled, this Unit may use this ability. If the targeted character is within *range*5 of a character in this Unit, the target Unit suffers *damage**damage*.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = [KeyWords.Handmaiden]
                            }
                        ],
                        Timing = [Timing.AnotherActive]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Crack Shot",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit have Sharpshooter [2]. When this Unit makes a focus action, each character in this Unit may *dash*.",
                        Synergies = [],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Servant of the People",
                        Type = AbilityType.Identity,
                        Cost = 0,
                        Text = "While this Unit is not Wounded and while one or more characters in this Unit are contesting an Active objective, if this Unit's Active Stance <b>is Faith in Diplomacy</b>, allied Galactic Republic Supporting characters can contest the same Active objective, even while they are Wounded.<br/></br>While this Unit is not Wounded, if this Unit's Active Stance is <b>Aggressive Negotiations</b>, allied Galactic Republic Supporting characters within *range*4 add 1 die to their attack rolls.",
                        Synergies = [
                            new Synergy(){
                                Type = UnitType.Support,
                                KeyWords = [KeyWords.GalacticRepublic]
                            }],
                        Timing = [Timing.Active, Timing.AnotherActive, Timing.Opponent]
                    }
                ];
            return unit;
        }

        public static Unit Sabé()
        {
            var unit = new Unit("Sabé, Royal Bodyguard", "Sabé", UnitType.Secondary, UnitCardColor.Blue, 4, 9, 2)
            {
                MainCardUrl = "https://shatterpointdb.com/media/yexheddv/shatterpoint-sabe-unit-card.png?height=600&v=1d9d65d0ca039b0",
                AbilityCardUrl = "https://shatterpointdb.com/media/zqxg2tvz/shatterpoint-sabe-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/nuddiknt/shatterpoint-sabe-stance-card.png",
                KeyWords = [KeyWords.GalacticRepublic, KeyWords.Handmaiden],
                WarBandName = warbandname
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Loyal Protectors",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, each allied Handmaiden character may *dash* Toward an allied Primary character.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = [KeyWords.GalacticRepublic]
                            }
                        ],
                        Timing = [Timing.Start]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Expose Flank ",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *climb*. If any character ends this movement at a higher elevation than it began, characters in this Unit have Sharpshooter [1] until the end of the Turn and this Unit immediately makes a focus action.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = []
                            }
                        ],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Coordinated Assault: *dash*".ToRawHtmlDescription(),
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When a character in another allied Galactic Republic Unit makes an attack as part of a combat action, before dice are rolled, this Unit may use this ability. If the targeted character is within *range*5 of a character in this Unit, one character in this Unit may *dash*.",
                        Synergies = [
                            new Synergy(){
                                KeyWords = [KeyWords.GalacticRepublic]
                            }],
                        Timing = [Timing.AnotherActive]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Bodyguard",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Allied Primary characters within *range*2 and allied Secondary characters within *range*2 of a character in this Unit have Cover [1].",
                        Synergies = [
                            new Synergy(){
                                Type = UnitType.Primary,
                                KeyWords = []
                            },
                            new Synergy(){
                                Type = UnitType.Secondary,
                                KeyWords = []
                            }],
                        Timing = [Timing.Targeted, Timing.AlliedTargeted]
                    }
                ];
            return unit;
        }

        public static Unit NabooHandmainden()
        {
            var unit = new Unit("Naboo Royal Handmaidens", "", UnitType.Support, UnitCardColor.Blue, 4, 8, 2)
            {
                MainCardUrl = "https://shatterpointdb.com/media/c4xfmpuj/shatterpoint-haindmaden-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/cofheu2y/shatterpoint-haindmaden-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/miyhunki/shatterpoint-haindmaden-stance-card.png",
                KeyWords = [KeyWords.GalacticRepublic, KeyWords.Handmaiden, KeyWords.Trooper],
                WarBandName = warbandname
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Expose Flank",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *climb*. If any character ends this movement at a higher elevation than it began, characters in this Unit have Sharpshooter [1] until the end of the Turn and this Unit immediately makes a focus action.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = []
                            }
                        ],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Coordinated Fire: *disarmed*".ToRawHtmlDescription(),
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When a character in an allied Galactic Republic Unit makes an attack as part of a combat action, before dice are rolled, this Unit may use this ability. If the targeted character is within *range*5 of a character in this Unit, the target Unit suffers *disarmed*.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = [KeyWords.GalacticRepublic]
                            }
                        ],
                        Timing = [Timing.Active, Timing.AnotherActive]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Intercede",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "While this Unit is not Wounded, enemy characters Engaged with one or more characters in this Unit cannot target allied Primary characters or allied Secondary characters with attacks.",
                        Synergies = [
                            new Synergy(){
                                Type = UnitType.Primary,
                                KeyWords = []
                            },
                            new Synergy(){
                                Type= UnitType.Secondary,
                                KeyWords = []
                            }],
                        Timing = [Timing.AlliedTargeted]
                    }
                ];
            return unit;
        }
    }
}

