using Bridgemiles.Core.Net.LandingHero.Models;
using Bridgemiles.Core.Net.Menu.Models;
using OrchardCore.ContentFields.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.Menu.ViewModels
{
    public class HeroHeadingViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }

        public List<Client> Clients { get; set; }
    }
}
