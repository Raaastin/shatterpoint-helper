namespace Shatterpoint.Lib.Units.Abilities
{

    /// <summary>
    /// Ability synergies
    /// </summary>
    public class Synergy
    {
        /// <summary>
        /// When the ability has synergy with a named unit
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// When the ability has synergy with a specific unit type
        /// </summary>
        public UnitType? Type{ get; set; }
        /// <summary>
        /// When the ability has synergy with some keywords
        /// </summary>
        public List<string> KeyWords { get; set; }
    }
}
