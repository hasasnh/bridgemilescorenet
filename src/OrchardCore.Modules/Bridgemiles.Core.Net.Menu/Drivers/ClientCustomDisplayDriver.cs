using Bridgemiles.Core.Net.Menu.Models;
using Bridgemiles.Core.Net.Menu.ViewModels;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.Menu.Drivers
{
    public class ClientCustomDisplayDriver : ContentPartDisplayDriver<ClientCustom>
    {
        public override IDisplayResult Display(ClientCustom part, BuildPartDisplayContext context) =>
           Initialize<CustomClientPartViewModel>(
               GetDisplayShapeType(context),
               viewModel => PopulateViewModel(part, viewModel))
           .Location("Detail", "Content:5")
           .Location("Summary", "Content:5");

        public override IDisplayResult Edit(ClientCustom part, BuildPartEditorContext context) =>
    Initialize<CustomClientPartViewModel>(
        GetEditorShapeType(context),
        viewModel => PopulateViewModel(part, viewModel))
    .Location("Content:5");

        public override async Task<IDisplayResult> UpdateAsync(ClientCustom part, IUpdateModel updater, UpdatePartEditorContext context)
        {
            var viewModel = new CustomClientPartViewModel();

            await updater.TryUpdateModelAsync(viewModel, Prefix);

            part.logo = viewModel.logo;
            part.link = viewModel.link;

            return await EditAsync(part, context);
        }

        private static void PopulateViewModel(ClientCustom part, CustomClientPartViewModel viewModel)
        {
            viewModel.logo = part.logo;
            viewModel.link = part.link;
        }
    }
}
