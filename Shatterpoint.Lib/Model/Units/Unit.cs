using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Units
{
    /// <summary>
    /// Represent a unit
    /// </summary>
    public class Unit
    {
        public Unit(string name, string uniqueName, UnitType type)
        {
            Name = name;
            UniqueName = uniqueName;
            Type = type;
        }

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
        public string Top { get; set; } = "-13px";

        /// <summary>
        /// left offset for profile picture
        /// </summary>
        public string Left { get; set; } = "-663px";

        /// <summary>
        /// Unique name of the unit
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// Type of unit
        /// </summary>
        public UnitType Type { get; set; }
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
