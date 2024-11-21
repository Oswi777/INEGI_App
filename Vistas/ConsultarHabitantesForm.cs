using CensoINEGI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CensoINEGI.Repositories;

namespace CensoINEGI.Vistas
{
    public partial class ConsultarHabitantesForm : Form
    {
        private ViviendaRepository viviendaRepository;
        private HabitanteRepository habitanteRepository;
        private ActividadEconomicaRepository actividadEconomicaRepository;
        public ConsultarHabitantesForm()
        {
            InitializeComponent();
            viviendaRepository = new ViviendaRepository();
            habitanteRepository = new HabitanteRepository();
            actividadEconomicaRepository = new ActividadEconomicaRepository();
            CargarViviendas();
            MostrarCantidadHabitantesPorTipoDeCasa();


            CargarViviendas();
        }

        private void cmbViviendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarViviendas()
        {
            List<Vivienda> viviendas = viviendaRepository.GetAllViviendas();
            foreach (var vivienda in viviendas)
            {
                cmbViviendas.Items.Add(vivienda.Calle + " " + vivienda.Numero + " - " + vivienda.Colonia + ", " + vivienda.MunicipioNombre + " (" + vivienda.TipoCasa + ")");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbViviendas.SelectedIndex != -1)
            {
                int viviendaID = viviendaRepository.GetAllViviendas()[cmbViviendas.SelectedIndex].ID;
                List<Habitante> habitantes = habitanteRepository.GetHabitantesPorVivienda(viviendaID);
                List<int> actividadesIDs = actividadEconomicaRepository.GetActividadesPorVivienda(viviendaID);
                List<string> actividades = new List<string>();

                foreach (int actividadID in actividadesIDs)
                {
                    actividades.Add(actividadEconomicaRepository.GetDescripcionActividad(actividadID));
                }

                lstHabitantes.Items.Clear();
                foreach (var habitante in habitantes)
                {
                    lstHabitantes.Items.Add(habitante.Nombre + ", " + habitante.Edad + " años, " + habitante.RelacionConVivienda);
                }

                lstActividades.Items.Clear();
                foreach (var actividad in actividades)
                {
                    lstActividades.Items.Add(actividad);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una vivienda para consultar.");
            }
        }

        private void ConsultarHabitantesForm_Load(object sender, EventArgs e)
        {

        }

        private void lstCantidadHabitantesPorTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarCantidadHabitantesPorTipoDeCasa()
        {
            Dictionary<string, int> cantidadHabitantesPorTipo = new Dictionary<string, int>();
            List<Vivienda> viviendas = viviendaRepository.GetAllViviendas();

            foreach (var vivienda in viviendas)
            {
                int cantidadHabitantes = habitanteRepository.GetHabitantesPorVivienda(vivienda.ID).Count;
                if (cantidadHabitantesPorTipo.ContainsKey(vivienda.TipoCasa))
                {
                    cantidadHabitantesPorTipo[vivienda.TipoCasa] += cantidadHabitantes;
                }
                else
                {
                    cantidadHabitantesPorTipo[vivienda.TipoCasa] = cantidadHabitantes;
                }
            }

            lstCantidadHabitantesPorTipo.Items.Clear();
            foreach (var tipo in cantidadHabitantesPorTipo)
            {
                lstCantidadHabitantesPorTipo.Items.Add(tipo.Key + ": " + tipo.Value + " habitantes");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            CrearUsuarioForm form = new CrearUsuarioForm();
            form.Show();
        }
    }
    
}
