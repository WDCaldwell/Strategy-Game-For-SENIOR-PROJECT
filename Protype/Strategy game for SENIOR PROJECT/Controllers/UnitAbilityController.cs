using Microsoft.AspNetCore.Mvc;
using Strategy_game_for_SENIOR_PROJECT.Models;

namespace Strategy_game_for_SENIOR_PROJECT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitAbilityController : Controller
    {
        private static readonly List<UnitAbility> _abilities = UnitAbility.GetAbilities();
        private readonly ILogger<UnitAbilityController> _logger;

        public UnitAbilityController(ILogger<UnitAbilityController> logger)
        {
            _logger = logger;
        }

        //will be replaced latter to refrence the Ability and Unit tables to grab their name in a straight forward ID to ID in order to grab the names
        [HttpGet(Name = "GetUnitAbilityList")]
        public IEnumerable<UnitAbility> Get() => UnitAbility.GetAbilities();
    }
}
