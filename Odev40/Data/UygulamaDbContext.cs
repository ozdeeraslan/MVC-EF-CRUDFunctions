using Microsoft.EntityFrameworkCore;

namespace Odev40.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }
        public DbSet<Oyun> Oyunlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oyun>().HasData(
                new Oyun() { Id = 1, Ad = "The Witcher 3: Wild Hunt", TekPlatform = true },
                new Oyun() { Id = 2, Ad = "Red Dead Redemption 2", TekPlatform = false },
                new Oyun() { Id = 3, Ad = "Cyberpunk 2077", TekPlatform = true },
                new Oyun() { Id = 4, Ad = "Assassin's Creed Valhalla", TekPlatform = false },
                new Oyun() { Id = 5, Ad = "FIFA 22", TekPlatform = false });
        }
    }
}
