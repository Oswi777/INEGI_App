// Controllers/ActividadEconomicaController.cs
using System.Collections.Generic;
using CensoINEGI.Repositories;

namespace CensoINEGI.Controllers
{
    public class ActividadEconomicaController
    {
        private ActividadEconomicaRepository actividadRepo = new ActividadEconomicaRepository();

        // Obtener descripciones de todas las actividades económicas
        public List<string> ObtenerDescripcionesActividades()
        {
            return actividadRepo.GetDescripcionesActividades();
        }

        // Obtener el ID de una actividad económica basada en su descripción
        public int ObtenerActividadID(string descripcion)
        {
            return actividadRepo.GetActividadID(descripcion);
        }
    }
}
