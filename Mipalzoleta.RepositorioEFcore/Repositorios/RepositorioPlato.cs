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
    public class RepositorioPlato : IRepositorioPlato
    {
        readonly MiplazoletaDbContext context;

        public RepositorioPlato(MiplazoletaDbContext Context) => context = Context;
        public void Crear(Plato Plato)
        {
            context.Add(Plato);
        }

        public IEnumerable<Plato> GetAll()
        {
            return context.Platos.ToList();
        }
    }
}
