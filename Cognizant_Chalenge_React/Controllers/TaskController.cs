using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cognizant_Chalenge_React.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private CatalogContext _context;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger, CatalogContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<List<Task>> Get()
        {
            Task task = new Task();
            task.Id = System.Guid.NewGuid();
            task.Name = "programming task";
            task.Description = "you should program it";
            await _context.Tasks.AddAsync(task);
            _context.SaveChanges();
            var tasks = await _context.Tasks
                .Select(task => task)
                .ToListAsync();
            return tasks;
        }
    }
}
