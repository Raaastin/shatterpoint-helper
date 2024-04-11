namespace Shatterpoint.Lib.Units.Abilities
{
    /// <summary>
    /// Timing for ability
    /// </summary>
    public enum Timing
    {
        /// <summary>
        ///  When the activation starts
        /// </summary>
        Start, 
        /// <summary>
        /// During the turn this unit is activated
        /// </summary>
        Active, 
        /// <summary>
        /// During the turn an ally is activated
        /// </summary>
        AnotherActive,
        /// <summary>
        /// When the unit is targeted
        /// </summary>
        Targeted,
        /// <summary>
        /// At any time during the opponent's turn
        /// </summary>
        Opponent, 
        /// <summary>
        /// At the end of activation
        /// </summary>
        End
    }
}
