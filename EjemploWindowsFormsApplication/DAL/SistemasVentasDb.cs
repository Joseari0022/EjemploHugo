using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace DAL
{
    public class SistemasVentasDb : DbContext
    {
        public SistemasVentasDb() : base("name=ConStr")
        {

        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
