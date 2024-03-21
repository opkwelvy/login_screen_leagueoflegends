using Riot.Client.Domain.Models;

namespace Riot.Client.Data.Interfaces
{
    public interface IFriendRepository
    {
        void Create(Friend friend);
        Friend Get(int Id);
        List<Friend> GetAll();
        void Update(Friend friend);
        void Delete(int Id);
    }
}
