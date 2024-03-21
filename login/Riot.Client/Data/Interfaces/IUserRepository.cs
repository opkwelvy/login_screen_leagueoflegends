using Riot.Client.Domain.Models;

namespace Riot.Client.Data.Interfaces
{
    public interface IUserRepository
    {
        void Create(User  user);
        User Get(int Id);
        List<User> GetAll();
        void update(User user);
        void Delete (int Id);

    }
}
