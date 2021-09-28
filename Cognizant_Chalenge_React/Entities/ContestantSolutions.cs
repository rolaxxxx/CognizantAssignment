using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cognizant_Chalenge_React
{
    public class ContestantSolutions
    {
        public Guid Id { get; set; }
        public String SolutionCode { get; set; }
        public String Solved { get; set; }

        public virtual Contestant Contestant { get; set; }
        public virtual Task Task { get; set; }
    }
}
