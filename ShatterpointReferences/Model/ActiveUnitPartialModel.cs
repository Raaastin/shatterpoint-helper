using ShatterpointReferences.Units;
using ShatterpointReferences.Units.Abilities;

namespace ShatterpointReferences.Model
{
    public class ActiveUnitPartialModel
    {
        public Unit ActiveUnit { get; set; }
        public List<Ability> CurrentActivationSynergies { get; set; } = new List<Ability>();
    }
}
