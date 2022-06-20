using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.Menu.Models
{
    public class ContainedPart
    {
        public string ListContentItemId { get; set; }
        public int Order { get; set; }
    }



    public class CustomClientWithListPart
    {
        public CustomClient CustomClient { get; set; }
        public TitlePart TitlePart { get; set; }
        public ContainedPart ContainedPart { get; set; }
    }


}
