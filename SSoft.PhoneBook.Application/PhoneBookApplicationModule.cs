using System.Reflection;
using Abp.AutoMapper;
using Abp.Localization;
using Abp.Modules;
using SSoft.PhoneBook.Authorization;

namespace SSoft.PhoneBook
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(typeof(PhoneBookCoreModule))]
    public class PhoneBookApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper mappings
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                CustomDtoMapper.CreateMappings(mapper);
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
