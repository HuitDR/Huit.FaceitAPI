using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.csgostats
{
    public class MatchStatistic
    {
        [JsonProperty("best_of")]
        public string BoX { get; set; }

        [JsonProperty("competition_id")]
        public string CompletitionID { get; set; }

        [JsonProperty("game_id")]
        public string GameID { get; set; }

        [JsonProperty("game_mode")]
        public string GameMode { get; set; }

        [JsonProperty("match_id")]
        public string MatchID { get; set; }

        [JsonProperty("match_round")]
        public string MatchRound { get; set; }

        [JsonProperty("played")]
        public string played { get; set; }

        [JsonProperty("round_stats")]
        public RoundStats Kills { get; set; }

        [JsonProperty("teams")]
        public Teams[] Teams { get; set; }
    }
}
