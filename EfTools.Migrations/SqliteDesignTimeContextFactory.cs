using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EfTools.Migrations
{
    public class SqliteDesignTimeContextFactory : IDesignTimeDbContextFactory<SqliteDbContext>
    {
        public SqliteDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();
            return new SqliteDbContext(
                AppDbContextOptionsFactory
                    .UseSqlite(configuration.GetConnectionString("Sqlite")));
        }
    } 
}