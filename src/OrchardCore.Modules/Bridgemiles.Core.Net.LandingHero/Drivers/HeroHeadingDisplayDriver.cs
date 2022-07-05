using Bridgemiles.Core.Net.LandingHero.Models;
using Bridgemiles.Core.Net.Menu.Models;
using Bridgemiles.Core.Net.Menu.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.LandingHero.Drivers
{
    public class HeroHeadingDisplayDriver : ContentPartDisplayDriver<HeroHeading>
    {
        private readonly IOrchardHelper _orchardHelper;

        public HeroHeadingDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(HeroHeading part, BuildPartDisplayContext context)
        {
            return Initialize<HeroHeadingViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(HeroHeading part, HeroHeadingViewModel heroHeadingViewModel)
        {
            heroHeadingViewModel.Clients = new System.Collections.Generic.List<Menu.Models.Client>();

            heroHeadingViewModel.Title = (string)part.Content.Title.Text;
            heroHeadingViewModel.Url = (string)part.Content.Action.Url;
            heroHeadingViewModel.Text = (string)part.Content.Action.Text;


            var clientList = part.ContentItem.Content.Clients.ContentItems;

            foreach (var client in clientList)
            {
                Client cl = new Client();
                cl.logo = (string)client.TitlePart.Title;
                cl.link = (string)client.Client.Logo.Paths[0];
                heroHeadingViewModel.Clients.Add(cl);
            }
        }
    }
}
