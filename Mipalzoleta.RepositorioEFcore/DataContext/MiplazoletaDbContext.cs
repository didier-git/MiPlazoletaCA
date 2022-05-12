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

        public DbSet<Menu> Menus { get; set; }

        public DbSet<PlatoMenu> PlatosMenus { get; set; }



        protected override void OnModelCreating(ModelBuilder model)
        {
            
            
            model.Entity<PlatoMenu>().HasKey(sc => new { sc.PlatoId, sc.MenuId });
            model.Entity<Menu>().HasKey(m => m.IdMenu);
            model.Entity<Plato>().HasKey(p => p.IdPlato);

            model.Entity<PlatoMenu>()
                .HasOne<Plato>(sc => sc.Plato)
                .WithMany(s => s.PlatoMenu)
                .HasForeignKey(sc => sc.PlatoId);


            model.Entity<PlatoMenu>()
                .HasOne<Menu>(sc => sc.Menu)
                .WithMany(s => s.PlatoMenu)
                .HasForeignKey(sc => sc.MenuId);

        }
    }
}
