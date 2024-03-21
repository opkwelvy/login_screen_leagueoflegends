using Riot.Client.Data.Interfaces;
using Riot.Client.Domain.Models;

namespace Riot.Client.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        //O Aplicativo em execução não permite que os métodos acessem o contexto
        public UserRepository(Context context)
        {
            _context = context;
        }
        public void Create(User user)
        {
            //Nós estamos acessando as tabelas criados no context (DbSet)
            _context.User.Add(user);
            _context.SaveChanges();

        }

        public void Delete(int Id)
        {
            var user = _context.User.Find(Id);
            _context.User.Remove(user);
            _context.SaveChanges();

        }

        public User Get(int Id)
        {
           return _context.User.Find(Id);

        }

        public List<User> GetAll()
        {
            return _context.User.ToList();
        }

        public void update(User user)
        {
            _context.User.Update(user);
            _context.SaveChanges();

        }
    }
}
