using AutoMapper;
using Riot.Client.Data.Interfaces;
using Riot.Client.Domain.Models;
using Riot.Client.Logic.Dto;
using Riot.Client.Logic.Interface;

namespace Riot.Client.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _repository;
        public UserService(IMapper mapper, IUserRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public void Create(UserDto user)
        {
            //Eu não consigo fazer o método de repository funcionar porque ele espera um User
            //E não um UserDto. O Mapper irá mapear a entidade através do map na variável
            //Ou seja, a variável está com o tipo certo
            var _user = _mapper.Map<User>(user);
            _repository.Create(_user);

        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public UserDto Get(int Id)
        {
            return _mapper.Map<UserDto>(_repository.Get(Id));
            //Aqui é o inverso. Eu estou recebendo um User e preciso devolver um UserDto
        }

        public List<UserDto> GetAll()
        {
            return _mapper.Map<List<UserDto>>(_repository.GetAll());

        }

        public void Update(UserDto user)
        {
            var _user = _mapper.Map<User>(user);
            _repository.update(_user);
        }
    }
}
