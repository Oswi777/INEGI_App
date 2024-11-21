// Repositories/ViviendaRepository.cs
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using CensoINEGI.Models;
using System;

namespace CensoINEGI.Repositories
{
    public class ViviendaRepository
    {
        private DatabaseConnection dbConnection = DatabaseConnection.GetInstance(); // Usa GetInstance()

        public List<string> GetTiposDeCasas()
        {
            List<string> tiposCasas = new List<string>();
            string query = "SELECT Tipo FROM TiposCasas";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tiposCasas.Add(reader["Tipo"].ToString());
                    }
                }
            }
            return tiposCasas;
        }

        public int GetTipoCasaID(string tipoCasa)
        {
            int tipoCasaID = 0;
            string query = "SELECT ID FROM TiposCasas WHERE Tipo = @tipoCasa";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tipoCasa", tipoCasa);
                tipoCasaID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return tipoCasaID;
        }

        public void AgregarVivienda(Vivienda vivienda)
        {
            string query = "INSERT INTO viviendas (Calle, Numero, Colonia, ID_Municipio, ID_Localidad, TipoCasaID) " +
                           "VALUES (@calle, @numero, @colonia, @idMunicipio, @idLocalidad, @tipoCasaID)";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@calle", vivienda.Calle);
                cmd.Parameters.AddWithValue("@numero", vivienda.Numero);
                cmd.Parameters.AddWithValue("@colonia", vivienda.Colonia);
                cmd.Parameters.AddWithValue("@idMunicipio", vivienda.MunicipioID);
                cmd.Parameters.AddWithValue("@idLocalidad", vivienda.LocalidadID);
                cmd.Parameters.AddWithValue("@tipoCasaID", vivienda.TipoCasaID);
                cmd.ExecuteNonQuery();

                vivienda.ID = (int)cmd.LastInsertedId;
            }
        }

        public void AgregarActividadesVivienda(int viviendaID, List<int> actividadesIDs)
        {
            string query = "INSERT INTO viviendaactividades (ID_Vivienda, ID_ActividadEconomica) VALUES (@viviendaID, @actividadID)";

            using (var connection = dbConnection.GetConnection())
            {
                foreach (int actividadID in actividadesIDs)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@viviendaID", viviendaID);
                    cmd.Parameters.AddWithValue("@actividadID", actividadID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Vivienda> GetAllViviendas()
        {
            List<Vivienda> viviendas = new List<Vivienda>();
            string query = @"
        SELECT v.*, tc.Tipo AS TipoCasa, m.Nombre AS MunicipioNombre 
        FROM viviendas v 
        JOIN TiposCasas tc ON v.TipoCasaID = tc.ID
        JOIN municipios m ON v.ID_Municipio = m.ID";

            using (var connection = dbConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Vivienda vivienda = new Vivienda
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Calle = reader["Calle"].ToString(),
                            Numero = reader["Numero"].ToString(),
                            Colonia = reader["Colonia"].ToString(),
                            MunicipioID = Convert.ToInt32(reader["ID_Municipio"]),
                            LocalidadID = Convert.ToInt32(reader["ID_Localidad"]),
                            TipoCasaID = Convert.ToInt32(reader["TipoCasaID"]),
                            TipoCasa = reader["TipoCasa"].ToString(),
                            MunicipioNombre = reader["MunicipioNombre"].ToString() // Asignar el nombre del municipio
                        };
                        viviendas.Add(vivienda);
                    }
                }
            }
            return viviendas;
        }
    }
}
