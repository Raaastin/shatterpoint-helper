using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Model
{
    /// <summary>
    /// Data model when activating a unit
    /// </summary>
    public class ActiveUnitModel
    {
        /// <summary>
        /// Current active unit
        /// </summary>
        public Unit ActiveUnit { get; set; }
        /// <summary>
        /// All abilities available when this unit is active
        /// </summary>
        public List<Ability> CurrentActivationSynergies { get; set; } = [];
        /// <summary>
        /// All abilities available when this unit is targeted
        /// </summary>
        public List<Ability> GettingTargetedSynegies { get; set; } = [];
    }
}
