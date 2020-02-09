using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VentureGG.Models;

namespace VentureGG.Data
{
    public class VentureGGContext : DbContext
    {
        public VentureGGContext (DbContextOptions<VentureGGContext> options)
            : base(options)
        {
        }

        public DbSet<VentureGG.Models.Users> Users { get; set; }
    }
}
