using Bridgemiles.Core.Net.Session.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.Session.ViewModels
{
    public class SessionViewModel
    {
        public string URL { get; set; }
        public string PowerPoint { get; set; }
        public string SourceCode { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string ModifiedUtc{ get; set; }
        public List<RelatedSession> RelatedSession { get; set; }
    }
}
