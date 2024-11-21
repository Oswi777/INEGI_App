// Vistas/DashboardForm.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CensoINEGI.Models;
using CensoINEGI.Repositories;
using System.Windows.Forms.DataVisualization.Charting;

namespace CensoINEGI.Vistas
{
    public partial class DashboardForm : Form
    {
        private MunicipioRepository municipioRepository;
        private LocalidadRepository localidadRepository;
        private HabitanteRepository habitanteRepository;

        public DashboardForm()
        {
            InitializeComponent();
            municipioRepository = new MunicipioRepository();
            localidadRepository = new LocalidadRepository();
            habitanteRepository = new HabitanteRepository();
            CargarMunicipios();
        }

        private void CargarMunicipios()
        {
            try
            {
                List<string> municipios = municipioRepository.GetNombresMunicipios();
                cmbMunicipios.Items.Clear();
                foreach (var municipio in municipios)
                {
                    cmbMunicipios.Items.Add(municipio);
                }
                cmbMunicipios.SelectedIndex = -1; // No seleccionar nada por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar municipios: " + ex.Message);
            }
        }

        private void cmbMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si un municipio fue seleccionado
            if (cmbMunicipios.SelectedIndex != -1)
            {
                try
                {
                    // Cargar localidades según el municipio seleccionado
                    string municipioSeleccionado = cmbMunicipios.SelectedItem.ToString();
                    MessageBox.Show($"Municipio seleccionado: {municipioSeleccionado}"); // Mensaje para verificar el municipio seleccionado

                    List<string> localidades = localidadRepository.GetLocalidadesPorMunicipio(municipioSeleccionado);
                    MessageBox.Show($"Número de localidades encontradas: {localidades.Count}"); // Mensaje para verificar cuántas localidades se encontraron

                    cmbLocalidades.Items.Clear();
                    if (localidades.Count > 0)
                    {
                        foreach (var localidad in localidades)
                        {
                            cmbLocalidades.Items.Add(localidad);
                        }
                        cmbLocalidades.SelectedIndex = -1; // Asegurarse de que no haya ninguna localidad preseleccionada
                    }
                    else
                    {
                        MessageBox.Show($"No se encontraron localidades para el municipio seleccionado: {municipioSeleccionado}");
                        cmbLocalidades.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar localidades: " + ex.Message);
                }
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            string municipioSeleccionado = cmbMunicipios.SelectedIndex != -1 ? cmbMunicipios.SelectedItem.ToString() : null;
            string localidadSeleccionada = cmbLocalidades.SelectedIndex != -1 ? cmbLocalidades.SelectedItem.ToString() : null;

            if (municipioSeleccionado == null && localidadSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione un municipio o localidad para generar el reporte.");
                return;
            }

            GenerarReporte(municipioSeleccionado, localidadSeleccionada);
        }

        private void GenerarReporte(string municipio, string localidad)
        {
            List<Habitante> habitantes;
            string chartTitle = "";

            if (!string.IsNullOrEmpty(localidad))
            {
                // Reporte por localidad
                int localidadID = localidadRepository.GetLocalidadID(localidad, municipio);
                habitantes = habitanteRepository.GetHabitantesPorLocalidad(localidadID);
                chartTitle = "Población de la localidad " + localidad + " en el municipio " + municipio;
            }
            else
            {
                // Reporte por municipio
                int municipioID = municipioRepository.GetMunicipioID(municipio);
                habitantes = habitanteRepository.GetHabitantesPorMunicipio(municipioID);
                chartTitle = "Población del municipio " + municipio;
            }

            // Actualizar DataGridView
            dataGridReporte.DataSource = null;
            dataGridReporte.DataSource = habitantes;

            // Actualizar Chart
            chartPoblacion.Series.Clear();
            Series series = new Series
            {
                Name = "Habitantes",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Column
            };
            chartPoblacion.Series.Add(series);

            // Contar la cantidad de habitantes por cada grupo de edad, género, etc.
            var agrupacionPorGenero = new Dictionary<string, int>();
            foreach (var habitante in habitantes)
            {
                if (!agrupacionPorGenero.ContainsKey(habitante.Genero))
                {
                    agrupacionPorGenero[habitante.Genero] = 0;
                }
                agrupacionPorGenero[habitante.Genero]++;
            }

            foreach (var item in agrupacionPorGenero)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chartPoblacion.Titles.Clear();
            chartPoblacion.Titles.Add(chartTitle);
        }

        private void btnGenerarReporte_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener las selecciones de municipio y localidad
                string municipioSeleccionado = cmbMunicipios.SelectedIndex != -1 ? cmbMunicipios.SelectedItem.ToString() : null;
                string localidadSeleccionada = cmbLocalidades.SelectedIndex != -1 ? cmbLocalidades.SelectedItem.ToString() : null;

                if (municipioSeleccionado == null && localidadSeleccionada == null)
                {
                    MessageBox.Show("Por favor, seleccione un municipio o localidad para generar el reporte.");
                    return;
                }

                GenerarReporte(municipioSeleccionado, localidadSeleccionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
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
