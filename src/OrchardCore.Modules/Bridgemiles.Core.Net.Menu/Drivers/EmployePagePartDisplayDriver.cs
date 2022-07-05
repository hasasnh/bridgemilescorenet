using Bridgemiles.Core.Net.Menu.Models;
using Bridgemiles.Core.Net.Menu.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.Menu.Drivers
{
    public class EmployePagePartDisplayDriver : ContentPartDisplayDriver<EmployePagePart>
    {
        private readonly IOrchardHelper _orchardHelper;

        public EmployePagePartDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }
        public override IDisplayResult Display(EmployePagePart part, BuildPartDisplayContext context)
        {
            var x = _orchardHelper.QueryListItemsAsync("4wzv3pq6wx49ds8jy0cnhm5txb");
            var xx = _orchardHelper.QueryListItemsAsync("480hpm1pzhdxk1rrxbx45rhxdj");

            return Initialize<HeroHeadingViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel()).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }
        private static void PopulateViewModel()
        {

        }

    }

}
