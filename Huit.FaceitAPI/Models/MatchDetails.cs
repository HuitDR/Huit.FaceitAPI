using Huit.FaceitAPI.Models.Option.MatchDetails;
using Huit.FaceitAPI.Models.Option.MatchHistory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models
{
    public class  MatchDetails
    {
        [JsonProperty("best_of")]
        public int best_of { get; set; }

        [JsonProperty("broadcast_start_time")]
        public int broadcast_start_time { get; set; }

        [JsonProperty("broadcast_start_time_label")]
        public string broadcast_start_time_label { get; set; }

        [JsonProperty("calculate_elo")]
        public bool calculate_elo { get; set; }

        [JsonProperty("chat_room_id")]
        public string chat_room_id { get; set; }

        [JsonProperty("competition_id")]
        public string competition_id { get; set; }

        [JsonProperty("competition_name")]
        public string competition_name { get; set; }

        [JsonProperty("competition_type")]
        public string competition_type { get; set; }

        [JsonProperty("configured_at")]
        public int configured_at { get; set; }

        [JsonProperty("demo_url")]
        public string[] demo_url {get; set;}

        [JsonProperty("faceit_url")]
        public string faceit_url { get; set; }

        [JsonProperty("finished_at")]
        public int finished_at { get; set; }

        [JsonProperty("game")]
        public string game { get; set; }

        [JsonProperty("group")]
        public int group { get; set; }

        [JsonProperty("match_id")]
        public string match_id { get; set; }

        [JsonProperty("organizer_id")]
        public string organizer_id { get; set; }

        [JsonProperty("region")]
        public string region { get; set; }

        [JsonProperty("results")]
        public Results results {get; set;}

        [JsonProperty("round")]
        public int round { get; set; }

        [JsonProperty("scheduled_at")]
        public int scheduled_at { get; set; }

        [JsonProperty("started_at")]
        public int started_at { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("teams")]
        public mfaction[] teams { get; set; }

        [JsonProperty("version")]
        public int version { get; set; }

        [JsonProperty("voting")]
        public string[] voting { get; set; }
    }
}
