using Abp.Web.Mvc.Controllers;

namespace Stock.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class StockControllerBase : AbpController
    {
        protected StockControllerBase()
        {
            LocalizationSourceName = StockConsts.LocalizationSourceName;
        }


    }
}