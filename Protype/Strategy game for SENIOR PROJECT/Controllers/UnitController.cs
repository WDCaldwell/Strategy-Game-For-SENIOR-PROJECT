using Microsoft.AspNetCore.Mvc;
using Strategy_game_for_SENIOR_PROJECT.Models;

namespace Strategy_game_for_SENIOR_PROJECT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitController : ControllerBase
    {
        private static readonly List<Unit> _unit = Unit.GetUnits();
        private readonly ILogger<UnitController> _logger;

        public UnitController(ILogger<UnitController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUnitsList")]
        public IEnumerable<Unit> Get() => Unit.GetUnits();
    }
}
