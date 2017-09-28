using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using SSoft.PhoneBook.EntityFramework;

namespace SSoft.PhoneBook.Migrator
{
    [DependsOn(typeof(PhoneBookDataModule))]
    public class PhoneBookMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<PhoneBookDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}