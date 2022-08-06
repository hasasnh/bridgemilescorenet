using Bridgemiles.Core.Net.Statistics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.Statistics.ViewModels
{
    public class StatisticsViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string SecoundDescription { get; set; }

        public Testimonial Testimonial { get; set; }
        public List<Symbol> SymbolList { get; set; }

    }
}
