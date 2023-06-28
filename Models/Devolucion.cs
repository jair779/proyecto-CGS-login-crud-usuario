using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CGS.Models
{
    public class Devolucion
    {
        [Key]
        public int IdDevolucion { get; set; }
        [Required]
        public string ObservacionDevolucion { get; set; }
        [Required]
        public DateTime FechaHoraDevolucion { get; set; }

        public HistorialVenta HistorialVenta { get; set; }
    }
}
