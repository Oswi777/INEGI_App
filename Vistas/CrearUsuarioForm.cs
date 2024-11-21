using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CensoINEGI.Controllers;
using CensoINEGI.Models;

namespace CensoINEGI.Vistas
{
    public partial class CrearUsuarioForm : Form
    {
        private UsuarioController usuarioController = new UsuarioController();
        public CrearUsuarioForm()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private string EncriptarContraseña(string contraseña)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(contraseña);
                var hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string nombreCompleto = txtNombreCompleto.Text.Trim();
            string email = txtEmail.Text.Trim();

            try
            {
                usuarioController.CrearUsuario(nombreUsuario, contraseña, nombreCompleto, email);
                lblMensaje.Text = "Usuario creado exitosamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                LimpiarCampos();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void CrearUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                string nombreUsuario = dgvUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                try
                {
                    usuarioController.EliminarUsuario(nombreUsuario);
                    lblMensaje.Text = "Usuario eliminado exitosamente.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    CargarUsuarios();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = ex.Message;
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblMensaje.Text = "Seleccione un usuario para eliminar.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvUsuarios.CurrentRow != null)
        {
                string nombreUsuario = txtNombreUsuario.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();
                string nombreCompleto = txtNombreCompleto.Text.Trim();
                string email = txtEmail.Text.Trim();

                Usuario usuario = new Usuario
                {
                    NombreUsuario = nombreUsuario,
                    Contraseña = string.IsNullOrEmpty(contraseña) ? null : contraseña,
                    NombreCompleto = nombreCompleto,
                    Email = email,
                    Rol = "Usuario" // Rol predeterminado
                };

                try
                {
                    usuarioController.ActualizarUsuario(usuario);
                    lblMensaje.Text = "Usuario modificado exitosamente.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    LimpiarCampos();
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = ex.Message;
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
        else
            {
                lblMensaje.Text = "Seleccione un usuario para modificar.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            try
            {
                var usuarios = usuarioController.ObtenerTodosLosUsuarios();
                dgvUsuarios.DataSource = usuarios;
                dgvUsuarios.Columns["Contraseña"].Visible = false; // Ocultar la columna de contraseña
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                txtNombreUsuario.Text = row.Cells["NombreUsuario"].Value.ToString();
                txtNombreCompleto.Text = row.Cells["NombreCompleto"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtContraseña.Clear(); // Limpiar el campo de contraseña
            }
        }
        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            txtNombreCompleto.Clear();
            txtEmail.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void btnConsultarHabitantes_Click(object sender, EventArgs e)
        {
            ConsultarHabitantesForm consultarHabitantesForm = new ConsultarHabitantesForm();
            consultarHabitantesForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Close();
        }
    }
}
