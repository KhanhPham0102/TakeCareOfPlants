using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class DonVi_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<DonVi_DTO> GetDataDonVi()
        {
            List<DonVi_DTO> donVi_DTOs = new List<DonVi_DTO>();
            command = new MySqlCommand {
                CommandText = "SELECT * FROM donvi",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        donVi_DTOs.Add(new DonVi_DTO(reader.GetString("ID"), reader.GetString("DonVi")));
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
            return donVi_DTOs;
        }
    }
}
