using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISCA.Infraestructura.Data
{
    internal class AplicacionDBContexto : DbContext
    {
        public AplicacionDBContexto(DbContextOptions<AplicacionDBContexto> options) : base(options) { }
        public DbSet<NombreEntidad> Nombre Entidad{ get; set; }
    }
}
