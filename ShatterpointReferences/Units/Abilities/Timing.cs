namespace ShatterpointReferences.Units.Abilities
{
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
        /// In opponent's turn, when the unit is targeted
        /// </summary>
        Targeted, 
        /// <summary>
        /// At the end of activation
        /// </summary>
        End
    }
}
