using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShatterpointReferences.Model;
using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;
using Shatterpoint.Lib.Units.Abilities;

namespace ShatterpointReferences.Controllers
{
    [Route("build")]
    public class BuildController : Controller
    {
        private readonly UnitDataBaseService db;
        private readonly SelectedUnitsService selectedUnitsService;

        public BuildController(UnitDataBaseService unitDataBaseService, SelectedUnitsService selectedUnitsService)
        {
            db = unitDataBaseService;
            this.selectedUnitsService = selectedUnitsService;
        }


        [HttpGet("index")]
        public ActionResult Index()
        {
            var model = new BuildModel();

            // Available units
            model.UnitList = db.UnitList;

            // Selected units
            model.SelectedUnits = ReadSelectedUnits().ToList();

            return View("Index", model);
        }

        // TODO: fix: 1 unit per cook for a maximum of 6 cookies. 

        private const string unit_1 = "selected_unit_1";
        private const string unit_2 = "selected_unit_2";
        private const string unit_3 = "selected_unit_3";
        private const string unit_4 = "selected_unit_4";
        private const string unit_5 = "selected_unit_5";
        private const string unit_6 = "selected_unit_6";

        private object _selectUnitLock = new object();

        [HttpGet("clear-selected-units")]
        public ActionResult ClearSelectedUnits()
        {
            Response.Cookies.Delete(unit_1);
            Response.Cookies.Delete(unit_2);
            Response.Cookies.Delete(unit_3);
            Response.Cookies.Delete(unit_4);
            Response.Cookies.Delete(unit_5);
            Response.Cookies.Delete(unit_6);
            selectedUnitsService.ClearSelectedUnits();
            return Ok();
        }

        [HttpGet("select-unit")]
        public ActionResult SelectUnit([FromQuery] string unitName)
        {
            var unit1 = Request.Cookies[unit_1] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_1]) : null;
            var unit2 = Request.Cookies[unit_2] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_2]) : null;
            var unit3 = Request.Cookies[unit_3] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_3]) : null;
            var unit4 = Request.Cookies[unit_4] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_4]) : null;
            var unit5 = Request.Cookies[unit_5] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_5]) : null;
            var unit6 = Request.Cookies[unit_6] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_6]) : null;

            var arrayUnit = new Unit[]
            {
                unit1,
                unit2,
                unit3,
                unit4,
                unit5,
                unit6
            };

            // lock: prevent concurrency issues. (warning: would not work if the application run with multiple instances)
            lock (_selectUnitLock)
            {
                // Case: Already exists
                var alreadyExists = arrayUnit.FirstOrDefault(x => x is not null && x.Name == unitName) is not null;
                if (alreadyExists)
                    return Ok();

                // Case: this name unit does not exist
                var unit = db.UnitList.FirstOrDefault(x => x.Name == unitName);
                if (unit is null)
                    return Ok();

                // Case: array full
                var notFull = arrayUnit.Any(x => x is null);
                if (!notFull)
                    return Ok();

                //Save to the first empty location
                var saved = false;
                var index = 1;

                while (!saved)
                {
                    if (arrayUnit[index - 1] is null)
                    {
                        var unitToSave = JsonConvert.SerializeObject(unit);
                        Response.Cookies.Append("selected_unit_" + index, unitToSave);
                        saved = true;
                        selectedUnitsService.AddUnit(unit);
                        break;
                    }
                    index++;
                    if (index >= 7)
                        throw new Exception("Could not save unit.");
                }
            }

            return Ok();
        }

        private Unit[] ReadSelectedUnits()
        {
            var unit1 = Request.Cookies[unit_1] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_1]) : null;
            var unit2 = Request.Cookies[unit_2] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_2]) : null;
            var unit3 = Request.Cookies[unit_3] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_3]) : null;
            var unit4 = Request.Cookies[unit_4] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_4]) : null;
            var unit5 = Request.Cookies[unit_5] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_5]) : null;
            var unit6 = Request.Cookies[unit_6] is not null ? JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_6]) : null;

            var arrayUnit = new Unit[]
            {
                unit1,
                unit2,
                unit3,
                unit4,
                unit5,
                unit6
            };
            return arrayUnit;
        }
    }
}
