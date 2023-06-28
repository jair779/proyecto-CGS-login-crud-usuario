using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CGS.Models
{
    public class HistorialVenta
    {
        [Key]
        public int IdHistorialVenta { get; set; }
        [Required]
        public int CantidadVenta { get; set; }
        [Required]
        public DateTime FechaVenta { get; set; }
        [Required]
        public float TotalVenta { get; set; }

        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public List<Equipo> Equipo { get; set; }
        public List<Devolucion> Devolucion { get; set;}
    }
}
