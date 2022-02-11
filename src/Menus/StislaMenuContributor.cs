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

            return Task.CompletedTask;
        }
    }
}
