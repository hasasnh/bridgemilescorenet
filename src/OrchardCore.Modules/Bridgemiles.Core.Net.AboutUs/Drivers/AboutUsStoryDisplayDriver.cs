using Bridgemiles.Core.Net.AboutUs.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.AboutUs.Drivers
{
    public class AboutUsStoryDisplayDriver : ContentPartDisplayDriver<Models.AboutUsStory>
    {
        private readonly IOrchardHelper _orchardHelper;

        public AboutUsStoryDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(Models.AboutUsStory part, BuildPartDisplayContext context)
        {
            return Initialize<AboutUsStoryViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(Models.AboutUsStory part, AboutUsStoryViewModel viewModel)
        {
            viewModel.URL = (string)part.ContentItem.Content.AboutUsStory.URL.Url;
        }
    }
}
