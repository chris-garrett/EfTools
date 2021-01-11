using Microsoft.EntityFrameworkCore;

namespace EfTools.Data
{
    public static class AppDbContextOptionsFactory
    {
        public static DbContextOptions<AppDbContext> UseSqlite(string connectionString)
        {
            return new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(connectionString)
                .Options;
        }

        // public static DbContextOptions<AppDbContext> UsePostgres(string connectionString)
        // {
        //     return new DbContextOptionsBuilder<AppDbContext>()
        //         .UseNpgsql(connectionString)
        //         .Options;
        // }
    }
}