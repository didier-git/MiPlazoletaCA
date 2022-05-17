using Mipalzoleta.RepositorioEFcore.DataContext;
using MiPlazoleta.Entities.Interfaces;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.RepositorioEFcore.Repositorios
{
    public class RepositorioPlatoMenu : IRepositorioPlatoMenu
    {
        public readonly MiplazoletaDbContext Context;

        public RepositorioPlatoMenu(MiplazoletaDbContext context) => Context = context;
        public void AddPlatoMenu(PlatoMenu menu)
        {
            Context.PlatosMenus.Add(menu);
        }

        public PlatoMenu GetPlatoMenu(int? id)
        {
            return Context.PlatosMenus.Find(id); 
        }

        public ICollection<PlatoMenu> GetPlatoMenuList(int? id)
        {
            var list = Context.PlatosMenus.Where(c=>c.MenuId==id).ToList();

            return list;

        }
    }
}
