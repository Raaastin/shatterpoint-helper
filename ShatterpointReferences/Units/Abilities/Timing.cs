namespace ShatterpointReferences.Units.Abilities
{
    public enum Timing
    {
        /// <summary>
        ///  When the activation starts
        /// </summary>
        Start, 
        /// <summary>
        /// During the turn
        /// </summary>
        Active, 
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
