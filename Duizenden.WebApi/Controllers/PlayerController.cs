using System.Threading.Tasks;
using Duizenden.WebApi.Dto;
using Duizenden.WebApi.Hubs;
using Duizenden.WebApi.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Duizenden.WebApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase {
        private readonly IHubContext<PlayerHub, IPlayerHub> _playerHubContext;

        public PlayerController(IHubContext<PlayerHub, IPlayerHub> playerHubContext) {
            _playerHubContext = playerHubContext;
        }

        [HttpPost]
        public async Task<Player> Post(JoinData joinData) {
            var joinedPlayer = Game.Instance.Join(joinData.PlayerName);
            await _playerHubContext.Clients.All.PlayerJoined(joinData.PlayerName);
            return joinedPlayer;
        }
    }
}
