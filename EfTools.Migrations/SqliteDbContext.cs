using Microsoft.EntityFrameworkCore;

namespace EfTools.Migrations
{
    public class SqliteDbContext : AppDbContext
    {
        public SqliteDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}