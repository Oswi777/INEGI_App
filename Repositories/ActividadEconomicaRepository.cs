// Repositories/ActividadEconomicaRepository.cs
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CensoINEGI.Repositories
{
    public class ActividadEconomicaRepository
    {
        private DatabaseConnection dbConnection = DatabaseConnection.GetInstance();

        public List<string> GetDescripcionesActividades()
        {
            List<string> actividades = new List<string>();
            string query = "SELECT Descripcion FROM actividadesEconomicas";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        actividades.Add(reader["Descripcion"].ToString());
                    }
                }
            }
            return actividades;
        }

        public int GetActividadID(string descripcion)
        {
            int actividadID = 0;
            string query = "SELECT ID FROM actividadesEconomicas WHERE Descripcion = @descripcion";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                actividadID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return actividadID;
        }
        public List<int> GetActividadesPorVivienda(int viviendaID)
        {
            List<int> actividadesIDs = new List<int>();
            string query = "SELECT ID_ActividadEconomica FROM viviendaactividades WHERE ID_Vivienda = @viviendaID";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@viviendaID", viviendaID);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        actividadesIDs.Add(Convert.ToInt32(reader["ID_ActividadEconomica"]));
                    }
                }
            }
            return actividadesIDs;
        }

        public string GetDescripcionActividad(int actividadID)
        {
            string descripcion = string.Empty;
            string query = "SELECT Descripcion FROM actividadesEconomicas WHERE ID = @actividadID";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@actividadID", actividadID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        descripcion = reader["Descripcion"].ToString();
                    }
                }
            }
            return descripcion;
        }

    }
}
