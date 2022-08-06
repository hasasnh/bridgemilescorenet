using Bridgemiles.Core.Net.HowItWorks.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.HowItWorks.Drivers
{
    public class HowItWorksDisplayDriver : ContentPartDisplayDriver<Models.HowItWorks>
    {
        private readonly IOrchardHelper _orchardHelper;

        public HowItWorksDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(Models.HowItWorks part, BuildPartDisplayContext context)
        {
            return Initialize<HowItWorksViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(Models.HowItWorks part, HowItWorksViewModel viewModel)
        {
            var storyList = part.ContentItem.Content.BagPart.ContentItems;
            var productList = part.ContentItem.Content.Product.ContentItems;
            viewModel.StoryList = new System.Collections.Generic.List<Models.Story>();
            viewModel.ProductList = new System.Collections.Generic.List<Models.Product>();
            foreach (var bag in storyList)
            {
                Bridgemiles.Core.Net.HowItWorks.Models.Story sto = new Bridgemiles.Core.Net.HowItWorks.Models.Story();
                sto.Illustration = (string)bag.Story.Illustration.Paths[0];
                sto.Title = (string)bag.Story.Title.Text;
                sto.Description = (string)bag.Story.Description.Text;
                sto.Badge = (string)bag.Story.Badge.Text;
                viewModel.StoryList.Add(sto);
            }

            foreach (var product in productList)
            {
                Models.Product pro = new Models.Product();
                pro.Img = (string)product.Product.Img.Paths[0];
                viewModel.ProductList.Add(pro);
            }
            viewModel.Title = part.Title.Text;
            viewModel.Description = part.Description.Text;
            viewModel.SecoundDescription = part.SecoundDescription.Text;
        }
    }
}
