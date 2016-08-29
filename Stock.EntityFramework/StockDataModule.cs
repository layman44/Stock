using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Stock.EntityFramework;

namespace Stock
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(StockCoreModule))]
    public class StockDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<StockDbContext>(null);
        }
    }
}
