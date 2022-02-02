using DoubleDuel.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoubleDuel
{
    public class DoubleDuelsContext : DbContext
    {
        private const string connectionString = @"Server=.\SQLEXPRESS;Database=DoubleDuelDb;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(connectionString);
        }
        public DoubleDuelsContext()
        {

        }
        public DoubleDuelsContext (DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Hero> Heroes{ get; set; }
        public DbSet<StaticHero> StaticHeroes { get; set; }
        public DbSet<Skill> Skills{ get; set; }
       
       
      
    }
}
