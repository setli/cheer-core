using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Cheer.EntityFrameworkCore
{
    public static class CheerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CheerDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CheerDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseNpgsql(connection);
        }
    }
}
