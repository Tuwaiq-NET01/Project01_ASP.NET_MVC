using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HNews.Models
{
    public class PostModel
    {
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("time")] public int PostedAt { get; set; }

        [JsonProperty("by")] public string Author { get; set; }

        [JsonProperty("type")] public string PostType { get; set; }
        
        [JsonProperty("title")] public string Title { get; set; }
        
        [JsonProperty("text")] public string Content { get; set; }

        [JsonProperty("url")] public string Url { get; set; }
        
        [JsonProperty("score")] public int Score { get; set; }
        
        [JsonProperty("descendants")] public int CommentsCount { get; set; }

        public string IconUrl => Url != null ? "https://www.google.com/s2/favicons?domain=" + Url : "";
        
        [JsonProperty("kids")] public List<int> CommentsIds { get; set; }
        
        public IEnumerable<PostModel> Comments { get; set; }
        
        public string WebsiteName => new Uri(Url).Host.Replace("www.", "");

        public string GetRelativePostDate()
        {
            var date = DateTimeOffset.FromUnixTimeSeconds(PostedAt).LocalDateTime;
            var timeSpan = DateTime.Now.Subtract(date);

            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                return timeSpan.Seconds + " seconds ago";
            }
            
            if (timeSpan <= TimeSpan.FromMinutes(60))
            {
                return timeSpan.Minutes > 1
                    ? timeSpan.Minutes + " minutes ago"
                    : "a minute ago";
            }

            if (timeSpan <= TimeSpan.FromHours(24))
            {
                return timeSpan.Hours > 1
                    ? timeSpan.Hours + " hours ago"
                    : "an hour ago";
            }
            
            if (timeSpan <= TimeSpan.FromDays(30))
            {
                return timeSpan.Days > 1 ? timeSpan.Days + " days ago" : "yesterday";
            }

            return "";
        }
    }
}