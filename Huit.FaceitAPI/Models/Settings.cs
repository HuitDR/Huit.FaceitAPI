using Newtonsoft.Json;


namespace Huit.FaceitAPI.Models
{
    public class Settings
    {
        [JsonProperty("language")]
        public string language { get; set; }
    }
}
