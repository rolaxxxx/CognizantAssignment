using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cognizant_Chalenge_React.Entities
{
    public class LeaderBoard
    {
        public Guid Id { get; set; }
        public List<Contestant> topContestants { get; set; }
        public String Description { get; set; }
    }
}
