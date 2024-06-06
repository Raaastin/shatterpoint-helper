using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Units
{
    /// <summary>
    /// Represent a unit
    /// </summary>
    public class Unit
    {
        public Unit(string name, string uniqueName, UnitType type, UnitCardColor cardColor, int point, int wound, int injure, int force = 0)
        {
            Name = name;
            UniqueName = uniqueName;
            Type = type;
            CardColor = cardColor;
            if (type is UnitType.Primary)
            {
                SP = point;
            }
            else
            {
                PC = point;
            }
            InjurePool = injure;
            WoundPool = wound;
            Force = force;
        }

        /// <summary>
        /// WarBandName
        /// </summary>
        public string WarBandName { get; set; }

        /// <summary>
        /// Era
        /// </summary>
        public string Era { get; set; }

        /// <summary>
        /// Allowed injured token before being dead
        /// </summary>
        public int InjurePool { get; set; }

        /// <summary>
        /// Allowed damage before being injured
        /// </summary>
        public int WoundPool { get; set; }

        /// <summary>
        /// Force points
        /// </summary>
        public int Force { get; set; }

        /// <summary>
        /// SP
        /// </summary>
        public int SP { get; set; } = -1;

        /// <summary>
        /// PC
        /// </summary>
        public int PC { get; set; } = -1;

        /// <summary>
        /// Name of the unit
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Url of main card
        /// </summary>
        public string MainCardUrl { get; set; }

        /// <summary>
        /// Url of ability card
        /// </summary>
        public string AbilityCardUrl { get; set; }

        /// <summary>
        /// Url of stance card
        /// </summary>
        public string StanceCardUrl1 { get; set; }

        /// <summary>
        /// Url of stance card 2 (may be null or empty)
        /// </summary>
        public string StanceCardUrl2 { get; set; }

        /// <summary>
        /// Top offset for profile picture
        /// </summary>data
        public string Top { get; set; } = "-15px";

        /// <summary>
        /// left offset for profile picture
        /// </summary>
        public string Left { get; set; } = "-670px";

        /// <summary>
        /// Unique name of the unit
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// Type of unit
        /// </summary>
        public UnitType Type { get; set; }

        /// <summary>
        /// Type of unit
        /// </summary>
        public UnitCardColor CardColor { get; set; }

        /// <summary>
        /// List of abilities
        /// </summary>
        public List<Ability> Abilities { get; set; } = new List<Ability>();

        /// <summary>
        /// List of keyword of this unit
        /// </summary>
        public List<string> KeyWords { get; set; } = new List<string>();
    }
}
