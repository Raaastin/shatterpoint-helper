using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShatterpointReferences.Services;
using ShatterpointReferences.Units;

namespace ShatterpointReferences.Pages
{
    public class BuildModel : PageModel
    {
        private readonly ILogger<BuildModel> _logger;
        private readonly RoasterServices _roasterServices;
        public List<Unit> UnitList { get; set; }

        public BuildModel(ILogger<BuildModel> logger, RoasterServices roasterServices)
        {
            _logger = logger;
            _roasterServices = roasterServices;
        }

        public void OnGet()
        {
            UnitList = _roasterServices.UnitList;
        }
    }
}
