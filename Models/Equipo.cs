using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CGS.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }
        [Required]
        public String MarcaEquipo { get; set; }
        [Required]
        public string ModeloEquipo { get; set; }
        [Required]
        public double PrecioEquipo { get; set; }
        [Required]
        public String TipoEquipo { get; set; }
        
        public HistorialVenta HistorialVenta { get; set; }
    }
}
