using System.Reflection;
using Abp.Modules;

namespace Stock
{
    public class StockCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
