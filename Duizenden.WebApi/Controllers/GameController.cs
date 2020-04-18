using Duizenden.WebApi.Logic;
using Microsoft.AspNetCore.Mvc;

namespace Duizenden.WebApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase {
        [HttpPost]
        public Game Get() {
            return Game.Instance;
        }
    }
}
