using Huit.FaceitAPI.Models.Option.PlayerStatsCSGO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models
{
    public class GameStat
    {
        [JsonProperty("player_id")]
        public string PlayerID { get; set; }

        [JsonProperty("game_id")]
        public string GameID { get; set; }

        [JsonProperty("lifetime")]
        public Lifetime GamePLayerName { get; set; }

        [JsonProperty("segments")]
        public Segment[] Segments { get; set; }
    }
}
