using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Menus
{
    public class StislaMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Stisla.Dashboard", "Dashboard", "/Dashboard", icon: "fas fa-fire"));

            return Task.CompletedTask;
        }
    }
}
