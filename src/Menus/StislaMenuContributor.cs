using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Menus
{
    public class StislaMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            context.Menu.Items.Insert(1, new ApplicationMenuItem("Stisla.Dashboard", "Dashboard", "/Dashboard", icon: "fas fa-fire"));
        }
    }
}
