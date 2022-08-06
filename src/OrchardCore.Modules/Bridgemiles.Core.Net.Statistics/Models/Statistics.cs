using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.Statistics.Models
{
    public class Statistics : ContentPart
    {
        public TextField Title { get; set; }
        public TextField Description { get; set; }
        public TextField SecoundDescription { get; set; }

        public TextField FSpan { get; set; }
        public TextField SSpan { get; set; }
        public TextField TSpan { get; set; }
        public TextField Author { get; set; }
        public TextField AuthorPosition { get; set; }
    }
}
