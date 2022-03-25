using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models
{
    public class Games
    {
        [JsonProperty("csgo")]
        public Game csgo { get; set; }

    }
}
