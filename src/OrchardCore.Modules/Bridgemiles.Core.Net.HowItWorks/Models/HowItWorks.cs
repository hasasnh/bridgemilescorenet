using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.HowItWorks.Models
{
    public class HowItWorks : ContentPart
    {
        public TextField Title { get; set; }
        public TextField Description { get; set; }
        public TextField SecoundDescription { get; set; }
    }
}
