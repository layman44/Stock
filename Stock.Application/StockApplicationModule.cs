using System.Reflection;
using Abp.Modules;

namespace Stock
{
    [DependsOn(typeof(StockCoreModule))]
    public class StockApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            DtoMappings.Map();
        }
    }
}
