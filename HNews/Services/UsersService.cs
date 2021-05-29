using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HNews.Models;
using Newtonsoft.Json;

namespace HNews.Services
{
    public class UsersService : IUsersService
    {
        private const string Baseurl = "https://hacker-news.firebaseio.com/v0/";

        public async Task<UserModel> GetUserProfile(string username)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync($"user/{username}.json");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<UserModel>(json);
                }

                return null;
            }
        }
    }
}