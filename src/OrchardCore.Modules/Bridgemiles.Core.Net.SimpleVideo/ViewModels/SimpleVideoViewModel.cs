using Bridgemiles.Core.Net.SimpleVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.Session.ViewModels
{
    public class SimpleVideoViewModel
    {
        public string URL { get; set; }
        public string PowerPoint { get; set; }
        public string SourceCode { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string ModifiedUtc{ get; set; }
    }
}
