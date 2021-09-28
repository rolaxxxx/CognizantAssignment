using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cognizant_Chalenge_React
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Contestant> Contestants { get; set; }

        public DbSet<ContestantSolutions> ContestantsSolutions { get; set; }
    }
}
