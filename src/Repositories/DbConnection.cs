using Microsoft.EntityFrameworkCore;

using MovieFinder.Models;

namespace MovieFinder.Repositories
{
    public class DbConnection : DbContext
    {
        internal DbSet<Movie> Movies { get; set; } = null!;
        internal DbSet<Platform> Platforms { get; set; } = null!;

        public string ConnectionString { get; }

        public DbConnection(string connection_string)
        {
            ConnectionString = connection_string;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql($"{ConnectionString}");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Movie>(entity =>
            {
                entity.ToTable("movies");
            });
            builder.Entity<Platform>(entity =>
            {
                entity.ToTable("platforms");
            });
        }
    }
}