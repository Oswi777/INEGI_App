// Controllers/MunicipioController.cs
using System.Collections.Generic;
using CensoINEGI.Repositories;

namespace CensoINEGI.Controllers
{
    public class MunicipioController
    {
        private MunicipioRepository municipioRepo = new MunicipioRepository();

        // Obtener la lista de nombres de municipios
        public List<string> ObtenerNombresMunicipios()
        {
            return municipioRepo.GetNombresMunicipios();
        }

        // Obtener el ID de un municipio por su nombre
        public int ObtenerMunicipioID(string nombreMunicipio)
        {
            return municipioRepo.GetMunicipioID(nombreMunicipio);
        }
    }
}
