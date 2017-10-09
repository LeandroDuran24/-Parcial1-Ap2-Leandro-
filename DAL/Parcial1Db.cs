using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Parcial1Db:DbContext
    {
        public Parcial1Db():base("ConStr")
        {

        }
        public DbSet<Presupuesto> presupuesto { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        
    }
}
