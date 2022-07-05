using Bridgemiles.Core.Net.Menu.Models;
using Bridgemiles.Core.Net.Menu.ViewModels;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.Menu.Drivers
{
    public class EmployeeDisplayDriver : ContentPartDisplayDriver<Employee>
    {
        public override IDisplayResult Display(Employee part, BuildPartDisplayContext context) =>
           Initialize<HeroHeadingViewModel>(
               GetDisplayShapeType(context),
               viewModel => PopulateViewModel(part, viewModel))
           .Location("Detail", "Content:5")
           .Location("Summary", "Content:5");

        public override IDisplayResult Edit(Employee part, BuildPartEditorContext context) =>
    Initialize<HeroHeadingViewModel>(
        GetEditorShapeType(context),
        viewModel => PopulateViewModel(part, viewModel))
    .Location("Content:5");

        public override async Task<IDisplayResult> UpdateAsync(Employee part, IUpdateModel updater, UpdatePartEditorContext context)
        {
            var viewModel = new HeroHeadingViewModel();

            await updater.TryUpdateModelAsync(viewModel, Prefix);

            part.logo = viewModel.logo;
            part.link = viewModel.link;

            return await EditAsync(part, context);
        }

        private static void PopulateViewModel(Employee part, HeroHeadingViewModel viewModel)
        {
            viewModel.logo = part.logo;
            viewModel.link = part.link;
        }
    }
}
