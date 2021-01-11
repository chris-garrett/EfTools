using Microsoft.EntityFrameworkCore;

namespace EfTools.Data
{
    public class SqliteDbContext : AppDbContext
    {
        public SqliteDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}