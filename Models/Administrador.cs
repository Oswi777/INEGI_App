using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoINEGI.Models
{
  
    using System;

    public class Administrador
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

}
