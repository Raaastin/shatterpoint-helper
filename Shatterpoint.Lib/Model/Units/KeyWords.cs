﻿namespace Shatterpoint.Lib.Units
{
    /// <summary>
    /// Hard coded const for keywords
    /// </summary>
    public class KeyWords
    {
        public const string BattleDroid = "Battle Droid";
        public const string Droid = "Droid";
        public const string SeparatistAlliance = "Separatist Alliance";
        public const string Trooper = "Trooper";

        public const string Dathomirian = "Dathomirian";
        public const string NightSister = "Nightsister";
        public const string ForceUser = "Force User";

        public const string Scoundrel = "Scoundrel";
        public const string ShadowCollective = "Shadow Collective";
        public const string Mandalorian = "Mandalorian";
        public const string SuperCommando = "Super Commando";

        public const string _501ST = "501ST";
        public const string GalacticRepublic = "Galactic Republic";
        public const string Jedi = "Jedi";
        public const string CloneTrooper = "Clone Trooper";

        public const string ClanKryze = "Clan Kryze";
        public const string NiteOwls = "Nite Owls";

        public const string DeathWatch = "Death Watch";
        public const string CloneCommando = "Clone Commando";

        public const string Handmaiden = "Handmaiden";
        public const string B1 = "B1";
        public const string B2 = "B2";

        public const string GalacticEmpire = "Galactic Empire";
        public const string Sith = "Sith";
        public const string Stormtrooper = "Stormtrooper";
        public const string DeathTrooper = "Death Trooper";

        public const string BountyHunter = "Bounty Hunter";
        public const string Mercenary = "Mercenary";

        /// <summary>
        /// All available keywords
        /// </summary>
        public static List<string> KeyWordsList = new()
        {
            BattleDroid, Droid, SeparatistAlliance,
            Dathomirian,
            NightSister, ForceUser, Scoundrel, ShadowCollective, Mandalorian, SuperCommando,
            _501ST, GalacticRepublic, Jedi, CloneTrooper, ClanKryze, NiteOwls, DeathWatch, Trooper,
            CloneCommando,
            Handmaiden, B1, B2,
            GalacticEmpire, Sith, Stormtrooper,
            DeathTrooper, BountyHunter, Mercenary
        };
    }
}
