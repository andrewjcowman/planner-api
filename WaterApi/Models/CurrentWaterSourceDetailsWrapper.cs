using System.Text.Json.Serialization;

namespace WaterApi.Models
{
    public class CurrentWaterSourceDetailsWrapper
    {
        [JsonPropertyName("value")]
        public List<CurrentWaterSourceDetails> SourceDetails { get; set; }
    }
}