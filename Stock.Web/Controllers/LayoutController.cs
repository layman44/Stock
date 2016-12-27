using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Localization;
using Abp.Threading;
using Stock.Web.Models.Layout;

namespace Stock.Web.Controllers
{
    public class LayoutController : StockControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ILocalizationManager _localizationManager;

        public LayoutController(IUserNavigationManager userNavigationManager, ILocalizationManager localizationManager)
        {
            _userNavigationManager = userNavigationManager;
            _localizationManager = localizationManager;
        }

        [ChildActionOnly]
        public PartialViewResult TopMenu(string activeMenu = "")
        {
            //var user = new Abp.UserIdentifier(null, AbpSession.UserId.Value);
            var model = new TopMenuViewModel
                        {
                            MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.UserId)),
                            ActiveMenuItemName = activeMenu
                        };

            return PartialView("_TopMenu", model);
        }

        [ChildActionOnly]
        public PartialViewResult SiderMenu(string activeMenu = "")
        {
            //var user = new Abp.UserIdentifier(null, AbpSession.UserId.Value);
            var model = new SiderMenuViewModel
            {
                MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.UserId)),
                ActiveMenuItemName = activeMenu
            };

            return PartialView("_SiderMenu", model);
        }
        [ChildActionOnly]
        public PartialViewResult LanguageSelection()
        {
            var model = new LanguageSelectionViewModel
                        {
                            CurrentLanguage = _localizationManager.CurrentLanguage,
                            Languages = _localizationManager.GetAllLanguages()
                        };

            return PartialView("_LanguageSelection", model);
        }
    }
}