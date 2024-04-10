using Shatterpoint.Lib.Units;

namespace ShatterpointReferences.Model
{
    public class BuildModel
    {
        public List<Unit> UnitList { get; set; } = new List<Unit>();
        public List<Unit> SelectedUnits { get; set; } = new List<Unit>();
    }
}
