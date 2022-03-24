using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.csgostats
{
    public class RoundStats
    {
        [JsonProperty("Map")]
        public string Map { get; set; }

        [JsonProperty("Winner")]
        public string Winner { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("Rounds")]
        public string Rounds { get; set; }

        [JsonProperty("Score")]
        public string Score { get; set; }
    }
}
