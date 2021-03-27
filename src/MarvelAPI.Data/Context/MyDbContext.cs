using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MarvelAPI.Data.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Character> Character { get; set; }
        public DbSet<CharacterData> CharacterData { get; set; }
        public DbSet<CharacterInformation> CharacterInformation { get; set; }
        public DbSet<Comics> Comics { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Stories> Stories { get; set; }
        public DbSet<Thumbnail> Thumbnail { get; set; }
        public DbSet<Url> Url  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
