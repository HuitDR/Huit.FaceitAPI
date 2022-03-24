using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.csgostats
{
    public class PlayerCSGO
    {
        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("nickname")]
        public string NickName { get; set; }

        [JsonProperty("player_stats")]
        public PlayerCSGOStats PlayerStats { get; set; }
    }
}
