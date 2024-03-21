
using Riot.Client.Domain.Enums;

namespace Riot.Client.Domain.Models
{
    public class Friend
    {
        public string NickName { get; set; }
        public int FriendId { get; set;}

        public GameTypeEnum Game { get; set; }

        public StatusTypeEnum Status { get; set; }
    }

}
