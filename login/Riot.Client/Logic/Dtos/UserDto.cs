namespace Riot.Client.Logic.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public string EmailConfirmed { get; set; }

        public virtual List<FriendDto> Friends { get; set; }
    }
}

