using Proyecto_CGS.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Proyecto_CGS.Context
{
    public partial class ModelVentaDeComputadoras : DbContext
    {
        public ModelVentaDeComputadoras()
            : base("name=ModelVentaDeComputadoras")
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Equipo> Equipo { get; set; }   
        public virtual DbSet<Devolucion> Devolucion { get; set;}
        public virtual DbSet<HistorialVenta> HistorialVenta { get; set;}
    }
}
