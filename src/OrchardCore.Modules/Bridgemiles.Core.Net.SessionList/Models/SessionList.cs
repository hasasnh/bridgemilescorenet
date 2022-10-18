using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.SessionList.Models
{
    public class SessionList : ContentPart
    {
        public LinkField Link { get; set; }
        public LinkField PowerPoint { get; set; }
        public LinkField SourceCode { get; set; }

        public TextField Title { get; set; }
        public TextField Description { get; set; }
    }
}
