using System.Threading.Tasks;
using HeroClub.Domain;

namespace HeroClub.Repository
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}