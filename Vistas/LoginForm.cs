using CensoINEGI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CensoINEGI.Vistas
{
    public partial class LoginForm : Form
    {
        private LoginController loginController = new LoginController();
        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            // Validación para campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                lblMensaje.Text = "Por favor, complete ambos campos de usuario y contraseña.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return; // Sale del método para que no continúe con la autenticación
            }

            try
            {
                // Intentar autenticación como administrador
                if (loginController.LoginAdministrador(usuario, contraseña))
                {
                    lblMensaje.Text = "Inicio de sesión exitoso (Administrador)";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    // Aquí puedes abrir el formulario principal para administradores.
                    CrearUsuarioForm crearUsuarioForm = new CrearUsuarioForm();
                    crearUsuarioForm.Show();
                    this.Hide();
                }
                else if (loginController.LoginUsuario(usuario, contraseña))
                {
                    lblMensaje.Text = "Inicio de sesión exitoso (Usuario)";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    RegistrarViviendaForm crearViviendaForm = new RegistrarViviendaForm();
                    crearViviendaForm.Show();
                    this.Hide();
                }
                else
                {
                    lblMensaje.Text = "Credenciales incorrectas.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
