using System.Text.Json.Serialization;

namespace MarketApi.Models
{
    public class MarketEndOfDay
    {
        public float? Open { get; set; }

        public float? High { get; set; }

        public float? Low { get; set; }

        public float? Close { get; set; }

        public float? Volume { get; set; }

        [JsonPropertyName("adj_high")]
        public float? AdjustedHigh { get; set; }

        [JsonPropertyName("adj_low")]
        public float? AdjustedLow { get; set; }

        [JsonPropertyName("adj_open")]
        public float? AdjustedOpen { get; set; }

        [JsonPropertyName("adj_close")]
        public float? AdjustedClose { get; set; }

        [JsonPropertyName("adj_volume")]
        public float? AdjustedVolume { get; set; }

        [JsonPropertyName("split_factor")]
        public float? SplitFactor { get; set; }

        public float? Dividend { get; set; }

        public string? Symbol { get; set; }

        public string? Exchange { get; set; }

        public string? Date { get; set; }
    }
}
