using System.Text.Json.Serialization;

namespace WaterApi.Models
{
    public class CurrentWaterTimeSeries
    {
        public CurrentWaterSourceInfo SourceInfo { get; set; }

        [JsonPropertyName("values")]
        public List<CurrentWaterSourceDetailsWrapper> SourceDetailsWrapper { get; set; }
    }
}
