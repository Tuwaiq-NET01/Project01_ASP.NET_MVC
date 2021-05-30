using System;
using System.Net.Http;
namespace RioStore.Controllers
{
    public class FetchAPI
    {
        //public FetchAPI(string path)
        //{
        //    this.httpReq(path);
        //}
        public static string httpReq(string api)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(api);

                var resonse = client.GetAsync(uri);
                resonse.Wait();
                string res = resonse.Result.Content.ReadAsStringAsync().Result;

                return res;
            }
        }
    }
}


