using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class MuaVatTu_SQL
    {
        private readonly DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;

        public void InsertDataMuaVatTu(List<Tuple<string, string, MuaVatTu_DTO>> data,
                                       List<string> vatTuMoi,
                                       List<string> donViMoi)
        {
            command = new MySqlCommand {
                Connection = databaseConnection.Connection
            };

            try {
                databaseConnection.OpenConnect();

                if (donViMoi != null) {
                    foreach (string donVi in donViMoi) {
                        command.CommandText = "INSERT INTO donvi(DonVi) VALUE (@dv)";
                        command.Parameters.AddWithValue("@dv", value: donVi);
                        command.ExecuteNonQuery();
                        command.Dispose();
                    }
                }

                if (vatTuMoi != null) {
                    foreach (string vatTu in vatTuMoi) {
                        List<Tuple<string, string, MuaVatTu_DTO>> value = data.Where(t => t.Item1 == vatTu).ToList();
                        command.CommandText = "INSERT INTO vattu(VatTu, IDDonVi) VALUE (@tc, SELECT ID FROM donvi WHERE DonVi = '"+ value[0].Item2 +"' )";
                        command.Parameters.AddWithValue("@tc", value: vatTu);
                        command.ExecuteNonQuery();
                        command.Dispose();
                    }
                }

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
        }
    }
}
