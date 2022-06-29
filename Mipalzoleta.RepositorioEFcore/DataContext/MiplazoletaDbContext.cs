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





        protected override void OnModelCreating(ModelBuilder model)
        {
            
            
            //model.Entity<PlatoMenu>().HasKey(sc => new { sc.PlatoId, sc.MenuId });
            ////model.Entity<PlatoMenu>().HasKey(x => x.Id);
            //model.Entity<Menu>().HasKey(m => m.IdMenu);
            //model.Entity<Plato>().HasKey(p => p.IdPlato);

            //model.Entity<PlatoMenu>()
            //    .HasOne<Plato>(sc => sc.Plato)
            //    .WithMany(s => s.PlatoMenu)
            //    .HasForeignKey(sc => sc.PlatoId);


            //model.Entity<PlatoMenu>()
            //    .HasOne<Menu>(sc => sc.Menu)
            //    .WithMany(s => s.PlatoMenu)
            //    .HasForeignKey(sc => sc.MenuId);

//---------------------------------------------------------------------------
            model.Entity<PlatoMenu>().HasKey(t => new { t.MenuId, t.PlatoId });
            model.Entity<Menu>().HasKey(m => m.IdMenu);
            model.Entity<Plato>().HasKey(p => p.IdPlato);

            model.Entity<PlatoMenu>()
                .HasOne(pt => pt.Menu)
                .WithMany(p => p.PlatoMenu)
                .HasForeignKey(pt => pt.MenuId);

            model.Entity<PlatoMenu>()
                .HasOne(pt => pt.Plato)
                .WithMany(t => t.PlatoMenu)
                .HasForeignKey(pt => pt.PlatoId);

        }
    }
}
