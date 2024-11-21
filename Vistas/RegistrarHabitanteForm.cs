using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CensoINEGI.Controllers;
using CensoINEGI.Models;

namespace CensoINEGI.Vistas
{
    public partial class RegistrarHabitanteForm : Form
    {
        private HabitanteController habitanteController = new HabitanteController();
        private int viviendaID;
        public RegistrarHabitanteForm(int viviendaID)
        {
            InitializeComponent();
            this.viviendaID = viviendaID;
            CargarGenero();
            CargarRelacionConVivienda();
        }
        private void CargarGenero()
        {
            // Opciones de género
            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("Femenino");
            cmbGenero.Items.Add("Otro");
        }

        private void CargarRelacionConVivienda()
        {
            // Opciones de relación con la vivienda
            cmbRelacionConVivienda.Items.Add("Padre");
            cmbRelacionConVivienda.Items.Add("Madre");
            cmbRelacionConVivienda.Items.Add("Hijo");
            cmbRelacionConVivienda.Items.Add("Hija");
            cmbRelacionConVivienda.Items.Add("Otro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar y capturar datos del habitante
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEdad.Text) ||
                cmbGenero.SelectedItem == null || cmbRelacionConVivienda.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            int edad;
            if (!int.TryParse(txtEdad.Text, out edad))
            {
                MessageBox.Show("La edad debe ser un número.");
                return;
            }

            string genero = cmbGenero.SelectedItem.ToString();
            string relacionConVivienda = cmbRelacionConVivienda.SelectedItem.ToString();

            Habitante habitante = new Habitante
            {
                Nombre = nombre,
                Edad = edad,
                Genero = genero,
                RelacionConVivienda = relacionConVivienda,
                ID_Vivienda = viviendaID
            };

            // Guardar el habitante en la base de datos
            habitanteController.AgregarHabitante(habitante);

            MessageBox.Show("Habitante registrado exitosamente.");
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbRelacionConVivienda.SelectedIndex = -1;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrarViviendaForm registrarViviendaForm = new RegistrarViviendaForm();
            registrarViviendaForm.Show();

        }

        private void btnAgregarOtro_Click(object sender, EventArgs e)
        {
            // Validar y capturar datos del habitante
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEdad.Text) ||
                cmbGenero.SelectedItem == null || cmbRelacionConVivienda.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            int edad;
            if (!int.TryParse(txtEdad.Text, out edad))
            {
                MessageBox.Show("La edad debe ser un número.");
                return;
            }

            string genero = cmbGenero.SelectedItem.ToString();
            string relacionConVivienda = cmbRelacionConVivienda.SelectedItem.ToString();

            Habitante habitante = new Habitante
            {
                Nombre = nombre,
                Edad = edad,
                Genero = genero,
                RelacionConVivienda = relacionConVivienda,
                ID_Vivienda = viviendaID
            };

            // Guardar el habitante en la base de datos
            habitanteController.AgregarHabitante(habitante);

            MessageBox.Show("Habitante registrado exitosamente.");

            // Limpiar el formulario para permitir agregar otro habitante
            LimpiarFormulario();
        }
    }
}
