// Controllers/LocalidadController.cs
using System.Collections.Generic;
using CensoINEGI.Repositories;

namespace CensoINEGI.Controllers
{
    public class LocalidadController
    {
        private LocalidadRepository localidadRepo = new LocalidadRepository();

        // Obtener la lista de localidades asociadas a un municipio
        public List<string> ObtenerLocalidadesPorMunicipio(string nombreMunicipio)
        {
            return localidadRepo.GetLocalidadesPorMunicipio(nombreMunicipio);
        }

        // Obtener el ID de una localidad por su nombre y el nombre de su municipio
        public int ObtenerLocalidadID(string nombreLocalidad, string nombreMunicipio)
        {
            return localidadRepo.GetLocalidadID(nombreLocalidad, nombreMunicipio);
        }
    }
}
