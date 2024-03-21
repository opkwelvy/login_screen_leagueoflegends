using Riot.Client.Logic.Dto;

namespace Riot.Client.Logic.Interface
{
    public interface IFriendService
    {
        void Create(FriendDto friend);
        void Update(FriendDto friend);
        void Delete(int Id);
        FriendDto Get(int Id);
        List<FriendDto> GetAll();   
    }
}
