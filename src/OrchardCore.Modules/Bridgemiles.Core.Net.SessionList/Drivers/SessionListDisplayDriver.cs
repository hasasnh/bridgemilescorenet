using OrchardCore;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;
using Bridgemiles.Core.Net.SessionList.Models;
using Bridgemiles.Core.Net.SessionList.ViewModels;
using YesSql;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Records;
using System.Collections.Generic;
using System;

namespace Bridgemiles.Core.Net.SessionList.Drivers
{
    public class SessionListDisplayDriver : ContentPartDisplayDriver<Models.SessionList>
    {
        private readonly IOrchardHelper _orchardHelper;
        private readonly ISession _session;
        private readonly IContentManager _contentManager;

        public SessionListDisplayDriver(IOrchardHelper orchardHelper, ISession session, IContentManager contentManager)
        {
            _orchardHelper = orchardHelper;
            _session = session;
            _contentManager = contentManager;

        }

        public override IDisplayResult Display(Models.SessionList part, BuildPartDisplayContext context)
        {

            return Initialize<Bridgemiles.Core.Net.SessionList.ViewModels.SessionList>(GetDisplayShapeType(context), viewModel => PopulateViewModel(part, viewModel)).Location("Detail", "Content:5").Location("Summary", "Content:5");
        }

        private async Task<List<SessionListViewModel>> List()
        {
            List<SessionListViewModel> sessionListViewModelList = new List<SessionListViewModel>();

            var sessionList = await _session
                                     .Query<ContentItem, ContentItemIndex>(x => x.ContentType == "SeesionItem" && x.Latest == true)
                                     .ListAsync();
            foreach (var session in sessionList)
            {
                try
                {
                    var loadedSession = await _contentManager.LoadAsync(session);
                    SessionListViewModel sessionListViewModel = new SessionListViewModel();
                    sessionListViewModel.Title = session.ContentItem.Content.NewSessionPart.Title.Text;
                    sessionListViewModel.URL = session.ContentItem.Content.NewSessionPart.VideoLink.Url;
                    sessionListViewModel.PageURL = session.ContentItem.Content.NewSessionPart.VideoLink.Text;
                    sessionListViewModel.Description = session.ContentItem.Content.NewSessionPart.Description.Text;
                    sessionListViewModel.PowerPoint = session.ContentItem.Content.NewSessionPart.PowerPoint.Url;
                    sessionListViewModel.SourceCode = session.ContentItem.Content.NewSessionPart.SourceCode.Url;
                    sessionListViewModel.ModifiedUtc = session.ContentItem.ContentItem.ModifiedUtc?.ToString();
                    sessionListViewModelList.Add(sessionListViewModel);
                }
                catch (Exception ex)
                {

                }

            }

            return sessionListViewModelList;
        }
        private void PopulateViewModel(Models.SessionList part, Bridgemiles.Core.Net.SessionList.ViewModels.SessionList viewModelList)
        {
            viewModelList.RelatedSession = new List<SessionListViewModel>();
            viewModelList.RelatedSession = List().Result; 

        }
    }
}
