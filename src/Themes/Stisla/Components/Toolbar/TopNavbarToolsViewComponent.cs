using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Themes.Stisla.Components.Toolbar
{
    public class TopNavbarToolsViewComponent : AbpViewComponent
    {
        private readonly IToolbarManager _toolbarManager;

        public TopNavbarToolsViewComponent(IToolbarManager toolbarManager)
        {
            _toolbarManager = toolbarManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var toolbar = await _toolbarManager.GetAsync(StandardToolbars.Main);
            return View("~/Themes/Stisla/Components/Toolbar/Default.cshtml", toolbar);
        }
    }
}
