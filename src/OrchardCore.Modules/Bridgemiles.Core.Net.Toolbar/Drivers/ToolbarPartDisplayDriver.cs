using Bridgemiles.Core.Net.Toolbar.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.Toolbar.Drivers
{
    public class ToolbarPartDisplayDriver : ContentPartDisplayDriver<Bridgemiles.Core.Net.Toolbar.Models.ToolbarPart>
    {
        private readonly IOrchardHelper _orchardHelper;

        public ToolbarPartDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(Bridgemiles.Core.Net.Toolbar.Models.ToolbarPart part, BuildPartDisplayContext context)
        {
            return Initialize<ToolbarViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(Bridgemiles.Core.Net.Toolbar.Models.ToolbarPart part, ToolbarViewModel viewModel)
        {
            viewModel.Url = part.link.Url;
            viewModel.Text = part.link.Text;
        }
    }
}
