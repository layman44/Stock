using Abp.Application.Navigation;

namespace Stock.Web.Models.Layout
{
    public class SiderMenuViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}