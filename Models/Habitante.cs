// Models/Habitante.cs
namespace CensoINEGI.Models
{
    public class Habitante
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string RelacionConVivienda { get; set; }
        public int ID_Vivienda { get; set; } 
    }
}
