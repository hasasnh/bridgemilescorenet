using Bridgemiles.Core.Net.ProjectSection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.ProjectSection.ViewModels
{
    public class ProjectSectionViewModel
    {
        public string Title { get; set; }
        public List<Card> CardList { get; set; }

    }
}
