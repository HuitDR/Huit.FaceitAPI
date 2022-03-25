using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.csgostats
{
    public class PlayerCSGOStats
    {
        [JsonProperty("K/R Ratio")]
        public string KRRatio { get; set; }

        [JsonProperty("Headshots")]
        public string Headshots { get; set; }

        [JsonProperty("Penta Kills")]
        public string PentaKills { get; set; }

        [JsonProperty("Kills")]
        public string Kills { get; set; }

        [JsonProperty("Triple Kills")]
        public string TripleKills { get; set; }

        [JsonProperty("K/D Ratio")]
        public string KDRatio { get; set; }

        [JsonProperty("Result")]
        public string Result { get; set; }

        [JsonProperty("Assists")]
        public string Assists { get; set; }

        [JsonProperty("Headshots %")]
        public string HeadshotsPercent { get; set; }

        [JsonProperty("Deaths")]
        public string Deaths { get; set; }

        [JsonProperty("MVPs")]
        public string MVPs { get; set; }

        [JsonProperty("Quadro Kills")]
        public string QuadroKills { get; set; }
    }
}
