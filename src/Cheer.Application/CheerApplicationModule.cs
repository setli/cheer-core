using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Cheer.Authorization;

namespace Cheer
{
    [DependsOn(
        typeof(CheerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CheerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CheerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CheerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
