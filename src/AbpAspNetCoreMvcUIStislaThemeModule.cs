using Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Bundling;
using Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Menus;
using Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Toolbars;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcUiThemeSharedModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
    )]
    public class AbpAspNetCoreMvcUiStislaThemeModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpAspNetCoreMvcUiStislaThemeModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpThemingOptions>(options =>
            {
                options.Themes.Add<StislaTheme>();

                if (options.DefaultThemeName == null)
                {
                    options.DefaultThemeName = StislaTheme.Name;
                }
            });

            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpAspNetCoreMvcUiStislaThemeModule>("Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla");
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new StislaThemeMainTopToolbarContributor());
            });

            Configure<AbpBundlingOptions>(options =>
            {
                options
                    .StyleBundles
                    .Add(StislaThemeBundles.Styles.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Styles.Global)
                            .AddContributors(typeof(StislaThemeGlobalStyleContributor));
                    });

                options
                    .ScriptBundles
                    .Add(StislaThemeBundles.Scripts.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Scripts.Global)
                            .AddContributors(typeof(StislaThemeGlobalScriptContributor));
                    });
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new StislaMenuContributor());
            });
        }
    }
}
