namespace Riot.Client.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public string EmailConfirmed { get; set; }

        public virtual List<Friend> Friends { get; set; }
    }
}
