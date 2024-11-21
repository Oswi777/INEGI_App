// Repositories/LocalidadRepository.cs
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CensoINEGI.Repositories
{
    public class LocalidadRepository
    {
        private DatabaseConnection dbConnection = DatabaseConnection.GetInstance(); // Usa GetInstance()

        public List<string> GetLocalidadesPorMunicipio(string nombreMunicipio)
        {
            List<string> localidades = new List<string>();
            string query = @"
                SELECT l.Nombre 
                FROM localidades l 
                JOIN municipios m ON l.ID_Municipio = m.ID 
                WHERE m.Nombre = @nombreMunicipio";

            using (var connection = dbConnection.GetConnection()) // Usamos GetConnection()
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombreMunicipio", nombreMunicipio);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        localidades.Add(reader["Nombre"].ToString());
                    }
                }
            }
            return localidades;
        }

        public int GetLocalidadID(string nombreLocalidad, string nombreMunicipio)
        {
            int localidadID = 0;
            string query = @"
                SELECT l.ID 
                FROM localidades l 
                JOIN municipios m ON l.ID_Municipio = m.ID 
                WHERE l.Nombre = @nombreLocalidad AND m.Nombre = @nombreMunicipio";

            using (var connection = dbConnection.GetConnection()) // Usamos GetConnection()
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombreLocalidad", nombreLocalidad);
                cmd.Parameters.AddWithValue("@nombreMunicipio", nombreMunicipio);

                localidadID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return localidadID;
        }
    }
}
