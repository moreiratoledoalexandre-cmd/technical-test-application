using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;

namespace StatisticsAPI.Entity
{
    public class LogHistory
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("UserKey")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserKey { get; set; }

        [BsonElement("DeviceDescription")]
        public string DeviceDescription { get; set; }

        [BsonElement("DevicesType")]
        public DeviceTypes DevicesType { get; set; }
    }
}