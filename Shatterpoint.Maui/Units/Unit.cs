using Shatterpoint.Maui.Units.Abilities;

namespace Shatterpoint.Maui.Units
{
    public class Unit
    {
        /// <summary>
        /// Name of the unit
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Profile picture of the unit
        /// </summary>
        public string ProfilePicture { get; set; }
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
        public List<Ability> Abilities { get; set; }

        /// <summary>
        /// List of keyword of this unit
        /// </summary>
        public List<string> KeyWords { get; set; }
    }
}
