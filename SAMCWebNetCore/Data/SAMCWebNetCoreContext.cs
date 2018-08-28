using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SAMCWebNetCore.Models
{
    public class SAMCWebNetCoreContext : DbContext
    {
        public SAMCWebNetCoreContext (DbContextOptions<SAMCWebNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<SAMCWebNetCore.Models.Appointment> Appointment { get; set; }
    }
}
