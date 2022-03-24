using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.csgostats
{
    public class TeamCSGOStats
    {
        [JsonProperty("Team Win")]
        public string KRRatio { get; set; }

        [JsonProperty("Team Headshots")]
        public string Headshots { get; set; }

        [JsonProperty("Overtime score")]
        public string PentaKills { get; set; }

        [JsonProperty("First Half Score")]
        public string Kills { get; set; }

        [JsonProperty("Team")]
        public string TripleKills { get; set; }

        [JsonProperty("Final Score")]
        public string KDRatio { get; set; }

        [JsonProperty("Second Half Score")]
        public string Result { get; set; }
    }
}
