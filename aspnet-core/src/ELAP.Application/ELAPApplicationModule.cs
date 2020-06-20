using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ELAP.Authorization;

namespace ELAP
{
    [DependsOn(
        typeof(ELAPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ELAPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ELAPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ELAPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
