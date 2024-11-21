using System;
using System.Collections.Generic;
using System.Linq;
using CensoINEGI.Models;
using MySql.Data.MySqlClient;

namespace CensoINEGI.Repositories
{
    public class AdministradorRepository
    {
        private DatabaseConnection dbConnection = DatabaseConnection.GetInstance(); // Usa GetInstance()

        public Administrador GetAdministradorByUsuario(string usuario)
        {
            Administrador admin = null;
            string query = "SELECT * FROM Administradores WHERE Usuario = @usuario";

            using (var connection = dbConnection.GetConnection()) // Usamos GetConnection()
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        admin = new Administrador
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Usuario = reader["Usuario"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            NombreCompleto = reader["NombreCompleto"].ToString(),
                            Email = reader["Email"].ToString(),
                            FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                        };
                    }
                }
            }

            return admin;
        }
    }
}
