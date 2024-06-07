using Shatterpoint.Lib.Extensions;
using Shatterpoint.Lib.Model.Units;
using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Services
{
    /// <summary>
    /// Factory for Moff
    /// </summary>
    public static class YouHaveSomethingIWantFactory
    {
        public static string warbandname = "You Have Something I Want";

        public static Unit Moff()
        {
            var unit = new Unit("Moff Gideon", "Moff Gideon", UnitType.Primary, UnitCardColor.Black, 8, 10, 3, 3)
            {
                MainCardUrl = "https://shatterpointdb.com/media/tqvf04co/shatterpoint-moff-gideon-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/qiolefrk/shatterpoint-moff-gideon-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/1ilflaom/shatterpoint-moff-gideon-stance-2-card.png",
                StanceCardUrl2 = "https://shatterpointdb.com/media/uzokaxmd/shatterpoint-moff-gideon-stance-1-card.png",
                KeyWords = [KeyWords.GalacticEmpire, KeyWords.Scoundrel],
                WarBandName = warbandname,
                Era = [Era.GalacticCivilWar, Era.TheNewRepublic]
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Smug Determination",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, choose an allied Galactic Empire character within  4. Each character in this Unit and the chosen character may *dash*.",
                        Synergies = [new Synergy()
                        {
                            KeyWords = [KeyWords.GalacticEmpire]
                        }],
                        Timing = [Timing.Start]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Long Live the Empire",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Choose an Active objective and an allied Galactic Empire Supporting Unit. One character in the chosen Unit may *reposition* Toward that objective. Then the chosen Unit suffers *damage**damage*. If this effect Wounds the chosen Unit, that Unit may remove one Wounded token, all *damage*, and one condition from itself. If it does, that Unit gains an Injured token.",
                        Synergies = [new Synergy()
                        {
                            Type = UnitType.Support,
                            KeyWords = [KeyWords.GalacticEmpire]
                        }],
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Assume that I know everything",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "When an opposing player would spend *forceicon* to place a Unit's Order Card in reserve, they must spend 1 additional *forceicon*.",
                        Synergies = null,
                        Timing = [Timing.Opponent]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "You have something I want",
                        Type = AbilityType.Identity,
                        Cost = 0,
                        Text = "When an allied Galactic Empire character performs a *melee* attack as part of a combat action, if the defender is contesting an Active objective that you do not control, add one die to the attack roll.\r\n\r\nAdditionally, when determining control of an Active objective that a character in this Unit is contesting, if there is a tie, this Unit's controlling player takes control of the objective.",
                        Synergies = [
                            new Synergy()
                            {
                                KeyWords = [KeyWords.GalacticEmpire]
                            }],
                        Timing = [Timing.Active, Timing.AnotherActive]
                    }
                ];
            return unit;
        }

        public static Unit Deathtooper()
        {
            var unit = new Unit("Death Trooper Escort", "", UnitType.Secondary, UnitCardColor.Black, 4, 9, 2)
            {
                MainCardUrl = "https://shatterpointdb.com/media/ipun0yn3/shatterpoint-death-trooper-escort-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/oxwf2ysp/shatterpoint-death-trooper-escort-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/of4pmlli/shatterpoint-death-trooper-escort-stance-card.png",
                StanceCardUrl2 = null,
                KeyWords = [KeyWords.DeathTrooper, KeyWords.GalacticEmpire, KeyWords.Stormtrooper],
                WarBandName = warbandname,
                Era = [Era.GalacticCivilWar, Era.TheNewRepublic]
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Imperial Efficiency",
                        Type = AbilityType.Tactic,
                        Cost = 0,
                        Text = "At the start of this Unit's activation, choose this Unit or an allied Galactic Empire Supporting Unit. Each character in the chosen Unit may *dash*. If the chosen Unit has any *damage*, each character in that Unit may instead *reposition*.",
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
                        Name = "Tactical advance",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *dash*. If any characters *dash*, this Unit immediately makes a focus action",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Disciplined ",
                        Type = AbilityType.Reactive,
                        Cost = 1,
                        Text = "After an attack targetting a character in this Unit is resolved, if this Unit is not Wounded, this Unit may use this ability. Each character in this Unit may  Toward an Active objective. After the move is resolved, is no characters in this Unit are Engaged, this Unit gains *hunker*.",
                        Synergies = [new Synergy()
                        {
                            KeyWords = [KeyWords.Stormtrooper]
                        }],
                        Timing = [Timing.Targeted]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Rigorous Training",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit have Protection and Sharpshooter[1].",
                        Synergies = null,
                        Timing = [Timing.Active, Timing.Targeted]
                    }
                ];
            return unit;
        }

        public static Unit DarkTrooper()
        {
            var unit = new Unit("Dark Troopers", "", UnitType.Support, UnitCardColor.Black, 4, 8, 2)
            {
                MainCardUrl = "https://shatterpointdb.com/media/ckfo10hn/shatterpoint-dark-trooper-unit-card.png",
                AbilityCardUrl = "https://shatterpointdb.com/media/sa2e45ux/shatterpoint-dark-trooper-abilities-card.png",
                StanceCardUrl1 = "https://shatterpointdb.com/media/hp3dxleo/shatterpoint-dark-trooper-stance-card.png",
                StanceCardUrl2 = null,
                KeyWords = [KeyWords.Droid, KeyWords.GalacticEmpire],
                WarBandName = warbandname,
                Era = [Era.GalacticCivilWar, Era.TheNewRepublic]
            };

            unit.Abilities =
                [
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Jump boots",
                        Type = AbilityType.Active,
                        Cost = 1,
                        Text = "Each character in this Unit may *jump*.",
                        Synergies = null,
                        Timing = [Timing.Active]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Coordinated Fire: *strained*".ToRawHtmlDescription(),
                        Type = AbilityType.Reactive,
                        Cost = 1,
                        Text = "When a character in another allied Galactic Empire Unit makes an attack as part of a combat action, before dice are rolled, this Unit may use this ability. If the targeted character is within *range*5 of a character in this Unit, the target Unit gains *strained*.",
                        Synergies = [new Synergy()
                        {
                            KeyWords = [KeyWords.GalacticEmpire]
                        }],
                        Timing = [Timing.AnotherActive]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Immovable",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit cannot be Pushed or Pulled by abilities.",
                        Synergies = null,
                        Timing = [Timing.Targeted]
                    },
                    new Ability()
                    {
                        Weilder = unit,
                        Name = "Unrelenting",
                        Type = AbilityType.Inate,
                        Cost = 0,
                        Text = "Characters in this Unit have Protection and Immunity[*pinned*].",
                        Synergies = null,
                        Timing = [Timing.Targeted]
                    }
                ];
            return unit;
        }
    }
}

