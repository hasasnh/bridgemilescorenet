using Bridgemiles.Core.Net.Story.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.Story.Drivers
{
    public class StoryDisplayDriver : ContentPartDisplayDriver<Models.Story>
    {
        private readonly IOrchardHelper _orchardHelper;

        public StoryDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(Models.Story part, BuildPartDisplayContext context)
        {
            return Initialize<List<StoryViewModel>>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(Models.Story part, List<StoryViewModel> viewModel)
        {
            StoryViewModel storyViewModel = new StoryViewModel();
            storyViewModel.Illustration = (string)part.ContentItem.Content.Story.Illustration.Paths[0];
            storyViewModel.Description = part.Description.Text;
            storyViewModel.Badge = part.Badge.Text;
            storyViewModel.Title = part.Title.Text;
            viewModel.Add(storyViewModel);
        }
    }
}
