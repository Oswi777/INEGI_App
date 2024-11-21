// Controllers/UsuarioController.cs
using System;
using System.Collections.Generic;
using CensoINEGI.Models;
using CensoINEGI.Repositories;

namespace CensoINEGI.Controllers
{
    public class UsuarioController
    {
        private UsuarioRepository usuarioRepo = new UsuarioRepository();

        public void CrearUsuario(string nombreUsuario, string contraseña, string nombreCompleto, string email)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(nombreCompleto))
            {
                throw new ArgumentException("Todos los campos son obligatorios.");
            }

            // Crear el objeto usuario
            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = nombreUsuario,
                Contraseña = EncriptarContraseña(contraseña),
                NombreCompleto = nombreCompleto,
                Email = email,
                Rol = "Usuario" // El rol es 'Usuario' por defecto
            };

            // Llamar al repositorio para guardar el usuario
            usuarioRepo.AgregarUsuario(nuevoUsuario);
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");
            }

            return usuarioRepo.GetUsuarioByNombre(nombreUsuario);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            if (usuario == null || string.IsNullOrWhiteSpace(usuario.NombreUsuario))
            {
                throw new ArgumentException("El usuario no es válido.");
            }

            // Encriptar la contraseña si se ha modificado
            if (!string.IsNullOrWhiteSpace(usuario.Contraseña))
            {
                usuario.Contraseña = EncriptarContraseña(usuario.Contraseña);
            }

            usuarioRepo.ActualizarUsuario(usuario);
        }

        public void EliminarUsuario(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");
            }

            usuarioRepo.EliminarUsuario(nombreUsuario);
        }

        // Método para obtener todos los usuarios
        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            return usuarioRepo.GetTodosLosUsuarios();
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
