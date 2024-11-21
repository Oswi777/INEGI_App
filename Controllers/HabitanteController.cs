using CensoINEGI.Models;
using CensoINEGI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoINEGI.Controllers
{
    public class HabitanteController
    {
        private HabitanteRepository habitanteRepo = new HabitanteRepository();

        public List<Habitante> ObtenerHabitantesPorVivienda(int viviendaID)
        {
            if (viviendaID <= 0)
            {
                throw new ArgumentException("El ID de la vivienda no es válido.");
            }
            return habitanteRepo.GetHabitantesPorVivienda(viviendaID);
        }

        public void AgregarHabitante(Habitante habitante)
        {
            if (habitante == null)
            {
                throw new ArgumentException("El habitante no puede ser nulo.");
            }
            // Validaciones específicas del habitante pueden ir aquí.
            habitanteRepo.AgregarHabitante(habitante);
        }

        public void ActualizarHabitante(Habitante habitante)
        {
            if (habitante == null || habitante.ID <= 0)
            {
                throw new ArgumentException("El habitante no es válido o no tiene un ID correcto.");
            }
            habitanteRepo.ActualizarHabitante(habitante);
        }

        public void EliminarHabitante(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del habitante no es válido.");
            }
            habitanteRepo.EliminarHabitante(id);
        }
    }
}
