namespace Shatterpoint.Lib.Units.Abilities
{
    /// <summary>
    /// Ability model
    /// </summary>
    public class Ability
    {
        //public Ability(Unit weilder, string name, AbilityType abilityType, int cost)
        //{
        //    Weilder = weilder;
        //    Name = name;
        //    Type = abilityType;
        //    Cost = cost;
        //}

        public Unit Weilder { get; set; }
        public string Name { get; set; }
        public AbilityType Type { get; set; }
        public int Cost { get; set; }
        public string Text { get; set; }
        public List<Synergy> Synergies { get; set; } = new List<Synergy>();
        public List<Timing> Timing { get; set; } = new List<Timing>();
    }
}
