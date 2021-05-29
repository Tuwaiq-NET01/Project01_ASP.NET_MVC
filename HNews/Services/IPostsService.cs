using System.Collections.Generic;
using System.Threading.Tasks;
using HNews.Models;

namespace HNews.Services
{
    public interface IPostsService
    {
        Task<PostModel> GetPostById(int id, bool withComments);
        Task<IEnumerable<PostModel>> GetTopPosts();
    }
}