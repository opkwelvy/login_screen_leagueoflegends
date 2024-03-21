using Riot.Client.Logic.Dto;

namespace Riot.Client.Logic.Interface
{
    public interface IUserService
    {
        void Create(UserDto user);
        void Update(UserDto user);
        void Delete(int Id);
        UserDto Get(int id);
        
        List<UserDto> GetAll();
    }
}
