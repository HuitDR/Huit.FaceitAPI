using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models
{
    public class factions
    {
        [JsonProperty("faction1")]
        public faction faction1 { get; set; }

        [JsonProperty("faction2")]
        public faction faction2 { get; set; }
    }
}
