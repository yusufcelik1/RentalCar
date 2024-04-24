using Microsoft.EntityFrameworkCore;
using Repository.Efcore;

namespace WebApp
{
    public class RepositoryContextFactory
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                prj => prj.MigrationsAssembly("Repository"));

            return new RepositoryContext(builder.Options);
        }
    }
}
