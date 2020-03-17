using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Bundling
{
    public class StislaThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/stisla/assets/modules/bootstrap/css/bootstrap.css");
            context.Files.Add("/themes/stisla/assets/modules/fontawesome/css/all.css");
            context.Files.Add("/themes/stisla/assets/css/style.css");
            context.Files.Add("/themes/stisla/assets/css/components.css");
        }
    }
}
