using Mipalzoleta.RepositorioEFcore.DataContext;
using Miplazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.Interfaces;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.RepositorioEFcore.Repositorios
{
    public class RepositorioMenu : IRepositorioMenu 
    {
        readonly MiplazoletaDbContext context;
        public RepositorioMenu(MiplazoletaDbContext Context) => context = Context;
        public void CrearMenu(CrearMenuDTO menu)
        {
            context.Add(menu);
        }

        public IEnumerable<Menu> GetMenus()
        {
            return context.Menus.ToList();
        }
    }
}
