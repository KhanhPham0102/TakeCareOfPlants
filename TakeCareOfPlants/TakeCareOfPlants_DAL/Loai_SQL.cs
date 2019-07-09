using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class Loai_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<Loai_DTO> GetDataLoai()
        {
            List<Loai_DTO> loai_DTOs = new List<Loai_DTO>();
            command = new MySqlCommand {
                CommandText = "SELECT * FROM loaicaycanh",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        loai_DTOs.Add(
                            new Loai_DTO(
                                reader.GetString("ID"),
                                reader.GetString("loai")));
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
            return loai_DTOs;
        }

        public Loai_DTO GetDataLoaiWithId(string id)
        {
            Loai_DTO loaiDTO = new Loai_DTO();

            command = new MySqlCommand {
                CommandText = "SELECT * FROM loaicaycanh WHERE ID ='" + id + "'",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        loaiDTO = new Loai_DTO(
                            reader.GetString("ID"), 
                            reader.GetString("loai"));
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

            return loaiDTO;
        }
    }
}
