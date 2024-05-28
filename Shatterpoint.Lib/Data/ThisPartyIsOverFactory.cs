using Shatterpoint.Lib.Extensions;
using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Services
{
    /// <summary>
    /// Factory for Mace Windu
    /// </summary>
    public static class ThisPartyIsOverFactory
    {
        private const string warbandname = "This Party Is Over";

        public static Unit MaceWindu()
        {
            var unit = new Unit("Jedi Master Mace Windu", "Mace Windu", UnitType.Primary, UnitCardColor.Blue, 6, 11, 3, 4)
            {
                MainCardUrl = "https://shatterpointdb.com/media/k3cdg1ey/star-wars-shatterpoint-mace-windu-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/gs1ktczl/star-wars-shatterpoint-mace-windu-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/ho1k44sh/star-wars-shatterpoint-mace-windu-stance-two-card.png",
                StanceCardUrl2 = "https://shatterpointdb.com/media/5jnbib52/star-wars-shatterpoint-mace-windu-stance-one-card.png",
                KeyWords = [KeyWords.ForceUser, KeyWords.GalacticRepublic, KeyWords.Jedi],
                WarBandName = warbandname
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Rush to Action",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's Activation, choose another allied Galactic Republic Unit. Each character in this Unit and each character in the chosen Unit may *dash*.",
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
                        Name = "Tempered Agression",
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When a character in this Unit makes an attack, after all Attack Dice and Defense Dice have been rolled, this Unit may spend any number of *forceicon* to use this ability. Reroll one *failure* results in the attack roll for each *forceicon* spent.",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Shatterpoint",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When this Unit is chosen to activate with a Shatterpoint Card, if its Active Stance is <b>Form VII Vaapad</b>, it immediately makes a focus action and characters in this Unit have Impact [2] until the end of the Turn. <br/>If its Active Stance is <b>Jedi Master</b>, refresh *forceicon**forceicon* and one character in this Unit may *heal**heal**heal*.",
                        Synergies = null,
                        Timing = [Timing.Start]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "This party's over",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "While a character in this Unit is engaged, allied Galactic Republic characters within *range*5 have Steadfast and Protection.",
                        Synergies = [
                            new Synergy()
                            {
                                KeyWords = [KeyWords.GalacticRepublic]
                            }],
                        Timing = [Timing.Targeted, Timing.AlliedTargeted]
                    }
                ];
            return unit;
        }
        public static Unit CommanderPonds()
        {
            var unit = new Unit("CT-411 Commander Ponds", "CT-411", UnitType.Secondary, UnitCardColor.Blue, 3, 7, 2)
            {
                MainCardUrl = "https://shatterpointdb.com/media/p4rh33xl/star-wars-shatterpoint-commander-ponds-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/oxalgs52/star-wars-shatterpoint-commander-ponds-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/vqmlpyk5/star-wars-shatterpoint-commander-ponds-stance-card.png",
                KeyWords = [KeyWords.CloneCommando, KeyWords.CloneTrooper, KeyWords.GalacticRepublic],
                WarBandName = warbandname
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Charge",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, choose another allied Galactic Republic character. The chosen character may *dash*.",
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
                        Name = "Incoming",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Allied Clone Trooper Units within *range*3 that have one or more *hunker*, have Immunity [*exposed*].".ToRawHtmlDescription(),
                        Synergies =
                        [
                            new Synergy()
                            {
                                Name = null,
                                Type = null,
                                KeyWords = [KeyWords.CloneTrooper]
                            }
                        ],
                        Timing = [Timing.Targeted, Timing.AlliedTargeted, Timing.Active, Timing.AnotherActive]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Forward Scout",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When deploying a squad that includes this Unit, allied Clone Trooper Secondary characters and allied Clone Trooper Supporting characters may be placed within *range*2 of the first placed character from that squad's Primary Unit, instead of the normal *range*1.",
                        Synergies = [
                            new Synergy()
                            {
                                Type = UnitType.Secondary,
                                KeyWords = [KeyWords.CloneTrooper]
                            },
                            new Synergy()
                            {
                                Type = UnitType.Support,
                                KeyWords = [KeyWords.CloneTrooper]
                            }],
                        Timing = [Timing.Start]
                    }
                ];
            return unit;
        }
        public static Unit ArfTrooper()
        {
            var unit = new Unit("ARF Clone Troopers", "", UnitType.Support, UnitCardColor.Blue, 3, 7, 2)
            {
                MainCardUrl = "https://shatterpointdb.com/media/qiwogg4e/star-wars-shatterpoint-arf-clone-troopers-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/wwvnjxcc/star-wars-shatterpoint-arf-clone-troopers-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/f10hbmu2/star-wars-shatterpoint-arf-clone-troopers-stance-card.png",
                KeyWords = [KeyWords.CloneCommando, KeyWords.CloneTrooper, KeyWords.GalacticRepublic],
                WarBandName = warbandname
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Defensive Maneuver",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *dash*. If any characters *dash*, this Unit gains *hunker*.",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Coordinate Fire: *exposed*".ToRawHtmlDescription(),
                        Type = AbilityType.Reactive,
                        Cost = 0,
                        Text = "When a character in another allied Galactic Republic Unit makes an attack as part of a combat action, before dice are rolled, this Unit may use this ability. If the targeted character is within *range*5 of a character in this Unit, the target Unit gains *exposed*.",
                        Synergies =
                        [
                            new Synergy()
                            {
                                KeyWords = [KeyWords.GalacticRepublic]
                            }
                        ],
                        Timing = [Timing.AnotherActive]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Brothers in arms",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "While this Unit has one or more *hunker*, characters in this Unit have Steadfast.",
                        Synergies = null,
                        Timing = [Timing.Targeted]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Lay low",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When a character in this Unit rolls defense dice during a  attack, if this Unit has one or more , add [expertise] to the roll.",
                        Synergies = null,
                        Timing = [Timing.Targeted]
                    }
                ];
            return unit;
        }
    }
}
