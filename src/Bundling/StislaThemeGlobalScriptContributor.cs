using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Bundling
{
    public class StislaThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/stisla/assets/modules/popper.js");
            context.Files.Add("/themes/stisla/assets/modules/tooltip.js");
            context.Files.Add("/themes/stisla/assets/modules/nicescroll/jquery.nicescroll.js");
            context.Files.Add("/themes/stisla/assets/modules/moment.min.js");
            context.Files.Add("/themes/stisla/assets/js/stisla.js");
            context.Files.Add("/themes/stisla/assets/js/scripts.js");
            context.Files.Add("/themes/stisla/assets/js/custom.js");
        }
    }
}
