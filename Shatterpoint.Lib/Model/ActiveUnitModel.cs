using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Model
{
    public class ActiveUnitModel
    {
        public Unit ActiveUnit { get; set; }
        public List<Ability> CurrentActivationSynergies { get; set; } = new List<Ability>();
        public List<Ability> GettingTargetedSynegies { get; set; } = new List<Ability>();
    }
}
