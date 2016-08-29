using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Stock
{
    [DependsOn(typeof(AbpWebApiModule), typeof(StockApplicationModule))]
    public class StockWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(StockApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
