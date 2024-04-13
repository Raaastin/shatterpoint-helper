using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units.Abilities;

namespace Shatterpoint.Lib.Services
{
    /// <summary>
    /// Simple Hard Coded service that provide all existing units
    /// </summary>
    public class UnitDataBaseService
    {
        /// <summary>
        /// All the available units
        /// </summary>
        public List<Unit> UnitList { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        public UnitDataBaseService()
        {
            InitStarterBox();
        }

        /// <summary>
        /// Get a unit by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Unit Get(string name)
        {
            return UnitList.FirstOrDefault(x => x.Name == name);
        }

        /// <summary>
        /// Generate data for StartedBox
        /// </summary>
        private void InitStarterBox()
        {
            if (UnitList is null)
                UnitList = new();

            UnitList.Add(StarterBoxFactory.Kalani());
            UnitList.Add(StarterBoxFactory.B1BAttleDroids());
            UnitList.Add(StarterBoxFactory.AsajiVentress());
            UnitList.Add(StarterBoxFactory.LordMaul());
            UnitList.Add(StarterBoxFactory.GarSaxon());
            UnitList.Add(StarterBoxFactory.MandalorianSuperCommandos());
        }
    }
}
