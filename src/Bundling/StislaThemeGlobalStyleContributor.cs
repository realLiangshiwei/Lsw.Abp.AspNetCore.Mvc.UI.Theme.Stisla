using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Core;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.DatatablesNetBs4;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.MalihuCustomScrollbar;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Select2;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Toastr;
using Volo.Abp.Modularity;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Bundling
{
    [DependsOn(
        typeof(CoreStyleContributor),
        typeof(ToastrStyleBundleContributor),
        typeof(Select2StyleContributor),
        typeof(MalihuCustomScrollbarPluginStyleBundleContributor),
        typeof(DatatablesNetBs4StyleContributor),
        typeof(BootstrapDatepickerStyleContributor)
    )]
    public class StislaThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/stisla/assets/modules/bootstrap/css/bootstrap.css");
            context.Files.Add("/themes/stisla/assets/modules/fontawesome/css/all.css");
            context.Files.Add("/themes/stisla/assets/css/style.css");
            context.Files.Add("/themes/stisla/assets/css/components.css");

            context.Files.AddRange(new[]
            {
                "/libs/abp/aspnetcore-mvc-ui-theme-shared/datatables/datatables-styles.css"
            });
        }
    }
}
