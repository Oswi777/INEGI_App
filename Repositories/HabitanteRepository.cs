using System;
using System.Collections.Generic;
using CensoINEGI.Models;
using MySql.Data.MySqlClient;

namespace CensoINEGI.Repositories
{
    public class HabitanteRepository
    {
        private DatabaseConnection dbConnection = DatabaseConnection.GetInstance(); // Usa GetInstance()

        public List<Habitante> GetHabitantesPorVivienda(int viviendaID)
        {
            List<Habitante> habitantes = new List<Habitante>();
            string query = "SELECT * FROM habitantes WHERE ID_Vivienda = @idVivienda";

            using (var connection = dbConnection.GetConnection()) // Usamos GetConnection()
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idVivienda", viviendaID);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Habitante habitante = new Habitante
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Nombre = reader["Nombre"].ToString(),
                            Edad = Convert.ToInt32(reader["Edad"]),
                            Genero = reader["Genero"].ToString(),
                            RelacionConVivienda = reader["RelacionConVivienda"].ToString(),
                            ID_Vivienda = Convert.ToInt32(reader["ID_Vivienda"])
                        };
                        habitantes.Add(habitante);
                    }
                }
            }
            return habitantes;
        }

        public void AgregarHabitante(Habitante habitante)
        {
            string query = "INSERT INTO habitantes (Nombre, Edad, Genero, RelacionConVivienda, ID_Vivienda) " +
                           "VALUES (@nombre, @edad, @genero, @relacionConVivienda, @idVivienda)";

            using (var connection = dbConnection.GetConnection()) // Usamos GetConnection()
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", habitante.Nombre);
                cmd.Parameters.AddWithValue("@edad", habitante.Edad);
                cmd.Parameters.AddWithValue("@genero", habitante.Genero);
                cmd.Parameters.AddWithValue("@relacionConVivienda", habitante.RelacionConVivienda);
                cmd.Parameters.AddWithValue("@idVivienda", habitante.ID_Vivienda);
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarHabitante(Habitante habitante)
        {
            string query = "UPDATE Habitantes SET Nombre = @nombre, Edad = @edad, Genero = @genero, " +
                           "RelacionConVivienda = @relacionConVivienda WHERE ID = @id";
            using (var connection = dbConnection.GetConnection()) // Usamos GetConnection()
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", habitante.Nombre);
                cmd.Parameters.AddWithValue("@edad", habitante.Edad);
                cmd.Parameters.AddWithValue("@genero", habitante.Genero);
                cmd.Parameters.AddWithValue("@relacionConVivienda", habitante.RelacionConVivienda);
                cmd.Parameters.AddWithValue("@id", habitante.ID);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarHabitante(int id)
        {
            string query = "DELETE FROM Habitantes WHERE ID = @id";

            using (var connection = dbConnection.GetConnection()) // Usamos GetConnection()
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Habitante> GetHabitantesPorLocalidad(int localidadID)
        {
            List<Habitante> habitantes = new List<Habitante>();
            string query = @"
                SELECT h.* 
                FROM habitantes h
                JOIN viviendas v ON h.ID_Vivienda = v.ID
                WHERE v.ID_Localidad = @localidadID";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@localidadID", localidadID);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Habitante habitante = new Habitante
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Nombre = reader["Nombre"].ToString(),
                            Edad = Convert.ToInt32(reader["Edad"]),
                            Genero = reader["Genero"].ToString(),
                            RelacionConVivienda = reader["RelacionConVivienda"].ToString(),
                            ID_Vivienda = Convert.ToInt32(reader["ID_Vivienda"])
                        };
                        habitantes.Add(habitante);
                    }
                }
            }
            return habitantes;
        }

        public List<Habitante> GetHabitantesPorMunicipio(int municipioID)
        {
            List<Habitante> habitantes = new List<Habitante>();
            string query = @"
                SELECT h.* 
                FROM habitantes h
                JOIN viviendas v ON h.ID_Vivienda = v.ID
                WHERE v.ID_Municipio = @municipioID";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@municipioID", municipioID);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Habitante habitante = new Habitante
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Nombre = reader["Nombre"].ToString(),
                            Edad = Convert.ToInt32(reader["Edad"]),
                            Genero = reader["Genero"].ToString(),
                            RelacionConVivienda = reader["RelacionConVivienda"].ToString(),
                            ID_Vivienda = Convert.ToInt32(reader["ID_Vivienda"])
                        };
                        habitantes.Add(habitante);
                    }
                }
            }
            return habitantes;
        }
    }
}

