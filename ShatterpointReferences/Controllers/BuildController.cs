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

        private const string SelectedUnits_Cookie = "SelectedUnits_Cookie";

        [HttpGet("select-unit")]
        public ActionResult SelectUnit([FromQuery] string unitName)
        {
            var listAsCookie = Request.Cookies[SelectedUnits_Cookie];
            List<Unit> selectedList = new();

            if (!string.IsNullOrWhiteSpace(listAsCookie)) 
                selectedList = JsonConvert.DeserializeObject<List<Unit>>(listAsCookie);

            if (selectedList.Any(x => x.Name == unitName))
                return Ok();

            var unit = db.UnitList.FirstOrDefault(x => x.Name == unitName);
            if (unit is null)
                return Ok();

            selectedList.Add(unit);

            var selectedListAsCookie = JsonConvert.SerializeObject(selectedList);
            Response.Cookies.Append(SelectedUnits_Cookie, selectedListAsCookie);

            return Ok();

        }
    }
}
