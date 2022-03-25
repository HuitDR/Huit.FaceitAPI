using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.PlayerStatsCSGO
{
    public class Segment
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("img_small")]
        public string ImgSmall { get; set; }

        [JsonProperty("img_regular")]
        public string ImgRegular { get; set; }

        [JsonProperty("stats")]
        public SegmentStat Stats { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
