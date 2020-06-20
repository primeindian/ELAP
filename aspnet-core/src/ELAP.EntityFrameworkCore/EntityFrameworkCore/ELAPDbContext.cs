using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ELAP.Authorization.Roles;
using ELAP.Authorization.Users;
using ELAP.MultiTenancy;

namespace ELAP.EntityFrameworkCore
{
    public class ELAPDbContext : AbpZeroDbContext<Tenant, Role, User, ELAPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ELAPDbContext(DbContextOptions<ELAPDbContext> options)
            : base(options)
        {
        }
    }
}
