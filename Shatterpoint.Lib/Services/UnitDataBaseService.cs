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
        public List<Unit> UnitList { get; set; }

        public UnitDataBaseService()
        {
            InitStartedSet();
        }

        public Unit Get(string name)
        {
            return UnitList.FirstOrDefault(x => x.Name == name);
        }

        private void InitStartedSet()
        {
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
