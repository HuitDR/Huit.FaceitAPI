using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.MatchDetails
{
    public class mfaction
    {
        [JsonProperty("avatar")]
        public string avatar { get; set; }

        [JsonProperty("faction_id")]
        public string faction_id { get; set; }

        [JsonProperty("leader")]
        public string leader { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("roster")]
        public Roaster roster {get; set;}

        [JsonProperty("roster_v1")]
        public string[] roster_v1 {get; set;}

        [JsonProperty("substituted")]
        public bool substituted { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }
    }
}
