using Bridgemiles.Core.Net.TeamSection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgemiles.Core.Net.TeamSection.ViewModels
{
    public class TeamSectionViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string SecoundDescription { get; set; }

        public List<Team> TeamList { get; set; }

    }
}
