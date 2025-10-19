using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;

namespace movie_catalog_api.Model
{
    [Collection("movies_collection")]
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("year")]
        public int Year { get; set; }

        [BsonElement("genre")]
        public List<string> Genre { get; set; }

        [BsonElement("director")]
        public Director Director { get; set; }

        [BsonElement("cast")]
        public List<CastMember> Cast { get; set; }

        [BsonElement("duration_minutes")]
        public int DurationMinutes { get; set; }

        [BsonElement("language")]
        public List<string> Language { get; set; }

        [BsonElement("country")]
        public List<string> Country { get; set; }

        [BsonElement("imdb_rating")]
        public double ImdbRating { get; set; }

        [BsonElement("box_office")]
        public BoxOffice BoxOffice { get; set; }

        [BsonElement("release_date")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime ReleaseDate { get; set; }

        [BsonElement("created_at")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updated_at")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? UpdatedAt { get; set; } 
    }
}