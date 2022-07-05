using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.LandingHero.Models
{
    public class HeroHeading : ContentPart
    {
        public TextField Title { get; set; }
        public LinkField Action { get; set; }

    }
}
