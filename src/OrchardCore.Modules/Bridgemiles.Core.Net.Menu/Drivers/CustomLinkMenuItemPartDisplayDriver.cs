using Bridgemiles.Core.Net.Menu.Models;
using Bridgemiles.Core.Net.Menu.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.Menu.Drivers
{
    public class CustomLinkMenuItemPartDisplayDriver : ContentPartDisplayDriver<CustomMenu>
    {
        private readonly IOrchardHelper _orchardHelper;

        public CustomLinkMenuItemPartDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(CustomMenu part, BuildPartDisplayContext context)
        {
            return Initialize<List<LinkMenuItemPartViewModel>>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(CustomMenu part, List<LinkMenuItemPartViewModel> menuItems)
        {
            foreach(var menuItem in part.ContentItem.Content.MenuItemsListPart.MenuItems)
            {
                LinkMenuItemPartViewModel linkMenuItemPartViewModel = new LinkMenuItemPartViewModel();
                linkMenuItemPartViewModel.Title = (string)menuItem.LinkMenuItemPart.Name;
                linkMenuItemPartViewModel.Url = (string)menuItem.LinkMenuItemPart.Url;
                menuItems.Add(linkMenuItemPartViewModel);

            }
        }
    }
}
