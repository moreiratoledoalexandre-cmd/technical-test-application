using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeviceRegistrationAPI.Entity
{
    public class DeviceRegistrationRequest
    {
        [JsonPropertyName("userKey")]
        public required string UserKey { get; set; }
        [JsonPropertyName("DeviceType")]
        public required string DeviceType { get; set; } 
    }
}