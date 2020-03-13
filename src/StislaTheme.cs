using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla
{
    [ThemeName(Name)]
    public class StislaTheme : ITheme, ITransientDependency
    {
        public const string Name = "Stisla";

        public string GetLayout(string name, bool fallbackToDefault = true)
        {
            switch (name)
            {
                case StandardLayouts.Application:
                    return "~/Themes/Stisla/Layouts/Application.cshtml";
                case StandardLayouts.Account:
                    return "~/Themes/Stisla/Layouts/Account.cshtml";
                case StandardLayouts.Empty:
                    return "~/Themes/Stisla/Layouts/Empty.cshtml";
                default:
                    return fallbackToDefault ? "~/Themes/Stisla/Layouts/Application.cshtml" : null;
            }
        }
    }
}
