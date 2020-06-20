using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ELAP.EntityFrameworkCore;
using ELAP.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ELAP.Web.Tests
{
    [DependsOn(
        typeof(ELAPWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ELAPWebTestModule : AbpModule
    {
        public ELAPWebTestModule(ELAPEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ELAPWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ELAPWebMvcModule).Assembly);
        }
    }
}