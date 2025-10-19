using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;

namespace DeviceRegistrationAPI.Entity
{
    [Collection("user_devices_collection")]
    public class UserDevices
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserKey { get; set; }

        [BsonElement("DeviceList")]
        public List<String> Devices { get; set; }
    }
}