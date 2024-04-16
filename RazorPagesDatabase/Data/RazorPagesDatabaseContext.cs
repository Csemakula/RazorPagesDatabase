using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesDatabase.Models;

namespace RazorPagesDatabase.Data
{
    public class RazorPagesDatabaseContext : DbContext
    {
        public RazorPagesDatabaseContext (DbContextOptions<RazorPagesDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesDatabase.Models.Movie> Movie { get; set; } = default!;
    }
}
