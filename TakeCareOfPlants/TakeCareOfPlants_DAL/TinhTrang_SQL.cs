using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class TinhTrang_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command = new MySqlCommand();
        private MySqlDataReader reader;

        public List<TinhTrang_DTO> GetDataTinhTrang()
        {
            List<TinhTrang_DTO> tinhTrang_DTOs = new List<TinhTrang_DTO>();
            command.CommandText = "SELECT * FROM tinhtrang";
            command.Connection = databaseConnection.Connection;
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tinhTrang_DTOs.Add(new TinhTrang_DTO(
                            reader.GetString("ID"),
                            reader.GetString("TinhTrang")));
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
            return tinhTrang_DTOs;
        }

        public TinhTrang_DTO GetDataTinhTrangWithId(string id)
        {
            TinhTrang_DTO tinhTrangDTO = new TinhTrang_DTO();

            command = new MySqlCommand {
                CommandText = "SELECT * FROM tinhtrang WHERE ID ='" + id + "'",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tinhTrangDTO = new TinhTrang_DTO(
                            reader.GetString("ID"),
                            reader.GetString("TinhTrang"));
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

            return tinhTrangDTO;
        }
    }
}
