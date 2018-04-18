using Abp.Localization;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Cheer.Authorization.Roles;
using Cheer.Authorization.Users;
using Cheer.MultiTenancy;

namespace Cheer.EntityFrameworkCore
{
    public class CheerDbContext : AbpZeroDbContext<Tenant, Role, User, CheerDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public CheerDbContext(DbContextOptions<CheerDbContext> options) : base(options)
        {
        }

        // add these lines to override max length of property
        // we should set max length smaller than the PostgreSQL allowed size (10485760)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760

            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("Sys", "ABP");
            base.OnModelCreating(modelBuilder);
        }
    }
}
