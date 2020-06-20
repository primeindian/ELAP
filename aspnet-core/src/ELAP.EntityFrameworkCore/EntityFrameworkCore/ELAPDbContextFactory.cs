using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ELAP.Configuration;
using ELAP.Web;

namespace ELAP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ELAPDbContextFactory : IDesignTimeDbContextFactory<ELAPDbContext>
    {
        public ELAPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ELAPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ELAPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ELAPConsts.ConnectionStringName));

            return new ELAPDbContext(builder.Options);
        }
    }
}
