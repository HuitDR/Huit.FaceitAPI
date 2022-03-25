using Huit.FaceitAPI.Models.Option.MatchHistory;
using Newtonsoft.Json;

namespace Huit.FaceitAPI.Models.Option.MatchHistory
{
    public class faction
    {
        [JsonProperty("team_id")]
        public string TeamID { get; set; }

        [JsonProperty("nickname")]
        public string NickName { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("players")]
        public PlayerCSGO[] players { get; set; }

    }
}
