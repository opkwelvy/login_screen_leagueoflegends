using Riot.Client.Data.Interfaces;
using Riot.Client.Domain.Models;

namespace Riot.Client.Data.Repositories
{
    public class FriendRepository : IFriendRepository
    {
        private readonly Context _context;
        public FriendRepository(Context context)
        {
            _context = context;  
        }
        public void Create(Friend friend)
        {
            _context.Friend.Add(friend);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var friend = _context.Friend.Find(Id);
            _context.Friend.Remove(friend);
            _context.SaveChanges();

        }

        public Friend Get(int Id)
        {
            return _context.Friend.Find(Id);
        }

        public List<Friend> GetAll()
        {
            return _context.Friend.ToList();
        }

        public void Update(Friend friend)
        {
            _context.Friend.Update(friend);
            _context.SaveChanges();

        }
    }
}
