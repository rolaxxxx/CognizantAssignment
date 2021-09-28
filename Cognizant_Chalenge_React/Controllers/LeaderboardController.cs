using Cognizant_Chalenge_React.Entities;
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
    public class LeaderboardController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<LeaderboardController> _logger;

        public LeaderboardController(ILogger<LeaderboardController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<LeaderBoard> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new LeaderBoard
            {

            })
            .ToArray();
        }
    }
}
