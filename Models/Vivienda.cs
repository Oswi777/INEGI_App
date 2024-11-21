using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoINEGI.Models
{
    public class Vivienda
    {
        public int ID { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Colonia { get; set; }
        public int TipoCasaID { get; set; }         // Relación con la tabla TiposCasas
        public int MunicipioID { get; set; }        // Relación con la tabla Municipios
        public int LocalidadID { get; set; }        // Relación con la tabla Localidades
        public List<int> ActividadesEconomicas { get; set; }
        public string TipoCasa { get; set; }// Relación con ActividadesEconomicas
        public string MunicipioNombre { get; set; }
        public Vivienda()
        {
            ActividadesEconomicas = new List<int>();
        }
    }

}
