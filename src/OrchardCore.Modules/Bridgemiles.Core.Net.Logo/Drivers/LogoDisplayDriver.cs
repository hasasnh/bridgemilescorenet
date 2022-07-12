using Bridgemiles.Core.Net.Logo.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.Logo.Drivers
{
    public class LogoDisplayDriver : ContentPartDisplayDriver<Models.Logo>
    {
        private readonly IOrchardHelper _orchardHelper;

        public LogoDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(Models.Logo part, BuildPartDisplayContext context)
        {
            return Initialize<LogoViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(Models.Logo part, LogoViewModel viewModel)
        {
            viewModel.Svg = (string)part.ContentItem.Content.Logo.Svg.Paths[0];
            viewModel.SvgDark = (string)part.ContentItem.Content.Logo.SvgDark.Paths[0];
            viewModel.link = (string)part.ContentItem.Content.Logo.Link.Url;
        }
    }
}
