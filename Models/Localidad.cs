using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoINEGI.Models
{
    public class Localidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int MunicipioID { get; set; } // FK a la tabla Municipios
    }
}
