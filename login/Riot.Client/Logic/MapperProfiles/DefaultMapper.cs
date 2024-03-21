using AutoMapper;
using Riot.Client.Domain.Models;
using Riot.Client.Logic.Dto;

namespace Riot.Client.Logic.MapperProfiles
{
    public class DefaultMapper : Profile
    {
        public DefaultMapper()
        {
            CreateMap<UserDto, User>().ReverseMap();
            //o AutoMapper irá pegar o valor das entidades que estão no banco (sendo espelhadas pelas models)
            //e aplicará no Dto
            CreateMap<FriendDto, Friend>().ReverseMap();
            //Esse ReverseMap nos permite transformar User comum em DTO e DTO em User comum
            //Friends tbm
        }
    }
}
