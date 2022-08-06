using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.Story.Models
{
    public class Story : ContentPart
    {
        public ContentPickerField Illustration { get; set; }
        public TextField Badge { get; set; }
        public TextField Title { get; set; }
        public TextField Description { get; set; }
    }
}
