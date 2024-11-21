// Repositories/UsuarioRepository.cs
using CensoINEGI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CensoINEGI.Repositories
{
    public class UsuarioRepository
    {
        private DatabaseConnection dbConnection = DatabaseConnection.GetInstance(); // Usa GetInstance()

        // Método para agregar un nuevo usuario
        public void AgregarUsuario(Usuario usuario)
        {
            string query = "INSERT INTO Usuarios (Usuario, Contraseña, NombreCompleto, Email, Rol) " +
                           "VALUES (@usuario, @contraseña, @nombreCompleto, @email, @rol)";

            using (var connection = dbConnection.GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@nombreCompleto", usuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar el usuario: " + ex.Message);
                }
            }
        }

        // Método para obtener un usuario por nombre de usuario
        public Usuario GetUsuarioByNombre(string nombreUsuario)
        {
            Usuario usuario = null;
            string query = "SELECT * FROM Usuarios WHERE Usuario = @nombreUsuario";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            NombreUsuario = reader["Usuario"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            NombreCompleto = reader["NombreCompleto"].ToString(),
                            Email = reader["Email"].ToString(),
                            Rol = reader["Rol"].ToString(),
                            FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                        };
                    }
                }
            }
            return usuario;
        }

        // Método para actualizar un usuario
        public void ActualizarUsuario(Usuario usuario)
        {
            string query = "UPDATE Usuarios SET Contraseña = @contraseña, NombreCompleto = @nombreCompleto, Email = @email, Rol = @rol " +
                           "WHERE Usuario = @usuario";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@nombreCompleto", usuario.NombreCompleto);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar un usuario por nombre de usuario
        public void EliminarUsuario(string nombreUsuario)
        {
            string query = "DELETE FROM Usuarios WHERE Usuario = @nombreUsuario";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para obtener todos los usuarios
        public List<Usuario> GetTodosLosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = "SELECT * FROM Usuarios";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            NombreUsuario = reader["Usuario"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            NombreCompleto = reader["NombreCompleto"].ToString(),
                            Email = reader["Email"].ToString(),
                            Rol = reader["Rol"].ToString(),
                            FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                        };
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }
    }
}
