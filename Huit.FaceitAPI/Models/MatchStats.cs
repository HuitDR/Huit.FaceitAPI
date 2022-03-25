using Huit.FaceitAPI.Models.Option.csgostats;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models
{
    public class MatchStats
    {
        [JsonProperty("rounds")]
        public MatchStatistic[] Matchstats { get; set; }
    }
}
