using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace movie_catalog_api.Model
{
    public class Director
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("birth_year")]
        public int BirthYear { get; set; }

        [BsonElement("nationality")]
        public string Nationality { get; set; }
    }
}