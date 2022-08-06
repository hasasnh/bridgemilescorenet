using Bridgemiles.Core.Net.Story.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.HowItWorks.ViewModels
{
    public class HowItWorksViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string SecoundDescription { get; set; }

        public List<Bridgemiles.Core.Net.HowItWorks.Models.Story> StoryList { get; set; }
        public List<Bridgemiles.Core.Net.HowItWorks.Models.Product> ProductList { get; set; }

    }
}
