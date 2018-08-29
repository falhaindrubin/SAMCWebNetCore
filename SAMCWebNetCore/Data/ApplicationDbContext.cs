using Microsoft.EntityFrameworkCore;
using SAMCWebNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAMCWebNetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Appointment> Appointment { get; set; }       

    }
}
