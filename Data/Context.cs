using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APPCINE.Models;

namespace APPCINE.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<APPCINE.Models.Pelicula> Pelicula { get; set; }

        public DbSet<APPCINE.Models.Cliente> Cliente { get; set; }

        public DbSet<APPCINE.Models.Sala> Sala { get; set; }
    }
}
