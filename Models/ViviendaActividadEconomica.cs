using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoINEGI.Models
{
    public class ViviendaActividadEconomica
    {
        public int ID { get; set; }
        public int ViviendaID { get; set; } // FK a la tabla Viviendas
        public int ActividadEconomicaID { get; set; } // FK a la tabla ActividadesEconomicas
    }
}
