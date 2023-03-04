using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kamalova_LR1Cross.Models;

namespace Kamalova_LR1Cross.Data
{
    public class Kamalova_LR1CrossContext : DbContext
    {
        public Kamalova_LR1CrossContext (DbContextOptions<Kamalova_LR1CrossContext> options)
            : base(options)
        {
        }

        public DbSet<Kamalova_LR1Cross.Models.Movie> Movie { get; set; } = default!;
    }
}
