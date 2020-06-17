using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Themes.Stisla.Components.Menu
{
    public class LeftNavbarMenuViewComponent : AbpViewComponent
    {
        private readonly IMenuManager _menuManager;

        public LeftNavbarMenuViewComponent(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menu = await _menuManager.GetAsync(StandardMenus.Main);
            return View("~/Themes/Stisla/Components/Menu/Default.cshtml", menu);
        }

        public static bool ChildActive(ApplicationMenuItemList menu,string currentName)
        {
            foreach (var item in menu)
            {
                if (item.Name == currentName)
                {
                    return true;
                }

                if (ChildActive(item.Items, currentName))
                {
                    return true;
                }
            }
            return false;
        }

        public static string ReWriteIcon(string menu,string icon)
        {
            if (icon.IsNullOrEmpty())
            {
                return "fas";
            }

            switch (menu)
            {
                case "AbpIdentity":
                    return "fas fa-id-card";
                default:
                    return icon.StartsWith("fa ") ? icon.Replace("fa ", "fas ") : icon;
            }
        }
    }
}
