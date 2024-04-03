using Microsoft.AspNetCore.Mvc;
using ShatterpointReferences.Units.Abilities;

namespace ShatterpointReferences.Controller
{
    public class UnitController : ControllerBase
    {

        public UnitController()
        {

        }

        [Route("unit/")]
        public ActionResult<List<Ability>> GetCurrentSynergy()
        {
            return null;
        }
    }
}
