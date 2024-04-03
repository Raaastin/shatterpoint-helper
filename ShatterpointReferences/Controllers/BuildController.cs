using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShatterpointReferences.Services;
using ShatterpointReferences.Units;

namespace ShatterpointReferences.Controllers
{
    [Route("build")]
    public class BuildController : Controller
    {
        private readonly UnitDataBaseService db;

        public BuildController(UnitDataBaseService unitDataBaseService)
        {
            db = unitDataBaseService;
        }


        [HttpGet("index")]
        public ActionResult Index()
        {
            return View("Index", db.UnitList);
        }

        // TODO: fix: 1 unit per cook for a maximum of 6 cookies. 

        private const string unit_1 = "selected_unit_1";
        private const string unit_2 = "selected_unit_2";
        private const string unit_3 = "selected_unit_3";
        private const string unit_4 = "selected_unit_4";
        private const string unit_5 = "selected_unit_5";
        private const string unit_6 = "selected_unit_6";

        [HttpGet("select-unit")]
        public ActionResult SelectUnit([FromQuery] string unitName)
        {
            var unit1 = JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_1]);
            var unit2 = JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_2]);
            var unit3 = JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_3]);
            var unit4 = JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_4]);
            var unit5 = JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_5]);
            var unit6 = JsonConvert.DeserializeObject<Unit>(Request.Cookies[unit_6]);

            var arrayUnit = new Unit[]
            {
                unit1,
                unit2,
                unit3,
                unit4,
                unit5,
                unit6
            };

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
            
            var unitToSave = JsonConvert.SerializeObject(unit);
            //Save to the first empty location

            var selectedListAsCookie = JsonConvert.SerializeObject(selectedList);
            Response.Cookies.Append(SelectedUnits_Cookie, selectedListAsCookie);

            return Ok();

        }
    }
}
