using EfSamurai.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfSamurai.Data
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<SpecialMove> SpecialMoves { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<QuoteCategory> QuoteCategories { get; set; }
        public DbSet<Haircut> Haircuts { get; set; }
        public DbSet<SecretIdentity> SecretIdentities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = EfSamurai;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SecretIdentity>()
                .HasAlternateKey(x => x.SamuraiId);
        }
    }
}
