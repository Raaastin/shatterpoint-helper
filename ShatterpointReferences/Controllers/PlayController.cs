using System;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShatterpointReferences.Model;
using ShatterpointReferences.Services;
using ShatterpointReferences.Units;
using ShatterpointReferences.Units.Abilities;

namespace ShatterpointReferences.Controllers
{
    [Route("play")]
    public class PlayController : Controller
    {
        private readonly UnitDataBaseService db;

        public PlayController(UnitDataBaseService unitDataBaseService)
        {
            db = unitDataBaseService;
        }


        [HttpGet("index")]
        public ActionResult Index()
        {
            var selectedUnits = ReadSelectedUnits().ToList();

            return View("Index", selectedUnits);
        }

        private const string unit_1 = "selected_unit_1";
        private const string unit_2 = "selected_unit_2";
        private const string unit_3 = "selected_unit_3";
        private const string unit_4 = "selected_unit_4";
        private const string unit_5 = "selected_unit_5";
        private const string unit_6 = "selected_unit_6";

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

        [HttpGet("activate-unit")]
        public ActionResult ActivateUnit([FromQuery] string unitName)
        {
            var unit = db.UnitList.FirstOrDefault(x => x.Name == unitName);
            if (unit is null)
                return NotFound();

            var activeAbilities = ActivateUnitService.ActivateUnit(unit, ReadSelectedUnits().ToList());

            var data = new ActiveUnitPartialModel();
            data.ActiveUnit = unit;
            data.CurrentActivationSynergies = activeAbilities;

            return PartialView("ActiveUnitPartial", data);
        }

        [HttpGet("target-unit")]
        public ActionResult TargetUnit([FromQuery] string unitName)
        {
            var unit = db.UnitList.FirstOrDefault(x => x.Name == unitName);
            if (unit is null)
                return NotFound();

            var activeAbilities = ActivateUnitService.GettingTargeted(unit, ReadSelectedUnits().ToList());

            var data = new TargetedUnitPartialModel();
            data.SelectedUnit = unit;
            data.CurrentTargetSynergies = activeAbilities;

            return PartialView("TargetedUnitPartial", data);
        }
    }
}
