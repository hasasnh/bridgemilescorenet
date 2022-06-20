using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.Menu.Models
{

    public class FlowMetadata
    {
        public int Alignment { get; set; }
        public int Size { get; set; }
    }

    public class MainRoot
    {
        public CustomClient CustomClient { get; set; }
        public TitlePart TitlePart { get; set; }
        public FlowMetadata FlowMetadata { get; set; }
    }


}
