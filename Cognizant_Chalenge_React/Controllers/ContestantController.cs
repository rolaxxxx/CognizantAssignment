using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cognizant_Chalenge_React.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContestantController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ContestantController> _logger;

        public ContestantController(ILogger<ContestantController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Contestant> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Contestant
            {
                
            })
            .ToArray();
        }
    }
}
