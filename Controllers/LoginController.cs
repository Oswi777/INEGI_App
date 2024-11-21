// Controllers/LoginController.cs
using System;
using MySql.Data.MySqlClient;
using CensoINEGI.Repositories;

namespace CensoINEGI.Controllers
{
    public class LoginController
    {
        private AdministradorRepository adminRepo = new AdministradorRepository();
        private UsuarioRepository usuarioRepo = new UsuarioRepository();

        public bool LoginAdministrador(string usuario, string contraseña)
        {
            var admin = adminRepo.GetAdministradorByUsuario(usuario);
            if (admin != null)
            {
                // Compara la contraseña encriptada
                string hashContraseña = EncriptarContraseña(contraseña);
                return admin.Contraseña == hashContraseña;
            }
            return false;
        }

        public bool LoginUsuario(string usuario, string contraseña)
        {
            var user = usuarioRepo.GetUsuarioByNombre(usuario);
            if (user != null)
            {
                // Compara la contraseña encriptada
                string hashContraseña = EncriptarContraseña(contraseña);
                return user.Contraseña == hashContraseña;
            }
            return false;
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
    }
}
