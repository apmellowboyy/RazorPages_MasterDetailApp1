using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages_MasterDetailApp.Models;

namespace RazorPages_MasterDetailApp.Data
{
    public class RazorPages_MasterDetailAppContext : DbContext
    {
        public RazorPages_MasterDetailAppContext (DbContextOptions<RazorPages_MasterDetailAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPages_MasterDetailApp.Models.GameCollection> GameCollection { get; set; } = default!;
    }
}
