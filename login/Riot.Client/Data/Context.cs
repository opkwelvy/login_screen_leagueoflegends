using Microsoft.EntityFrameworkCore;
using Riot.Client.Domain.Models;

namespace Riot.Client.Data
{
    public class Context: DbContext
    {
        public DbSet<User> User { get; set; }
        //Esse código mapeia a classe User dentro da tabela 
        public DbSet<Friend> Friend { get; set; }

        public Context(DbContextOptions<Context> options): base(options)
        { 
        }
    }
}
