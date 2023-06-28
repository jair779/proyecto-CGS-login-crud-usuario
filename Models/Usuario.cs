using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CGS.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public String NombreUsuario { get; set; }
        [Required]
        public String PasswordUsuario { get; set; }
        [Required]
        public String NombreCompleto { get; set; }
        [Required]
        public bool EstadoUsuario { get; set; }

        public List<HistorialVenta> HistorialVenta { get; set; }
    }
}
