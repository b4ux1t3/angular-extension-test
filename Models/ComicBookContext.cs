using Microsoft.EntityFrameworkCore;

namespace ComicCollector.Data
{
    public class ComicBookContext : DbContext
    {
        public ComicBookContext(DbContextOptions<ComicBookContext> options) : base(options)
        {

        }

        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}