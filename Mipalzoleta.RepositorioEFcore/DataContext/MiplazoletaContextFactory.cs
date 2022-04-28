using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mipalzoleta.RepositorioEFcore.DataContext
{
    public class MiplazoletaContextFactory : IDesignTimeDbContextFactory<MiplazoletaDbContext>
    {
        public MiplazoletaDbContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<MiplazoletaDbContext>();

            OptionBuilder.UseMySql("Server=localhost;Database=MiPlazoletaDb;Uid=root",ServerVersion.Parse("10.1.38"),null);
            //"Server=localhost;Database=MiPlazoletaDb"
            //"10.1.38 - MariaDB - mariadb.org binary distribution"
            return new MiplazoletaDbContext(OptionBuilder.Options); 
        }
    }
}
