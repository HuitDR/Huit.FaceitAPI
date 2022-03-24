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
        ///players/{player_id}/history
        [JsonProperty("items")]
        public MatchDetails[] Match { get; set; }
    }
}
