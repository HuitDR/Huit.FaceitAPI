using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.MatchHistory
{
    public class MatchDetails
    {
        [JsonProperty("match_id")]
        public string MatchID { get; set; }

        [JsonProperty("game_id")]
        public string GameID { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("match_type")]
        public string MatchType { get; set; }

        [JsonProperty("game_mode")]
        public string GameMode { get; set; }

        [JsonProperty("max_players")]
        public int MaxPlayers { get; set; }

        [JsonProperty("teams_size")]
        public int TeamSize { get; set; }

        [JsonProperty("teams")]
        public factions factions { get; set; }

        [JsonProperty("playing_players")]
        public string[] PlayingPlayers { get; set; }

        [JsonProperty("competition_id")]
        public string CompletitionID { get; set; }

        [JsonProperty("competition_name")]
        public string CompletitionName { get; set; }

        [JsonProperty("competition_type")]
        public string CompletitionType { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("finished_at")]
        public int FinishedAt { get; set; }

        [JsonProperty("results")]
        public Results Results { get; set; }

        [JsonProperty("faceit_url")]
        public string FaceitUrl { get; set; }
    }
}
