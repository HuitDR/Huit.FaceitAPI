using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.MatchDetails
{
    public class Roaster
    {
        [JsonProperty("anticheat_required")]
        public bool anticheat_required { get; set; }

        [JsonProperty("avatar")]
        public string avatar { get; set; }

        [JsonProperty("game_player_id")]
        public string game_player_id { get; set; }

        [JsonProperty("game_player_name")]
        public string game_player_name { get; set; }

        [JsonProperty("game_skill_level")]
        public int game_skill_level { get; set; }

        [JsonProperty("membership")]
        public string membership { get; set; }

        [JsonProperty("nickname")]
        public string nickname { get; set; }

        [JsonProperty("player_id")]
        public string player_id { get; set; }
    }
}
