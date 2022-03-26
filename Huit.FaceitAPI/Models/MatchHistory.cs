using Huit.FaceitAPI.Models.Option.MatchHistory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models
{
    public class MatchHistory
    {
        // /players/{player_id}/history
        [JsonProperty("items")]
        public MatchDetails[] Match { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("from")]
        public Int64 from { get; set; }

        [JsonProperty("to")]
        public Int64 To { get; set; }
    }
}
