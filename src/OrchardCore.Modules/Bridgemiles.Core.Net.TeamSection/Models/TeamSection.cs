using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.TeamSection.Models
{
    public class TeamSection : ContentPart
    {
        public TextField Title { get; set; }
        public TextField Description { get; set; }
        public TextField SecoundDescription { get; set; }
    }
}
