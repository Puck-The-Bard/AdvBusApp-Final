using Microsoft.EntityFrameworkCore;

namespace Player.Models
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext (DbContextOptions<CharacterDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player.Models.Character> Character { get; set; }
        public DbSet<Player.Models.Spell> Spell {get; set;}
         public DbSet<Player.Models.Item> Item {get; set;}
    }
}