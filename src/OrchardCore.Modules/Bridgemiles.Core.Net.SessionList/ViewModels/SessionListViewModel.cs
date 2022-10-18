using Bridgemiles.Core.Net.SessionList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.SessionList.ViewModels
{
    public class SessionListViewModel
    {
        public string URL { get; set; }
        public string PowerPoint { get; set; }
        public string SourceCode { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string ModifiedUtc { get; set; }

        public string PageURL { get; set; }
    }
}
