using System;
using Newtonsoft.Json;

namespace HNews.Models
{
    public class UserModel
    {
        [JsonProperty("id")] public string Username { get; set; }

        [JsonProperty("created")] public int CreatedAt { get; set; }

        [JsonProperty("karma")] public int Karma { get; set; }

        [JsonProperty("about")] public string About { get; set; }
        
        public string FormattedCreatedAt => DateTimeOffset.FromUnixTimeSeconds(CreatedAt).LocalDateTime.ToString("MMMM dd, yyyy");
        //[JsonProperty("submitted")]
        // submitted = posts
    }
}