
# Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla

abp framework mvc ui theme package,It uses bootstrap, so it is compatible with abp tag helper.

 [![NuGet](https://img.shields.io/nuget/v/Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla)](https://www.nuget.org/packages/Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla/) [![NuGet](https://img.shields.io/nuget/dt/Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla)](https://www.nuget.org/packages/Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla/)

## Getting Started

Create a new project using abp CLI

* `abp new BookStore`

Install `Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla` nuget package to `.web` project:

* `Install-Package Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla`

Open the module class of the `.web` project and change `AbpAspNetCoreMvcUiBasicThemeModule` to `AbpAspNetCoreMvcUiStislaThemeModule`

Replace `BasicThemeBundles.Styles.Global` with `StislaThemeBundles.Styles.Global`

All done. Run the project and enjoy coding.

![](/images/1.png)

## More

[Stisla](https://github.com/stisla/stisla) Is a bootstrap-based admin template,see [stisla document](https://docs.getstisla.com/#/en/2.2.0/overview) for more information.