using Shatterpoint.Maui.Units;
using Shatterpoint.Maui.Units.Abilities;

namespace Shatterpoint.Maui.Models
{
    public class ActiveUnitModel
    {
        public Unit ActiveUnit { get; set; }
        public List<Ability> CurrentActivationSynergies { get; set; } = new List<Ability>();
    }
}
