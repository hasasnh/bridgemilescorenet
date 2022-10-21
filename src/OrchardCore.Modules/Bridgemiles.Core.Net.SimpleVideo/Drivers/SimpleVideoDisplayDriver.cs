using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;
using Bridgemiles.Core.Net.Session.ViewModels;
using Bridgemiles.Core.Net.SimpleVideo.Models;

namespace Bridgemiles.Core.Net.Session.Drivers
{
    public class SimpleVideoDisplayDriver : ContentPartDisplayDriver<SimpleVideo.Models.SimpleVideo>
    {
        private readonly IOrchardHelper _orchardHelper;

        public SimpleVideoDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(SimpleVideo.Models.SimpleVideo part, BuildPartDisplayContext context)
        {
            return Initialize<SimpleVideoViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(SimpleVideo.Models.SimpleVideo part, SimpleVideoViewModel viewModel)
        {

            viewModel.URL = part.Videolink.Url;
            viewModel.Title = part.Title.Text;
            viewModel.Description = part.Description.Text;
            viewModel.ModifiedUtc = part.ContentItem.ModifiedUtc?.ToString();

        }
    }
}
