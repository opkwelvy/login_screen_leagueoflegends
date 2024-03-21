using AutoMapper;
using Riot.Client.Data.Interfaces;
using Riot.Client.Domain.Models;
using Riot.Client.Logic.Dto;
using Riot.Client.Logic.Interface;

namespace Riot.Client.Logic.Services
{
    public class FriendService : IFriendService

    {
        private readonly IFriendRepository _repository;
        private readonly IMapper _mapper;

        public FriendService(IFriendRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public void Create(FriendDto friend)
        {
            var _friend = _mapper.Map<Friend>(friend);
            _repository.Create(_friend);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public FriendDto Get(int Id)
        {
            return _mapper.Map<FriendDto>(_repository.Get(Id));
        }

        public List<FriendDto> GetAll()
        {
            return _mapper.Map<List<FriendDto>>(_repository.GetAll());

        }

        public void Update(FriendDto friend)
        {
            var _friend = _mapper.Map<Friend>(friend);
            _repository.Update(_friend);
        }
    }
}
