using System.Threading.Tasks;

namespace Duizenden.WebApi.Hubs {
    public interface IPlayerHub {
        Task PlayerJoined(string playerName);
    }
}
