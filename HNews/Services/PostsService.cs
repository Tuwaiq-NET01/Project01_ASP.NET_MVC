using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HNews.Models;
using Newtonsoft.Json;

namespace HNews.Services
{
    public class PostsService : IPostsService
    {
        private const string BaseUrl = "https://hacker-news.firebaseio.com/v0/";

        public async Task<PostModel> GetPostById(int id, bool withComments)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync($"item/{id}.json");

                if (!response.IsSuccessStatusCode) return null;
                var json = await response.Content.ReadAsStringAsync();
                PostModel post = JsonConvert.DeserializeObject<PostModel>(json);
                if (post == null) return null;
                if (!withComments || post.CommentsIds == null) return post;
                var tasks = post.CommentsIds.Select(commentId => this.GetPostById(commentId, false)).ToList();
                post.Comments = await Task.WhenAll(tasks);
                
                return post;
            }
        }

        public async Task<IEnumerable<PostModel>> GetTopPosts()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync($"topstories.json?");

                if (!response.IsSuccessStatusCode) return null;
                var json = await response.Content.ReadAsStringAsync();
                var postsIds = JsonConvert.DeserializeObject<int[]>(json);

                if (postsIds == null) return null;
                Array.Resize(ref postsIds, 10);

                var tasks = postsIds.Select(id => this.GetPostById(id, false)).ToList();

                return await Task.WhenAll(tasks);
            }
        }
    }
}