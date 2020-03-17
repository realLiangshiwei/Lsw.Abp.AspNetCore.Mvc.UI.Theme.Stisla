using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Bootstrap;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.DatatablesNetBs4;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.JQuery;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.JQueryForm;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.JQueryValidationUnobtrusive;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Lodash;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Luxon;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.MalihuCustomScrollbar;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Select2;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.SweetAlert;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Timeago;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Toastr;
using Volo.Abp.Modularity;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Bundling
{
    [DependsOn(
        typeof(JQueryScriptContributor),
        typeof(LodashScriptContributor),
        typeof(JQueryValidationUnobtrusiveScriptContributor),
        typeof(JQueryFormScriptContributor),
        typeof(Select2ScriptContributor),
        typeof(DatatablesNetBs4ScriptContributor),
        typeof(SweetalertScriptContributor),
        typeof(ToastrScriptBundleContributor),
        typeof(MalihuCustomScrollbarPluginScriptBundleContributor),
        typeof(LuxonScriptContributor),
        typeof(TimeagoScriptContributor),
        typeof(BootstrapDatepickerScriptContributor)
    )]
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

            context.Files.AddRange(new[]
            {
                "/libs/abp/aspnetcore-mvc-ui-theme-shared/jquery/jquery-extensions.js",
                "/libs/abp/aspnetcore-mvc-ui-theme-shared/jquery-form/jquery-form-extensions.js",
                "/libs/abp/aspnetcore-mvc-ui-theme-shared/jquery/widget-manager.js",
                "/libs/abp/aspnetcore-mvc-ui-theme-shared/bootstrap/dom-event-handlers.js",
                "/libs/abp/aspnetcore-mvc-ui-theme-shared/bootstrap/modal-manager.js",
                "/libs/abp/aspnetcore-mvc-ui-theme-shared/datatables/datatables-extensions.js",
                "/libs/abp/aspnetcore-mvc-ui-theme-shared/sweetalert/abp-sweetalert.js",
                "/libs/abp/aspnetcore-mvc-ui-theme-shared/toastr/abp-toastr.js"
            });
        }
    }
}
