using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ELAP.EntityFrameworkCore
{
    public static class ELAPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ELAPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ELAPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
