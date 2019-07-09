using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class ViTri_SQL
    {
        private readonly DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<ViTri_DTO> GetDataViTri()
        {
            List<ViTri_DTO> viTri_DTOs = new List<ViTri_DTO>();
            command = new MySqlCommand {
                CommandText = "SELECT * FROM vitri",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        viTri_DTOs.Add(new ViTri_DTO(
                            reader.GetString("ID"),
                            reader.GetString("TenViTri"),
                            reader.GetInt32("SoCayToiDa")));
                    }
                }
                reader.Close();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return viTri_DTOs;
        }

        public List<ViTri_DTO> GetAllDataViTri()
        {
            List<ViTri_DTO> viTriDTOs = new List<ViTri_DTO>();
            command = new MySqlCommand {
                CommandText = "SELECT a.ID, a.TenViTri, a.SoCayToiDa, COUNT(b.IDViTri) AS 'COUNT(ID)' " +
                "FROM vitri AS a " +
                "LEFT JOIN caycanh_vitri AS b " +
                "ON a.ID = b.IDViTri " +
                "GROUP BY a.ID;",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        viTriDTOs.Add(new ViTri_DTO(
                            reader.GetString("ID"),
                            reader.GetString("TenViTri"),
                            reader.GetInt32("SoCayToiDa"),
                            reader.GetInt32("COUNT(ID)")));
                    }
                }
                reader.Close();
                command.Dispose();

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return viTriDTOs;
        }
    }
}
