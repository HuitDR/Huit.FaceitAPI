using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.Tournament
{
    public class Tournament
    {
        [JsonProperty("anticheat_required")]
        public bool anticheat_required { get; set; }

        [JsonProperty("custom")]
        public bool custom { get; set; }

        [JsonProperty("faceit_url")]
        public string faceit_url { get; set; }

        [JsonProperty("featured_image")]
        public string featured_image { get; set; }

        [JsonProperty("game_id")]
        public string game_id { get; set; }

        [JsonProperty("invite_type")]
        public string invite_type { get; set; }

        [JsonProperty("match_type")]
        public string match_type { get; set; }

        [JsonProperty("max_skill")]
        public int max_skill { get; set; }

        [JsonProperty("membership_type")]
        public string membership_type { get; set; }

        [JsonProperty("min_skill")]
        public int min_skill { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("number_of_players")]
        public int number_of_players { get; set; }

        [JsonProperty("number_of_players_checkedin")]
        public int number_of_players_checkedin { get; set; }

        [JsonProperty("number_of_players_joined")]
        public int number_of_players_joined { get; set; }

        [JsonProperty("number_of_players_participants")]
        public int number_of_players_participants { get; set; }

        [JsonProperty("organizer_id")]
        public string organizer_id { get; set; }

        [JsonProperty("prize_type")]
        public string prize_type { get; set; }

        [JsonProperty("region")]
        public string region { get; set; }

        [JsonProperty("started_at")]
        public int started_at { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("subscriptions_count")]
        public int subscriptions_count { get; set; }

        [JsonProperty("team_size")]
        public int team_size { get; set; }

        [JsonProperty("tournament_id")]
        public string tournament_id { get; set; }

        [JsonProperty("whitelist_countries")]
        public string[] whitelist_countries { get; set; }
    }
}
