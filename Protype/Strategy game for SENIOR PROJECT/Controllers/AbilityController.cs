using Microsoft.AspNetCore.Mvc;
using Strategy_game_for_SENIOR_PROJECT.Models;

namespace Strategy_game_for_SENIOR_PROJECT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AbilityController : Controller
    {
        private static readonly List<Ability> _abilities = Ability.GetAbilities();
        private readonly ILogger<AbilityController> _logger;

        public AbilityController(ILogger<AbilityController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAbilityList")]
        public IEnumerable<Ability> Get() => Ability.GetAbilities();

    }
}
