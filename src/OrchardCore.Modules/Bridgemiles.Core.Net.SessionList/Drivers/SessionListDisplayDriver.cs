using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;
using Bridgemiles.Core.Net.SessionList.Models;
using Bridgemiles.Core.Net.SessionList.ViewModels;

namespace Bridgemiles.Core.Net.SessionList.Drivers
{
    public class SessionListDisplayDriver : ContentPartDisplayDriver<Models.SessionPart>
    {
        private readonly IOrchardHelper _orchardHelper;

        public SessionListDisplayDriver(IOrchardHelper orchardHelper)
        {
            _orchardHelper = orchardHelper;
        }

        public override IDisplayResult Display(Models.SessionPart part, BuildPartDisplayContext context)
        {
            return Initialize<SessionListViewModel>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private static void PopulateViewModel(Models.SessionPart part, SessionListViewModel viewModel)
        {

            var relatedSessionList = part.ContentItem.Content.RelatedSessionBag?.ContentItems;
            //viewModel.RelatedSession = new System.Collections.Generic.List<Models.RelatedSession>();

            //if (relatedSessionList != null)
            //{
            //    foreach (var bag in relatedSessionList)
            //    {
            //        RelatedSession session = new Models.RelatedSession();
            //        session.Img = (string)bag.ReleatedSession.Img.Paths[0];
            //        session.Title = (string)bag.ReleatedSession.Title.Text;
            //        session.Link = (string)bag.ReleatedSession.YoutubeURL.Text;
            //        session.URL = (string)bag.ReleatedSession.YoutubeURL.Url;
            //        viewModel.RelatedSession.Add(session);
            //    }
            //}

            viewModel.URL = part.Link.Url;
            viewModel.PowerPoint = part.PowerPoint.Url;
            viewModel.SourceCode = part.SourceCode.Url;
            viewModel.Title = part.Title.Text;
            viewModel.Description = part.Description.Text;
            viewModel.ModifiedUtc = part.ContentItem.ModifiedUtc?.ToString();

        }
    }
}
