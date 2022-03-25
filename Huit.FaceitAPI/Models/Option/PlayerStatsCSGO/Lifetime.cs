using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.PlayerStatsCSGO
{
    public class Lifetime
    {
        [JsonProperty("Wins")]
        public string Wins { get; set; }

        [JsonProperty("Average K/D Ratio")]
        public string AvgKDRatio { get; set; }

        [JsonProperty("Recent Results")]
        public int?[] RecentResults { get; set; }

        [JsonProperty("Longest Win Streak")]
        public string LongestWinStreak { get; set; }

        [JsonProperty("Win Rate %")]
        public string WinRatePercent { get; set; }

        [JsonProperty("Matches")]
        public string Matches { get; set; }

        [JsonProperty("K/D Ratio")]
        public string KDRatio { get; set; }

        [JsonProperty("Total Headshots %")]
        public string TotalHeadshotsPercent { get; set; }

        [JsonProperty("Average Headshots %")]
        public string AvgHeadshotsPercent { get; set; }

        [JsonProperty("Current Win Streak")]
        public string CurrentWinStreak { get; set; }
    }
}
