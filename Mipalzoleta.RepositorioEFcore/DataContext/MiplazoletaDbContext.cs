using Microsoft.EntityFrameworkCore;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mipalzoleta.RepositorioEFcore.DataContext
{
    public class MiplazoletaDbContext : DbContext
    {
        public MiplazoletaDbContext(
            DbContextOptions<MiplazoletaDbContext> options) : base( options) { }
        public DbSet<Plato> Platos { get; set; }
    }
}
