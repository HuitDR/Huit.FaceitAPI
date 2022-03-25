using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Models.Option.PlayerStatsCSGO
{
    public class SegmentStat
    {
    [JsonProperty("Average Penta Kills")]
    public string AvgPentaKills { get; set; }

    [JsonProperty("Triple Kills")]
    public string TripleKills { get; set; }

    [JsonProperty("Assists")]
    public string Assists { get; set; }

    [JsonProperty("Average K/R Ratio")]
    public string AvgKRRatio { get; set; }

    [JsonProperty("Average Quadro Kills")]
    public string AvgQuadroKills { get; set; }

    [JsonProperty("Average Assists")]
    public string AvgAssists  { get; set; }

    [JsonProperty("Average MVPs")]
    public string AvgMVPs  { get; set; }

    [JsonProperty("Headshots per Match")]
    public string HeadshotsperMatch  { get; set; }

    [JsonProperty("Deaths")]
    public string Deaths { get; set; }
    
    [JsonProperty("Average Triple Kills")]
    public string AvgTripleKills  { get; set; }

    [JsonProperty("Quadro Kills")]
    public string QuadroKills  { get; set; }

    [JsonProperty("Win Rate %")]
    public string WinRatePercent { get; set; }

    [JsonProperty("Penta Kills")]
    public string PentaKills { get; set; }

    [JsonProperty("Average K/D Ratio")]
    public string AvgKDRatio { get; set; }

    [JsonProperty("Average Deaths")]
    public string AvgDeaths { get; set; }

    [JsonProperty("Kills")]
    public string Kills { get; set; }

    [JsonProperty("Total Headshots %")]
    public string TotalHeadshotsPercent { get; set; }

    [JsonProperty("Average Headshots %")]
    public string AvgHeadshotsPercent { get; set; }

    [JsonProperty("K/R Ratio")]
    public string KRRatio { get; set; }

    [JsonProperty("Wins")]
    public string Wins { get; set; }

    [JsonProperty("Rounds")]
    public string Rounds { get; set; }

    [JsonProperty("Matches")]
    public string Matches { get; set; }

    [JsonProperty("MVPs")]
    public string MVPs { get; set; }

    [JsonProperty("Headshots")]
    public string Headshots { get; set; }

    [JsonProperty("Average Kills")]
    public string AvgKills { get; set; }

    [JsonProperty("K/D Ratio")]
    public string KDRatio { get; set; }
    }
}
