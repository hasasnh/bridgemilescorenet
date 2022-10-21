using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.SimpleVideo.Models
{
    public class SimpleVideo : ContentPart
    {
        public LinkField Videolink { get; set; }
        public TextField Title { get; set; }
        public TextField Description { get; set; }
    }
}
