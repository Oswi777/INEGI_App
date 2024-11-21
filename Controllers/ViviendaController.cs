// Controllers/ViviendaController.cs
using System.Collections.Generic;
using CensoINEGI.Models;
using CensoINEGI.Repositories;

namespace CensoINEGI.Controllers
{
    public class ViviendaController
    {
        private ViviendaRepository viviendaRepo = new ViviendaRepository();

        // Obtener la lista de tipos de casas
        public List<string> ObtenerTiposDeCasas()
        {
            return viviendaRepo.GetTiposDeCasas();
        }

        // Obtener el ID de un tipo de casa por su nombre
        public int ObtenerTipoCasaID(string tipoCasa)
        {
            return viviendaRepo.GetTipoCasaID(tipoCasa);
        }

        // Crear una vivienda con sus datos y actividades económicas asociadas
        public void CrearVivienda(Vivienda vivienda)
        {
            // Guardar la vivienda
            viviendaRepo.AgregarVivienda(vivienda);

            // Guardar las actividades económicas asociadas
            if (vivienda.ActividadesEconomicas != null && vivienda.ActividadesEconomicas.Count > 0)
            {
                viviendaRepo.AgregarActividadesVivienda(vivienda.ID, vivienda.ActividadesEconomicas);
            }
        }
    }
}
