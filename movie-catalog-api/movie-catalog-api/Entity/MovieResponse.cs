using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace movie_catalog_api.Entity
{
    public class MovieResponse
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("genre")]
        public List<string> Genre { get; set; }

        [JsonPropertyName("director")]
        public DirectorDto Director { get; set; }

        [JsonPropertyName("cast")]
        public List<CastMemberDto> Cast { get; set; }

        [JsonPropertyName("duration_minutes")]
        public int DurationMinutes { get; set; }

        [JsonPropertyName("language")]
        public List<string> Language { get; set; }

        [JsonPropertyName("country")]
        public List<string> Country { get; set; }

        [JsonPropertyName("imdb_rating")]
        public double ImdbRating { get; set; }

        [JsonPropertyName("box_office")]
        public BoxOfficeDto BoxOffice { get; set; }

        [JsonPropertyName("release_date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }

    public class DirectorDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("birth_year")]
        public int BirthYear { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }
    }

    public class CastMemberDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }

    public class BoxOfficeDto
    {
        [JsonPropertyName("budget")]
        public decimal Budget { get; set; }

        [JsonPropertyName("gross_worldwide")]
        public decimal GrossWorldwide { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}