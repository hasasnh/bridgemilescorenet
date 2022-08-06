using Bridgemiles.Core.Net.Statistics.Models;
using Bridgemiles.Core.Net.Statistics.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.Statistics.Drivers
{
    public class StatisticsDisplayDriver : ContentPartDisplayDriver<Models.Statistics>
    {
        private readonly IOrchardHelper _orchardHelper;

        public StatisticsDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(Models.Statistics part, BuildPartDisplayContext context)
        {
            return Initialize<StatisticsViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(Models.Statistics part, StatisticsViewModel viewModel)
        {
            var SymbolList = part.ContentItem.Content.SymbolBag.ContentItems;
            viewModel.SymbolList = new System.Collections.Generic.List<Models.Symbol>();

            foreach (var bag in SymbolList)
            {
                Symbol sym = new Models.Symbol();
                sym.Svg = (string)bag.Symbol.Svg.Paths[0];
                sym.Value = (string)bag.Symbol.Value.Text;
                sym.Label = (string)bag.Symbol.Label.Text;
                viewModel.SymbolList.Add(sym);
            }

            viewModel.Title = part.Title.Text;
            viewModel.Description = part.Description.Text;
            viewModel.SecoundDescription = part.SecoundDescription.Text;

            viewModel.Testimonial = new Testimonial();
            viewModel.Testimonial.Author = part.ContentItem.Content.Testimonial.Author.Text;
            viewModel.Testimonial.AuthorPosition = part.ContentItem.Content.Testimonial.AuthorPosition.Text;
            viewModel.Testimonial.FSpan = part.ContentItem.Content.Testimonial.FSpan.Text;
            viewModel.Testimonial.SSpan = part.ContentItem.Content.Testimonial.SSpan.Text;
            viewModel.Testimonial.TSpan = part.ContentItem.Content.Testimonial.TSpan.Text;
        }
    }
}
