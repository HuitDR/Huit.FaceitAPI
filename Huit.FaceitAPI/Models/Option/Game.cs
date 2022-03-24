using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models
{
    public class Game
    {
        [JsonProperty("faceit_elo")]
        public int FaceitElo { get; set; }

        [JsonProperty("game_player_id")]
        public string GamePlayerId { get; set; }

        [JsonProperty("game_player_name")]
        public string GamePLayerName { get; set; }

        [JsonProperty("game_profile_id")]
        public string GameProfileId { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("skill_level")]
        public int SkillLevel { get; set; }

        [JsonProperty("skill_level_label")]
        public string SkillLevelText { get; set; }
    }
}
