using System.Threading.Tasks;
using HNews.Models;

namespace HNews.Services
{
    public interface IUsersService
    {
        Task<UserModel> GetUserProfile(string username);
    }
}