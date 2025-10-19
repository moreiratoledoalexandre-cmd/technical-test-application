using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace StatisticsAPI.Entity
{
    public class DeviceLogRequest
    {
        [JsonPropertyName("userKey")]
        public required string UserKey { get; set; }
        [JsonPropertyName("deviceType")]
        public required string DeviceType { get; set; }
    }
}