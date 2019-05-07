using System;
using Microsoft.EntityFrameworkCore;

namespace Player.Models
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext (DbContextOptions<CharacterDbContext> options) : base(options) { }

        public DbSet<Player.Models.Character> Characters { get; set; }
        public DbSet<Player.Models.Spell> Spells {get; set;}
        public DbSet<Player.Models.Item> Items {get; set;}


         protected override void OnModelCreating(ModelBuilder modelBuilder) //creating bridge table composit keys
        {
            modelBuilder.Entity<Char2Item>().ToTable("Items");

            modelBuilder.Entity<Char2Item>()
            .HasKey(mc => new { mc.CharacterID, mc.ItemID });

            modelBuilder.Entity<Char2Item>()
            .HasOne(c => c.Character)
            .WithMany(it => it.Items)
            .HasForeignKey(id => id.CharacterID);

            modelBuilder.Entity<Char2Item>()
            .HasOne(i => i.Items)
            .WithMany(c => c.Character)
            .HasForeignKey(id => id.ItemID);
        } 
    }
}