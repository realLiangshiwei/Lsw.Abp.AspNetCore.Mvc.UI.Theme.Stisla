using System.Collections.Generic;
using Volo.Abp.Localization;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Themes.Stisla.Components.Toolbar.LanguageSwitch
{
    public class LanguageSwitchViewComponentModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public List<LanguageInfo> OtherLanguages { get; set; }
    }
}
