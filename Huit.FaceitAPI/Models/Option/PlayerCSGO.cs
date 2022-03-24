using Newtonsoft.Json;

namespace Huit.FaceitAPI.Models
{
    public class PlayerCSGO
    {
        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("nickname")]
        public string NickName { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("skill_level")]
        public int SkillLevel { get; set; }

        [JsonProperty("game_player_id")]
        public string GamePlayerId { get; set; }

        [JsonProperty("game_player_name")]
        public string GamePlayerName { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitURL { get; set; }
    }
}
