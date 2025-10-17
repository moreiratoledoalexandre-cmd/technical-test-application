using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace movie_catalog_api.Model
{
    public class BoxOffice
    {
        [BsonElement("budget")]
        public decimal Budget { get; set; }

        [BsonElement("gross_worldwide")]
        public decimal GrossWorldwide { get; set; }

        [BsonElement("currency")]
        public string Currency { get; set; }
    }
}