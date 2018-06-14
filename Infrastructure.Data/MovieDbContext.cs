using Domain.Entities;
using System.Data.Entity;

namespace Infrastructure.Data
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
