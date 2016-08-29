using Abp.Application.Navigation;
using Abp.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock.Web.Navigation
{
    public class StockNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        AppPageName.A,
                        new LocalizableString(AppPageName.A, StockConsts.LocalizationSourceName),
                        url: "#/",
                        icon: ""
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        AppPageName.B,
                        new LocalizableString(AppPageName.B, StockConsts.LocalizationSourceName),
                        url: "#/",
                        icon: ""
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        AppPageName.C,
                        new LocalizableString(AppPageName.C, StockConsts.LocalizationSourceName),
                        url: "#/",
                        icon: ""
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        AppPageName.D,
                        new LocalizableString(AppPageName.D, StockConsts.LocalizationSourceName),
                        url: "#/",
                        icon: ""
                    )
                );
        }
    }
}