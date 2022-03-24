using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.csgostats
{
    public class Teams
    {
        [JsonProperty("team_id")]
        public string TeamID { get; set; }

        [JsonProperty("premade")]
        public string premade { get; set; }

        [JsonProperty("team_stats")]
        public TeamCSGOStats PentaKills { get; set; }

        [JsonProperty("players")]
        public PlayerCSGO[] Players { get; set; }
    }
}
