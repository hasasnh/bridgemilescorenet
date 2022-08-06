using Bridgemiles.Core.Net.TeamSection.Models;
using Bridgemiles.Core.Net.TeamSection.ViewModels;
using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;


namespace Bridgemiles.Core.Net.TeamSection.Drivers
{
    public class TeamSectionDisplayDriver : ContentPartDisplayDriver<Models.TeamSection>
    {
        private readonly IOrchardHelper _orchardHelper;

        public TeamSectionDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(Models.TeamSection part, BuildPartDisplayContext context)
        {
            return Initialize<TeamSectionViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(Models.TeamSection part, TeamSectionViewModel viewModel)
        {
            var TeamList = part.ContentItem.Content.TeamBag.ContentItems;
            viewModel.TeamList = new System.Collections.Generic.List<Models.Team>();

            foreach (var bag in TeamList)
            {
                Team team = new Models.Team();
                team.Img = (string)bag.Team.Img.Paths[0];
                team.Name = (string)bag.Team.Name.Text;
                team.Position = (string)bag.Team.Position.Text;
                viewModel.TeamList.Add(team);
            }

            viewModel.Title = part.Title.Text;
            viewModel.Description = part.Description.Text;
            viewModel.SecoundDescription = part.SecoundDescription.Text;

        }
    }
}
