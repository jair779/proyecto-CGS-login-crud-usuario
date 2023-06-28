using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CGS.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public String NombreCliente { get; set; }
        [Required]
        public String ApellidoCliente { get; set; }
        [Required]
        public int CiCliente { get; set; }

        public List<HistorialVenta> HistorialVenta { get; set; }
    }
}
