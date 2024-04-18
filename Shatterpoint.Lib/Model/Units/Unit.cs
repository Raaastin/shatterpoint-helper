﻿using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Units
{
    /// <summary>
    /// Represent a unit
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// Name of the unit
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Profile picture of the unit
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// Top offset for profile picture
        /// </summary>data
        public string Top { get; set; } = "-13px";

        /// <summary>
        /// left offset for profile picture
        /// </summary>
        public string Left { get; set; } = "-663px";

        /// <summary>
        /// Unique name of the unit
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// Type of unit
        /// </summary>
        public UnitType Type { get; set; }
        /// <summary>
        /// List of abilities
        /// </summary>
        public List<Ability> Abilities { get; set; }

        /// <summary>
        /// List of keyword of this unit
        /// </summary>
        public List<string> KeyWords { get; set; }
    }
}
