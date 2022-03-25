using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.MatchHistory
{
    public class Score
    {
        [JsonProperty("faction2")]
        public int Faction2 { get; set; }

        [JsonProperty("faction1")]
        public int Faction1 { get; set; }
    }
}
