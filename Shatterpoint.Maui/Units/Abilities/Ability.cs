namespace Shatterpoint.Maui.Units.Abilities
{
    public class Ability
    {
        public Ability(string weilderPp)
        {
            WeilderProfilePicture = weilderPp;
        }

        public string Weilder { get; set; }
        public string WeilderProfilePicture { get; set; }
        public string Name { get; set; }
        public AbilityType Type { get; set; }
        public int Cost { get; set; }
        public string Text { get; set; }
        public List<Synergy> Synergies { get; set; }
        public List<Timing> Timing { get; set; }
    }
}
