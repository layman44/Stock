using Abp.Web.Mvc.Views;

namespace Stock.Web.Views
{
    public abstract class StockWebViewPageBase : StockWebViewPageBase<dynamic>
    {

    }

    public abstract class StockWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected StockWebViewPageBase()
        {
            LocalizationSourceName = StockConsts.LocalizationSourceName;
        }
    }
}