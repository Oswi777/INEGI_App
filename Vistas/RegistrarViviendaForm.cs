using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CensoINEGI.Controllers;
using CensoINEGI.Models;

namespace CensoINEGI.Vistas
{
    public partial class RegistrarViviendaForm : Form
    {
        private ViviendaController viviendaController = new ViviendaController();
        private ActividadEconomicaController actividadController = new ActividadEconomicaController();
        private MunicipioController municipioController = new MunicipioController();
        private LocalidadController localidadController = new LocalidadController();
        public RegistrarViviendaForm()
        {
            InitializeComponent();
            CargarTiposDeCasas();
            CargarMunicipios();
            CargarActividadesEconomicas();
            cmbMunicipio.SelectedIndexChanged += cmbMunicipio_SelectedIndexChanged;
        }
        private void CargarTiposDeCasas()
        {
            // Obtener tipos de casa y cargarlos en el ComboBox
            List<string> tiposCasas = viviendaController.ObtenerTiposDeCasas();
            cmbTipoCasa.DataSource = tiposCasas;
        }

        private void CargarMunicipios()
        {
            // Obtener municipios y cargarlos en el ComboBox
            List<string> municipios = municipioController.ObtenerNombresMunicipios();
            cmbMunicipio.DataSource = municipios;
        }

        private void CargarActividadesEconomicas()
        {
            // Obtener actividades económicas y cargarlas en el CheckedListBox
            List<string> actividades = actividadController.ObtenerDescripcionesActividades();
            clbActividadesEconomicas.Items.AddRange(actividades.ToArray());
        }

        private void RegistrarViviendaForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMunicipio.SelectedItem != null)
            {
                string municipioSeleccionado = cmbMunicipio.SelectedItem.ToString();
                List<string> localidades = localidadController.ObtenerLocalidadesPorMunicipio(municipioSeleccionado);

                if (localidades != null && localidades.Count > 0)
                {
                    cmbLocalidad.DataSource = localidades;
                }
                else
                {
                    cmbLocalidad.DataSource = null;
                    MessageBox.Show("No se encontraron localidades para el municipio seleccionado.");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Capturar datos del formulario
            string calle = txtCalle.Text.Trim();
            string numero = txtNumero.Text.Trim();
            string colonia = txtColonia.Text.Trim();
            string tipoCasa = cmbTipoCasa.SelectedItem?.ToString();
            string municipio = cmbMunicipio.SelectedItem?.ToString();
            string localidad = cmbLocalidad.SelectedItem?.ToString();

            // Validar los campos y obtener los IDs necesarios
           try
            {
                int tipoCasaID = viviendaController.ObtenerTipoCasaID(tipoCasa);
                int idMunicipio = municipioController.ObtenerMunicipioID(municipio);
                int idLocalidad = localidadController.ObtenerLocalidadID(localidad, municipio);

                // Obtener las actividades económicas seleccionadas
                List<int> actividadesSeleccionadas = new List<int>();
                foreach (string actividad in clbActividadesEconomicas.CheckedItems)
                {
                    int actividadID = actividadController.ObtenerActividadID(actividad);
                    actividadesSeleccionadas.Add(actividadID);
                }

                // Crear el objeto Vivienda con los datos
                Vivienda nuevaVivienda = new Vivienda
                {
                    Calle = calle,
                    Numero = numero,
                    Colonia = colonia,
                    TipoCasaID = tipoCasaID,
                    MunicipioID = idMunicipio,
                    LocalidadID = idLocalidad,
                    ActividadesEconomicas = actividadesSeleccionadas
                };

                // Guardar la vivienda
                viviendaController.CrearVivienda(nuevaVivienda);
                lblMensaje.Text = "Vivienda registrada exitosamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;

                // Opcional: redirigir al formulario de registro de habitantes o limpiar el formulario
                LimpiarFormulario();
                RegistrarHabitanteForm habitanteForm = new RegistrarHabitanteForm(nuevaVivienda.ID);
                habitanteForm.Show();

                // Cerrar el formulario actual de registrar vivienda si es necesario
                this.Close();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al registrar la vivienda: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Regresar al formulario principal o de login
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
            this.Close();
        }
        private void LimpiarFormulario()
        {
            // Limpiar todos los campos después de guardar
            txtCalle.Clear();
            txtNumero.Clear();
            txtColonia.Clear();
            cmbTipoCasa.SelectedIndex = -1;
            cmbMunicipio.SelectedIndex = -1;
            cmbLocalidad.DataSource = null;
            foreach (int i in clbActividadesEconomicas.CheckedIndices)
            {
                clbActividadesEconomicas.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
