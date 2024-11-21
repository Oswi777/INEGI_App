using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoINEGI.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; } // Puede ser 'Usuario' o 'Administrador'
        public DateTime FechaRegistro { get; set; }
    }
}
