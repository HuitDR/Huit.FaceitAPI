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
        public string TeamWinnner { get; set; }

        [JsonProperty("Team Headshots")]
        public string Headshots { get; set; }

        [JsonProperty("Overtime score")]
        public string OverTimeScore { get; set; }

        [JsonProperty("First Half Score")]
        public string FirstHalf { get; set; }

        [JsonProperty("Team")]
        public string Team { get; set; }

        [JsonProperty("Final Score")]
        public string FinalScore { get; set; }

        [JsonProperty("Second Half Score")]
        public string SecondHalf { get; set; }
    }
}
