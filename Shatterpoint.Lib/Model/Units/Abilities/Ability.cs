namespace Shatterpoint.Lib.Units.Abilities
{
    /// <summary>
    /// Ability model
    /// </summary>
    public class Ability
    {
        public Unit Weilder { get; set; }
        public string Name { get; set; }
        public AbilityType Type { get; set; }
        public int Cost { get; set; }
        public string Text { get; set; }
        public List<Synergy> Synergies { get; set; }
        public List<Timing> Timing { get; set; }
    }
}
