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
            UnitList ??= [];

            UnitList.Add(StarterBoxFactory.Kalani());
            UnitList.Add(StarterBoxFactory.B1BAttleDroids());
            UnitList.Add(StarterBoxFactory.AsajjVentress());
            UnitList.Add(StarterBoxFactory.LordMaul());
            UnitList.Add(StarterBoxFactory.GarSaxon());
            UnitList.Add(StarterBoxFactory.MandalorianSuperCommandos());

            UnitList.Add(StarterBoxFactory.Anakin());
            UnitList.Add(StarterBoxFactory.CaptainRex());
            UnitList.Add(StarterBoxFactory._501StCloneTroopers());
            UnitList.Add(StarterBoxFactory.AhsokeJediNoMore());
            UnitList.Add(StarterBoxFactory.BoKatanKryze());
            UnitList.Add(StarterBoxFactory.ClanKryzeMandalorians());

#if DEBUG
            foreach (var unit in UnitList)
            {
                unit.StanceCardUrl1 = "/img/examples/Untitled.png";
                unit.StanceCardUrl2 = "/img/examples/Untitled.png";
                unit.MainCardUrl = "/img/examples/Untitled.png";
                unit.AbilityCardUrl = "/img/examples/Untitled.png";

                foreach (var item in unit.Abilities)
                {
                    item.Name = "Lorem ipsum dolor sit amet";
                    item.Cost = 0;
                    item.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nunc sed blandit libero volutpat sed cras ornare. Nulla";
                }
            }
#endif
        }
    }
}
