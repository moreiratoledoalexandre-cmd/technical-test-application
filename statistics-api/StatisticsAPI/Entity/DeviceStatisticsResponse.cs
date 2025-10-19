using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StatisticsAPI.Entity
{
    public class DeviceStatisticsResponse
    {
        [JsonPropertyName("deviceType")]
        public string DeviceType { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}