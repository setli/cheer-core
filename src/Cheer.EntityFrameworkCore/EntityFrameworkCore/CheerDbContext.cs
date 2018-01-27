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
        
        public CheerDbContext(DbContextOptions<CheerDbContext> options)
            : base(options)
        {
        }
    }
}
