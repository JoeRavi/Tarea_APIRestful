using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAREA.Models;

namespace TAREA.Data
{
    public class ApplicationDataBaseContext: DbContext
    {

        public DbSet<ModeloCasa> ModelosDeCasas { get; set; }
        public DbSet<CasaConstruida> CasasConstruidas { get; set; }



        public ApplicationDataBaseContext(DbContextOptions options) : base(options) { }

    }
}
