using Bridgemiles.Core.Net.ProjectSection.ViewModels;
using Bridgemiles.Core.Net.ProjectSection.Models;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.ProjectSection.Drivers
{
    public class ProjectSectionDisplayDriver : ContentPartDisplayDriver<Models.ProjectSection>
    {
        private readonly IOrchardHelper _orchardHelper;

        public ProjectSectionDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(Models.ProjectSection part, BuildPartDisplayContext context)
        {
            return Initialize<ProjectSectionViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(Models.ProjectSection part, ProjectSectionViewModel viewModel)
        {
            var cardList = part.ContentItem.Content.TabBag.ContentItems;
            viewModel.CardList = new System.Collections.Generic.List<Models.Card>();

            foreach (var bag in cardList)
            {
                Card card = new Models.Card();
                card.Img = (string)bag.Cart.Img.Paths[0];
                card.Img2 = (string)bag.Cart.Img2.Paths[0];
                card.Img3 = (string)bag.Cart.Img3.Paths[0];
                card.Img4 = (string)bag.Cart.Img4.Paths[0];
                card.Title = (string)bag.Cart.Name.Text;
                card.Link = (string)bag.Cart.Link.Text;
                viewModel.CardList.Add(card);
            }

            viewModel.Title = part.Title.Text;

        }
    }
}
