using Laboratorio2Progra.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2Progra.Data
{
    public class ApplicationDbContext : DbContext
    {

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                 : base(options)
            {

            }

            public DbSet<Entidad> persona { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }
        
    }
}
