using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocatorBackEnd;

namespace LocatorBackEnd.Data
{
    public class LocatorBackEndContext : DbContext
    {
        public LocatorBackEndContext (DbContextOptions<LocatorBackEndContext> options)
            : base(options)
        {
        }

        public DbSet<LocatorBackEnd.Location> Location { get; set; } = default!;
    }
}
