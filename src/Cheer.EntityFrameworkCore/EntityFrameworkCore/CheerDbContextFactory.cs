using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Cheer.Configuration;
using Cheer.Web;

namespace Cheer.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CheerDbContextFactory : IDesignTimeDbContextFactory<CheerDbContext>
    {
        public CheerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CheerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CheerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CheerConsts.ConnectionStringName));

            return new CheerDbContext(builder.Options);
        }
    }
}
