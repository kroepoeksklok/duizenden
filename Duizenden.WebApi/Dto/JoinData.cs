using Newtonsoft.Json;

namespace Duizenden.WebApi.Dto {
    public sealed class JoinData {
        [JsonProperty("playerName")]
        public string PlayerName { get; set; }
    }
}
