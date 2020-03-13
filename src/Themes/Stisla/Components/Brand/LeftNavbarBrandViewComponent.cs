using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Themes.Stisla.Components.Brand
{
    public class LeftNavbarBrandViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/Stisla/Components/Brand/Default.cshtml");
        }
    }
}
