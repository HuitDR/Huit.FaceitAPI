using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.MatchHistory
{
    public class Results
    {
        [JsonProperty("winner")]
        public string Winner { get; set; }

        [JsonProperty("score")]
        public Score Score { get; set; }
    }
}
