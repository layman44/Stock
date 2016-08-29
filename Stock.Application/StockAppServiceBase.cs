using Abp.Application.Services;

namespace Stock
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class StockAppServiceBase : ApplicationService
    {
        protected StockAppServiceBase()
        {
            LocalizationSourceName = StockConsts.LocalizationSourceName;
        }
    }
}