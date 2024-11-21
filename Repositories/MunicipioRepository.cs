// Repositories/MunicipioRepository.cs
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CensoINEGI.Repositories
{
    public class MunicipioRepository
    {
        private DatabaseConnection dbConnection = DatabaseConnection.GetInstance(); // Usa GetInstance()

        public List<string> GetNombresMunicipios()
        {
            List<string> municipios = new List<string>();
            string query = "SELECT Nombre FROM municipios";

            using (var connection = dbConnection.GetConnection()) // Usamos GetConnection()
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        municipios.Add(reader["Nombre"].ToString());
                    }
                }
            }
            return municipios;
        }

        public int GetMunicipioID(string nombreMunicipio)
        {
            int municipioID = 0;
            string query = "SELECT ID FROM municipios WHERE Nombre = @nombreMunicipio";

            using (var connection = dbConnection.GetConnection()) // Usamos GetConnection()
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombreMunicipio", nombreMunicipio);

                municipioID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return municipioID;
        }
    }
}
